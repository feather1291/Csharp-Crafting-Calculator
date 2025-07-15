using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Crafting_Calculator
{
    //物品
    [Serializable]
    class Item
    {
        public string name;//物品名
        public List<Item> material_index;//材料索引列表
        public List<int> material_num;//材料数量
        public List<Item> product_index;//产物索引列表
        public int crafting_num;//合成数量
        public bool is_end;
        public Item(string name)
        {
            this.name = name;
            this.material_index = new List<Item>();
            this.material_num = new List<int>();
            this.product_index = new List<Item>();
            this.crafting_num = 1;
            this.is_end = true;
        }
    };

    //合成显示
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

    //递归记录
    class Recursive_Record
    {
        public Item id;
        public int num;
        public int level;
        public Recursive_Record(Item id, int num, int level)
        {
            this.id = id;
            this.num = num;
            this.level = level;
        }
    };

    [Serializable]
    class Crafting_table_database
    {
        //public List<Item> items = new List<Item>();
        public System.Windows.Forms.BindingSource bs;
        //public List<Crafting_Display> crafting_displays = new List<Crafting_Display>();
        public Crafting_Data data = new Crafting_Data();

        public Crafting_table_database(System.Windows.Forms.BindingSource bs)
        {
            this.bs = bs;
            bs.DataSource = data.crafting_displays;
        }
        //添加合成表
        public void add(string name, int num, List<string> material, List<int> material_num)
        {
            int renew_index = -1;
            //检查被合成物品有无重复
            for (int i = 0; i < data.items.Count; i++)
            {
                if (data.items[i].name == name)//如果与输入物品重复且物品不是末端节点
                {
                    if (data.items[i].is_end) renew_index = i;
                    else throw new ArgumentException("同一个物品不能存在两种合成方式！", nameof(name));
                }
            }
            //检查原料是否与物品列表有重复
            bool add_flag = true;
            List<Item> material_index = new List<Item> { };
            for (int i = 0; i < material.Count; i++)
            {
                add_flag = true;
                for (int j = 0; j < data.items.Count; j++)
                {
                    if (material[i] == data.items[j].name)//如果重复
                    {
                        material_index.Add(data.items[j]);
                        add_flag = false;
                        break;
                    }
                }
                if(add_flag)
                {
                    //添加原料对象
                    Item temp_material = new Item(material[i]);
                    data.items.Add(temp_material);
                    bs.Add(data_to_display(temp_material));
                    material_index.Add(temp_material);
                }
            }

            //被合成物对象导入数据库
            Item input_item = new Item(name);
            if (renew_index == -1)  //不需要更新原有的物品信息
            {
                input_item.material_index = material_index;
                input_item.material_num = material_num;
                input_item.crafting_num = num;
                input_item.is_end = false;
                data.items.Add(input_item);
                bs.Add(data_to_display(input_item));
            }
            else                    //更新信息
            {
                input_item = data.items[renew_index];
                input_item.material_index = material_index;
                input_item.material_num = material_num;
                input_item.crafting_num = num;
                input_item.is_end = false;
                bs[renew_index] = (data_to_display(input_item));
            }
            //向原料对象中新增当前产物
            for (int i = 0; i < material_index.Count; i++)
            {
                material_index[i].product_index.Add(input_item);
            }
        }

        //修改合成表
        public void edit(int edit_index, string name, int num, List<string> material, List<int> material_num)
        {
            
        }

        //进行原料计算
        public void material_calculate(List<string> crafting_plan, List<int> crafting_num,ref string output_text)
        {
            //列出物品的索引列表
            List<Item> calculate_index = new List<Item>();
            for (int i = 0; i < crafting_plan.Count; i++)//遍历目标物品
            {
                //搜索合成表以匹配 
                int j;
                for (j = -1; ++j < data.items.Count;)
                {
                    if (data.items[j].name == crafting_plan[i])
                    {
                        calculate_index.Add(data.items[j]);
                        break;
                    }
                        
                }
                //如果没找到目标原料
                if (j == data.items.Count) throw new ArgumentException("未找到物品的合成方式", crafting_plan[i]);
            }
            //实例化递归输出的列表
            List<Recursive_Record> record = new List<Recursive_Record>();

            //广度优先遍历
            int max_level = BF_search(calculate_index, crafting_num, record, 0);
            //转换为过程文本
            List<Recursive_Record> material_list = new List<Recursive_Record>();
            for(int i=0; i<record.Count; i++)
            {
                if(record[i].id.is_end)//如果是叶子节点,记录
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
                sb.Append(material_list[i].id.name);
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
                        sb.Append(record[j].id.name);
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
        private int BF_search(List<Item> calculate_index, List<int> crafting_num, List<Recursive_Record> record, int level)
        {
            //拷贝
            List<Item> material_index = new List<Item>();
            List<int> material_num = new List<int>();
            //遍历并生成递归记录
            for (int i = 0; i < calculate_index.Count; i++)
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
                for(int j=0; j< calculate_index[i].material_index.Count; j++)
                {
                    //检查是否在原料表中重复
                    add_flag = true;
                    for (int k=0; k<material_index.Count; k++)
                    {
                        if(material_index[k] == calculate_index[i].material_index[j])
                        {
                            material_num[k] = material_num[k] + calculate_index[i].material_num[j] * crafting_num[i];
                            add_flag = false;
                            break;
                        }
                    }
                    if(add_flag)
                    {
                        material_index.Add(calculate_index[i].material_index[j]);
                        material_num.Add(calculate_index[i].material_num[j] * crafting_num[i]);
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
                sb.Append(input.material_index[i].name);
                sb.Append('*');
                sb.Append(input.material_num[i]);
                sb.Append(", ");
            }
            material = sb.ToString();
            return new Crafting_Display(item, material);
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
