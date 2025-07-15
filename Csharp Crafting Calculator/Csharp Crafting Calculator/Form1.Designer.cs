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
            this.calculate_panel.SuspendLayout();
            this.manage_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayed_crafting_table)).BeginInit();
            this.add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // calculate_panel
            // 
            this.calculate_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.calculate_panel.Controls.Add(this.label3);
            this.calculate_panel.Controls.Add(this.label2);
            this.calculate_panel.Controls.Add(this.product_box);
            this.calculate_panel.Controls.Add(this.cal_btn);
            this.calculate_panel.Controls.Add(this.process_box);
            this.calculate_panel.Location = new System.Drawing.Point(0, 46);
            this.calculate_panel.Name = "calculate_panel";
            this.calculate_panel.Size = new System.Drawing.Size(800, 407);
            this.calculate_panel.TabIndex = 3;
            this.calculate_panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.manage_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.manage_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manage_button.Location = new System.Drawing.Point(0, -2);
            this.manage_button.Name = "manage_button";
            this.manage_button.Size = new System.Drawing.Size(394, 42);
            this.manage_button.TabIndex = 0;
            this.manage_button.Text = "合成表管理";
            this.manage_button.UseVisualStyleBackColor = true;
            this.manage_button.Click += new System.EventHandler(this.manage_button_Click);
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.calculate_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calculate_button.Location = new System.Drawing.Point(400, -2);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(400, 42);
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
            this.manage_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manage_panel.Controls.Add(this.search_box);
            this.manage_panel.Controls.Add(this.load_button);
            this.manage_panel.Controls.Add(this.add_button);
            this.manage_panel.Controls.Add(this.save_button);
            this.manage_panel.Controls.Add(this.displayed_crafting_table);
            this.manage_panel.Controls.Add(this.search_button);
            this.manage_panel.Location = new System.Drawing.Point(0, 46);
            this.manage_panel.Name = "manage_panel";
            this.manage_panel.Size = new System.Drawing.Size(800, 407);
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
            this.displayed_crafting_table.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.displayed_crafting_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayed_crafting_table.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.displayed_crafting_table.Location = new System.Drawing.Point(27, 100);
            this.displayed_crafting_table.Name = "displayed_crafting_table";
            this.displayed_crafting_table.RowTemplate.Height = 23;
            this.displayed_crafting_table.Size = new System.Drawing.Size(744, 293);
            this.displayed_crafting_table.TabIndex = 1;
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
            // 
            // add_panel
            // 
            this.add_panel.BackColor = System.Drawing.SystemColors.Info;
            this.add_panel.Controls.Add(this.add_makesure_button);
            this.add_panel.Controls.Add(this.label1);
            this.add_panel.Controls.Add(this.add_item_label);
            this.add_panel.Controls.Add(this.add_material_box);
            this.add_panel.Controls.Add(this.add_item_box);
            this.add_panel.Controls.Add(this.back_add_button);
            this.add_panel.Location = new System.Drawing.Point(0, 46);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(800, 407);
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
            this.back_add_button.Location = new System.Drawing.Point(12, 19);
            this.back_add_button.Name = "back_add_button";
            this.back_add_button.Size = new System.Drawing.Size(75, 38);
            this.back_add_button.TabIndex = 0;
            this.back_add_button.Text = "返回";
            this.back_add_button.UseVisualStyleBackColor = true;
            this.back_add_button.Click += new System.EventHandler(this.back_add_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.manage_button);
            this.Controls.Add(this.calculate_panel);
            this.Controls.Add(this.add_panel);
            this.Controls.Add(this.manage_panel);
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
    }
}

