using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Crafting_Calculator
{
    //物品类
    [Serializable]
    class Item
    {
        public string name;//物品名
        public List<int> material_index;//材料索引列表
        public List<int> material_num;//材料数量
        public int crafting_num;//合成数量
        public bool is_end;
        public Item(string name)
        {
            this.name = name;
            this.material_index = new List<int>();
            this.material_num = new List<int>();
            this.crafting_num = 1;
            this.is_end = true;
        }
    };

    //合成显示类
    [Serializable]
    class Crafting_Display
    {
        public string item { get; set; }//物品名
        public string materials { get; set; }//材料
        public Crafting_Display(string x, string y)
        {
            item = x;
            materials = y;
        }
    };

    //递归记录结构体
    class Recursive_Record
    {
        public int id;
        public int num;
        public int level;
        public Recursive_Record(int id, int num, int level)
        {
            this.id = id;
            this.num = num;
            this.level = level;
        }
    };

    [Serializable]
    class Crafting_table_database
    {
        public List<Item> items = new List<Item>();
        public System.Windows.Forms.BindingSource bs;
        public List<Crafting_Display> crafting_displays = new List<Crafting_Display>();
        public Crafting_Data data;

        public Crafting_table_database(System.Windows.Forms.BindingSource bs)
        {
            this.bs = bs;
            bs.DataSource = crafting_displays;
            //bs.Add(new Crafting_Display("产物", "材料" ));
            data = new Crafting_Data(items, crafting_displays);
        }
        //添加合成表
        public void add(string name, int num, List<string> material, List<int> material_num)
        {
            int renew_index = -1;
            //检查被合成物品有无重复
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == name)//如果与输入物品重复且物品不是末端节点
                {
                    if (items[i].is_end) renew_index = i;
                    else throw new ArgumentException("同一个物品不能存在两种合成方式！", nameof(name));
                }
            }
            //检查原料是否与物品列表有重复
            bool add_flag = true;
            List<int> material_index = new List<int> { };
            for (int i = 0; i < material.Count; i++)
            {
                add_flag = true;
                for (int j = 0; j < items.Count; j++)
                {
                    if (material[i] == items[j].name)//如果重复
                    {
                        material_index.Add(j);
                        add_flag = false;
                        break;
                    }
                }
                if(add_flag)
                {
                    //添加原料对象
                    material_index.Add(items.Count);
                    Item temp_material = new Item(material[i]);
                    items.Add(temp_material);
                    bs.Add(data_to_display(temp_material));
                }
            }
            //添加被合成物对象
            Item input_item = new Item(name)
            {
                material_index = material_index,
                material_num = material_num,
                crafting_num = num,
                is_end = false
            };
            if (renew_index == -1)  //不需要更新原有的物品信息
            {
                items.Add(input_item);
                bs.Add(data_to_display(input_item));
            }
            else                    //更新信息
            {
                items[renew_index] = input_item;
                bs[renew_index] = (data_to_display(input_item));
            }
        }

        //修改合成表
        public void edit(int edit_index, string name, int num, List<string> material, List<int> material_num)
        {
            //检查修改后的名称有无重复
            for (int i = 0; i < items.Count; i++)
            {
                if (i == edit_index) continue;
                if (items[i].name == name)//如果已有物品与编辑后的名称重复
                {
                    throw new ArgumentException("同一个物品不能存在两种合成方式！", name);
                }
            }
            //检查原料是否与物品列表有重复
            List<int> material_index = new List<int> { };
            for (int i = 0; i < material.Count; i++)
            {
                for (int j = 0; j < items.Count; j++)
                {
                    if (material[i] == items[j].name)//如果重复
                    {
                        material_index.Add(j);
                    }
                    else//不重复
                    {
                        //添加原料对象
                        Item temp_material = new Item(material[i]);
                        items.Add(temp_material);
                        bs.Add(data_to_display(temp_material));
                    }
                }
            }
            //修改被合成物对象
            Item input_item = new Item(name)
            {
                material_index = material_index,
                material_num = material_num,
                crafting_num = num,
                is_end = false
            };
            items[edit_index] = input_item;
            bs[edit_index] = (data_to_display(input_item));
        }

        //进行原料计算
        public void material_calculate(List<string> crafting_plan, List<int> crafting_num,ref string output_text)
        {
            //列出物品的索引列表
            List<int> calculate_index = new List<int>();
            for (int i = 0; i < crafting_plan.Count; i++)//遍历目标物品
            {
                //搜索合成表以匹配 
                int j;
                for (j = -1; ++j < items.Count;)
                {
                    if (items[j].name == crafting_plan[i])
                    {
                        calculate_index.Add(j);
                        break;
                    }
                        
                }
                //如果没找到目标原料
                if (j == items.Count) throw new ArgumentException("未找到物品的合成方式", crafting_plan[i]);
            }
            //实例化递归输出的列表
            List<Recursive_Record> record = new List<Recursive_Record>();

            //广度优先遍历
            int max_level = BF_search(calculate_index, crafting_num, record, 0);
            //转换为过程文本
            List<Recursive_Record> material_list = new List<Recursive_Record>();
            for(int i=0; i<record.Count; i++)
            {
                if(items[record[i].id].is_end)//如果是叶子节点,记录
                {
                    material_list.Add(record[i]);
                    //material_list.RemoveAt(i);
                    //i--;
                }
            }
            var sb = new StringBuilder();
            //打印原料
            sb.Append("原料："); sb.AppendLine();
            for (int i = 0; i < material_list.Count; i++)
            {
                sb.Append(items[material_list[i].id].name);
                sb.Append('*');
                sb.Append(material_list[i].num);sb.Append(", "); 
            }
            sb.AppendLine();
            //打印过程
            sb.Append("合成步骤："); sb.AppendLine();
            for (int i = max_level; i >= 0; i--)
            {
                sb.Append("步骤"); sb.Append(max_level - i + 1); sb.Append(":  ");
                for (int j = 0; j < record.Count; j++)
                {
                    if(record[j].level == i)
                    {
                        sb.Append(items[record[j].id].name);
                        sb.Append('*');
                        sb.Append(record[j].num); sb.Append(", ");
                        //record.RemoveAt(j);
                        //j--;
                    }
                }
                sb.AppendLine();
            }
            output_text = sb.ToString();
        }

        //广度优先递归函数
        private int BF_search(List<int> calculate_index, List<int> crafting_num, List<Recursive_Record> record, int level)
        {
            //拷贝
            List<int> current_index = new List<int>(calculate_index);
            List<int> current_num = new List<int>(crafting_num);
            List<int> material_index = new List<int>();
            List<int> material_num = new List<int>();
            //遍历并生成递归记录
            for (int i = 0; i < current_index.Count; i++)
            {
                //检查是否在记录表中重复
                bool add_flag = true;
                for(int j=0; j<record.Count; j++)
                {
                    if(calculate_index[i] == record[j].id)
                    {
                        record[j] = new Recursive_Record(calculate_index[i], crafting_num[i]+ record[j].num, Math.Max(record[j].level, level));
                        add_flag = false;
                        break;
                    }
                }
                if(add_flag) record.Add(new Recursive_Record(calculate_index[i], crafting_num[i], level));//记录被合成物品
                //生成原料列表
                for(int j=0; j<items[calculate_index[i]].material_index.Count; j++)
                {
                    //检查是否在原料表中重复
                    add_flag = true;
                    for (int k=0; k<material_index.Count; k++)
                    {
                        if(material_index[k] == items[calculate_index[i]].material_index[j])
                        {
                            material_num[k] = material_num[k] + items[calculate_index[i]].material_num[j] * crafting_num[i];
                            add_flag = false;
                            break;
                        }
                    }
                    if(add_flag)
                    {
                        material_index.Add(items[calculate_index[i]].material_index[j]);
                        material_num.Add(items[calculate_index[i]].material_num[j] * crafting_num[i]);
                    }
                    
                }
            }
            //递归其原料
            int max_level = 0;
            if (material_index.Count != 0)
                max_level = BF_search(material_index, material_num, record, level + 1);

            return Math.Max(level, max_level);
        }
        private Crafting_Display data_to_display(Item input)
        {
            string item;
            string material;
            var sb = new StringBuilder();
            //提取物品内容
            sb.Append(input.name);
            sb.Append('*');
            sb.Append(input.crafting_num);
            item = sb.ToString();
            //提取原料内容
            sb.Clear();
            for(int i=0; i<input.material_index.Count; i++)
            {
                //添加原料名，数量，换行
                sb.Append(items[input.material_index[i]].name);
                sb.Append('*');
                sb.Append(input.material_num[i]);
                sb.Append(", ");
            }
            material = sb.ToString();
            return new Crafting_Display(item, material);
        }
        public void load()
        {
            items = data.items;
            crafting_displays = data.crafting_displays;
        }
    }

    [Serializable]
    class Crafting_Data
    {
        public List<Item> items;
        public List<Crafting_Display> crafting_displays;
        public Crafting_Data(List<Item> x, List<Crafting_Display> y)
        {
            items = x;
            crafting_displays = y;
        }
        public Crafting_Data()
        {
            items = new List<Item>();
            crafting_displays = new List<Crafting_Display>();
        }
    }
}
