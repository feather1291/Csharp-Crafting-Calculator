namespace Csharp_Crafting_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.calculate_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_box = new System.Windows.Forms.RichTextBox();
            this.cal_btn = new System.Windows.Forms.Button();
            this.process_box = new System.Windows.Forms.RichTextBox();
            this.manage_button = new System.Windows.Forms.Button();
            this.calculate_button = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.manage_panel = new System.Windows.Forms.Panel();
            this.search_box = new System.Windows.Forms.TextBox();
            this.load_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.displayed_crafting_table = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.add_panel = new System.Windows.Forms.Panel();
            this.add_makesure_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.add_item_label = new System.Windows.Forms.Label();
            this.add_material_box = new System.Windows.Forms.RichTextBox();
            this.add_item_box = new System.Windows.Forms.TextBox();
            this.back_add_button = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.detail_panel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calculate_panel.SuspendLayout();
            this.manage_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayed_crafting_table)).BeginInit();
            this.add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.detail_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculate_panel
            // 
            this.calculate_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.calculate_panel.Controls.Add(this.label3);
            this.calculate_panel.Controls.Add(this.label2);
            this.calculate_panel.Controls.Add(this.product_box);
            this.calculate_panel.Controls.Add(this.cal_btn);
            this.calculate_panel.Controls.Add(this.process_box);
            this.calculate_panel.Location = new System.Drawing.Point(0, 49);
            this.calculate_panel.Name = "calculate_panel";
            this.calculate_panel.Size = new System.Drawing.Size(800, 404);
            this.calculate_panel.TabIndex = 3;
            this.calculate_panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "原料及合成过程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "产物列表";
            // 
            // product_box
            // 
            this.product_box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.product_box.Location = new System.Drawing.Point(27, 33);
            this.product_box.Name = "product_box";
            this.product_box.Size = new System.Drawing.Size(637, 61);
            this.product_box.TabIndex = 3;
            this.product_box.Text = "";
            // 
            // cal_btn
            // 
            this.cal_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cal_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cal_btn.Location = new System.Drawing.Point(685, 33);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(75, 33);
            this.cal_btn.TabIndex = 2;
            this.cal_btn.Text = "计算";
            this.cal_btn.UseVisualStyleBackColor = true;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // process_box
            // 
            this.process_box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.process_box.Location = new System.Drawing.Point(27, 129);
            this.process_box.Name = "process_box";
            this.process_box.Size = new System.Drawing.Size(744, 264);
            this.process_box.TabIndex = 1;
            this.process_box.Text = "";
            // 
            // manage_button
            // 
            this.manage_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manage_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.manage_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manage_button.Location = new System.Drawing.Point(270, 5);
            this.manage_button.Margin = new System.Windows.Forms.Padding(0);
            this.manage_button.Name = "manage_button";
            this.manage_button.Size = new System.Drawing.Size(105, 42);
            this.manage_button.TabIndex = 0;
            this.manage_button.Text = "合成表管理";
            this.manage_button.UseVisualStyleBackColor = true;
            this.manage_button.Click += new System.EventHandler(this.manage_button_Click);
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.calculate_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calculate_button.Location = new System.Drawing.Point(384, 5);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(105, 42);
            this.calculate_button.TabIndex = 1;
            this.calculate_button.Text = "合成计算";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // manage_panel
            // 
            this.manage_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.manage_panel.Controls.Add(this.search_box);
            this.manage_panel.Controls.Add(this.load_button);
            this.manage_panel.Controls.Add(this.add_button);
            this.manage_panel.Controls.Add(this.save_button);
            this.manage_panel.Controls.Add(this.displayed_crafting_table);
            this.manage_panel.Controls.Add(this.search_button);
            this.manage_panel.Location = new System.Drawing.Point(0, 49);
            this.manage_panel.Name = "manage_panel";
            this.manage_panel.Size = new System.Drawing.Size(800, 404);
            this.manage_panel.TabIndex = 2;
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.search_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_box.Location = new System.Drawing.Point(493, 61);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(186, 29);
            this.search_box.TabIndex = 5;
            this.search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyDown);
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.load_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.load_button.Location = new System.Drawing.Point(604, 11);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 39);
            this.load_button.TabIndex = 4;
            this.load_button.Text = "加载";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_button.Location = new System.Drawing.Point(27, 11);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 39);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "添加";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.save_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.save_button.Location = new System.Drawing.Point(696, 11);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 39);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "保存";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // displayed_crafting_table
            // 
            this.displayed_crafting_table.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.displayed_crafting_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayed_crafting_table.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.displayed_crafting_table.Location = new System.Drawing.Point(27, 100);
            this.displayed_crafting_table.Name = "displayed_crafting_table";
            this.displayed_crafting_table.RowTemplate.Height = 23;
            this.displayed_crafting_table.Size = new System.Drawing.Size(744, 293);
            this.displayed_crafting_table.TabIndex = 1;
            this.displayed_crafting_table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayed_crafting_table_CellDoubleClick);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_button.Location = new System.Drawing.Point(696, 56);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 36);
            this.search_button.TabIndex = 0;
            this.search_button.Text = "搜索";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // add_panel
            // 
            this.add_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.add_panel.Controls.Add(this.add_makesure_button);
            this.add_panel.Controls.Add(this.label1);
            this.add_panel.Controls.Add(this.add_item_label);
            this.add_panel.Controls.Add(this.add_material_box);
            this.add_panel.Controls.Add(this.add_item_box);
            this.add_panel.Controls.Add(this.back_add_button);
            this.add_panel.Location = new System.Drawing.Point(0, 49);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(800, 404);
            this.add_panel.TabIndex = 4;
            this.add_panel.Visible = false;
            // 
            // add_makesure_button
            // 
            this.add_makesure_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.add_makesure_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_makesure_button.Location = new System.Drawing.Point(653, 305);
            this.add_makesure_button.Name = "add_makesure_button";
            this.add_makesure_button.Size = new System.Drawing.Size(75, 35);
            this.add_makesure_button.TabIndex = 5;
            this.add_makesure_button.Text = "确认";
            this.add_makesure_button.UseVisualStyleBackColor = true;
            this.add_makesure_button.Click += new System.EventHandler(this.add_makesure_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(320, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "合成材料";
            // 
            // add_item_label
            // 
            this.add_item_label.AutoSize = true;
            this.add_item_label.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.add_item_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_item_label.Location = new System.Drawing.Point(22, 118);
            this.add_item_label.Name = "add_item_label";
            this.add_item_label.Size = new System.Drawing.Size(74, 21);
            this.add_item_label.TabIndex = 3;
            this.add_item_label.Text = "被合成物";
            // 
            // add_material_box
            // 
            this.add_material_box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.add_material_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_material_box.Location = new System.Drawing.Point(400, 115);
            this.add_material_box.Name = "add_material_box";
            this.add_material_box.Size = new System.Drawing.Size(279, 113);
            this.add_material_box.TabIndex = 2;
            this.add_material_box.Text = "";
            // 
            // add_item_box
            // 
            this.add_item_box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.add_item_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_item_box.Location = new System.Drawing.Point(103, 115);
            this.add_item_box.Name = "add_item_box";
            this.add_item_box.Size = new System.Drawing.Size(129, 29);
            this.add_item_box.TabIndex = 1;
            // 
            // back_add_button
            // 
            this.back_add_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.back_add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_add_button.Location = new System.Drawing.Point(27, 11);
            this.back_add_button.Name = "back_add_button";
            this.back_add_button.Size = new System.Drawing.Size(75, 38);
            this.back_add_button.TabIndex = 0;
            this.back_add_button.Text = "返回";
            this.back_add_button.UseVisualStyleBackColor = true;
            this.back_add_button.Click += new System.EventHandler(this.back_add_button_Click);
            // 
            // detail_panel
            // 
            this.detail_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.detail_panel.Controls.Add(this.button4);
            this.detail_panel.Controls.Add(this.button3);
            this.detail_panel.Controls.Add(this.button1);
            this.detail_panel.Controls.Add(this.label4);
            this.detail_panel.Controls.Add(this.label5);
            this.detail_panel.Controls.Add(this.richTextBox1);
            this.detail_panel.Controls.Add(this.textBox1);
            this.detail_panel.Controls.Add(this.button2);
            this.detail_panel.Location = new System.Drawing.Point(0, 49);
            this.detail_panel.Name = "detail_panel";
            this.detail_panel.Size = new System.Drawing.Size(800, 401);
            this.detail_panel.TabIndex = 5;
            this.detail_panel.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(388, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "删除物品";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(507, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "删除合成方式";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(653, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(320, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "合成材料";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "被合成物";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Location = new System.Drawing.Point(400, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(279, 113);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(103, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 29);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(27, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(112)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.calculate_button);
            this.panel1.Controls.Add(this.manage_button);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detail_panel);
            this.Controls.Add(this.add_panel);
            this.Controls.Add(this.manage_panel);
            this.Controls.Add(this.calculate_panel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.calculate_panel.ResumeLayout(false);
            this.calculate_panel.PerformLayout();
            this.manage_panel.ResumeLayout(false);
            this.manage_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayed_crafting_table)).EndInit();
            this.add_panel.ResumeLayout(false);
            this.add_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.detail_panel.ResumeLayout(false);
            this.detail_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manage_button;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel manage_panel;
        private System.Windows.Forms.DataGridView displayed_crafting_table;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Panel add_panel;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button back_add_button;
        private System.Windows.Forms.TextBox add_item_box;
        private System.Windows.Forms.RichTextBox add_material_box;
        private System.Windows.Forms.Label add_item_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_makesure_button;
        private System.Windows.Forms.Button cal_btn;
        private System.Windows.Forms.RichTextBox process_box;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox product_box;
        private System.Windows.Forms.Panel calculate_panel;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Panel detail_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
    }
}

