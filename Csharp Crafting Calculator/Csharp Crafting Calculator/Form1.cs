using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace Csharp_Crafting_Calculator
{
    public partial class Form1 : Form
    {
        private Crafting_table_database database;
        private string database_filePath = ".\\Crafting_table";
        private Panel_Selector panel_selector = new Panel_Selector();
        public Form1()
        {
            InitializeComponent();
            panel_selector.add_panel(manage_panel);
            panel_selector.add_panel(calculate_panel);
            panel_selector.add_panel(add_panel);
            //指定表格数据源
            displayed_crafting_table.AutoGenerateColumns = true;
            displayed_crafting_table.Font =  new Font("微软雅黑", 12);
            displayed_crafting_table.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "物品", DataPropertyName = "item" });
            displayed_crafting_table.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "原料", DataPropertyName = "materials" });
            database = new Crafting_table_database(bs);
            displayed_crafting_table.DataSource = bs;
            displayed_crafting_table.ReadOnly = true;//禁止编辑表格
            displayed_crafting_table.Columns[0].FillWeight = 30; // 第1列占40%宽度
            displayed_crafting_table.Columns[1].FillWeight = 60; // 第2列占60%宽度
            displayed_crafting_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void save_database()
        {
            using (FileStream stream = new FileStream(database_filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, database.data);
            }
        }

        private Crafting_Data load_database()
        {
            if (!File.Exists(database_filePath))
            {
                throw new FileNotFoundException("文件不存在", database_filePath);
            }

            using (FileStream stream = new FileStream(database_filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Crafting_Data)formatter.Deserialize(stream);
            }
        }

        private void manage_button_Click(object sender, EventArgs e)
        {
            panel_selector.only_display(manage_panel);
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            panel_selector.only_display(calculate_panel);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            save_database();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            panel_selector.only_display(add_panel);
        }

        private void back_add_button_Click(object sender, EventArgs e)
        {
            panel_selector.only_display(manage_panel);
        }

        private void add_makesure_button_Click(object sender, EventArgs e)
        {
            List<string> item_name = new List<string>();
            List<int> item_num = new List<int>();
            List<string> material_name = new List<string>();
            List<int> material_num = new List<int>();
            //提取文字内容
            try
            {
                item_info_extract(add_item_box.Text, item_name, item_num);
                item_info_extract(add_material_box.Text, material_name, material_num);
            }
            catch (Exception err)
            {
                //显示错误
                MessageBox.Show(err.ToString());
                return;
            }
            //检测是否存在与产物相同原料
            for(int i=0; i<material_name.Count; i++)
            {
                if(material_name[i] == item_name[0])
                {
                    MessageBox.Show(string.Format("产物{0}不能同时出现在合成材料中", item_name[0]));
                    return;
                }
            }
            //进行物品添加
            try
            {
                database.add(item_name[0], item_num[0], material_name, material_num);
            }
            catch (Exception err)
            {
                //显示错误
                MessageBox.Show(err.ToString());
                return;
            }
        }
        //对单个字符串进行提取
        private void item_info_extract(string input, List<string> names, List<int> nums)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("输入不能为空！", input);

            // 使用正则表达式匹配"物品名*数量"格式
            var regex = new Regex(@"^(?<name>[^*]+)(?:\*(?<quantity>\d+))?$");

            // 按行分割输入
            string[] lines = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                Match match = regex.Match(line.Trim());
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    int quantity = 1; // 默认数量为1

                    // 如果存在数量部分，则解析它
                    if (match.Groups["quantity"].Success)
                    {
                        quantity = int.Parse(match.Groups["quantity"].Value);
                    }

                    names.Add(name);
                    nums.Add(quantity);
                }
                else
                {
                    // 处理格式错误的行
                    Console.WriteLine($"格式错误: {line}");
                    throw new ArgumentException("输入格式错误！", line);
                }
            }

            return ;
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            try
            {
                database.data = load_database();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            database.load();
            bs.DataSource = database.crafting_displays;
            bs.ResetBindings(false);
        }

        private void cal_btn_Click(object sender, EventArgs e)
        {
            string input = product_box.Text;
            if (input.Length == 0) return;
            List<string> item_name = new List<string>();
            List<int> item_num = new List<int>();
            //提取文字内容
            try
            {
                item_info_extract(product_box.Text, item_name, item_num);
            }
            catch (Exception err)
            {
                //显示错误
                MessageBox.Show(err.ToString());
                return;
            }
            string output_text = null;
            database.material_calculate(item_name, item_num, ref output_text);
            process_box.Text = output_text;
        }
    }
    class Panel_Selector
    {
        List<Panel> panels = new List<Panel>();
        public void only_display(Panel panel)
        {
            panel.Visible = true;
            for(int i=0; i<panels.Count; i++)
            {
                if (panel != panels[i]) panels[i].Visible = false;
            }
        }

        public void add_panel(Panel panel)
        {
            panels.Add(panel);
        }
    }
}
