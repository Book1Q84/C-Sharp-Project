namespace CompanyManageSystem
{
    partial class Basic_Info_Employee_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basic_Info_Employee_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.确定YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.e_note_textbox = new System.Windows.Forms.TextBox();
            this.e_tel_textbox = new System.Windows.Forms.TextBox();
            this.e_note_label = new System.Windows.Forms.Label();
            this.e_sex_comboBox = new System.Windows.Forms.ComboBox();
            this.e_id_textbox = new System.Windows.Forms.TextBox();
            this.m_addr_label = new System.Windows.Forms.Label();
            this.e_dp_textbox = new System.Windows.Forms.TextBox();
            this.e_id_label = new System.Windows.Forms.Label();
            this.e_name_label = new System.Windows.Forms.Label();
            this.e_name_textbox = new System.Windows.Forms.TextBox();
            this.e_dp_label = new System.Windows.Forms.Label();
            this.e_sex_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.e_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_dp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.确定YToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(737, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.添加ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加ToolStripMenuItem.Image")));
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.添加ToolStripMenuItem.Text = "添加（A）";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.编辑ToolStripMenuItem.Enabled = false;
            this.编辑ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("编辑ToolStripMenuItem.Image")));
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
            this.编辑ToolStripMenuItem.Text = "编辑（E）";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.删除ToolStripMenuItem.Enabled = false;
            this.删除ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("删除ToolStripMenuItem.Image")));
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(101, 28);
            this.删除ToolStripMenuItem.Text = "删除（D）";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.保存ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存ToolStripMenuItem.Image")));
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
            this.保存ToolStripMenuItem.Text = "保存（S）";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 确定YToolStripMenuItem
            // 
            this.确定YToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.确定YToolStripMenuItem.Enabled = false;
            this.确定YToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("确定YToolStripMenuItem.Image")));
            this.确定YToolStripMenuItem.Name = "确定YToolStripMenuItem";
            this.确定YToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
            this.确定YToolStripMenuItem.Text = "确定（Y）";
            this.确定YToolStripMenuItem.Click += new System.EventHandler(this.确定YToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.e_note_textbox);
            this.groupBox1.Controls.Add(this.e_tel_textbox);
            this.groupBox1.Controls.Add(this.e_note_label);
            this.groupBox1.Controls.Add(this.e_sex_comboBox);
            this.groupBox1.Controls.Add(this.e_id_textbox);
            this.groupBox1.Controls.Add(this.m_addr_label);
            this.groupBox1.Controls.Add(this.e_dp_textbox);
            this.groupBox1.Controls.Add(this.e_id_label);
            this.groupBox1.Controls.Add(this.e_name_label);
            this.groupBox1.Controls.Add(this.e_name_textbox);
            this.groupBox1.Controls.Add(this.e_dp_label);
            this.groupBox1.Controls.Add(this.e_sex_label);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(720, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "在职员工——基本信息";
            // 
            // e_note_textbox
            // 
            this.e_note_textbox.Enabled = false;
            this.e_note_textbox.Location = new System.Drawing.Point(480, 60);
            this.e_note_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_note_textbox.Multiline = true;
            this.e_note_textbox.Name = "e_note_textbox";
            this.e_note_textbox.Size = new System.Drawing.Size(237, 23);
            this.e_note_textbox.TabIndex = 56;
            // 
            // e_tel_textbox
            // 
            this.e_tel_textbox.Enabled = false;
            this.e_tel_textbox.Location = new System.Drawing.Point(533, 20);
            this.e_tel_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_tel_textbox.Name = "e_tel_textbox";
            this.e_tel_textbox.Size = new System.Drawing.Size(135, 21);
            this.e_tel_textbox.TabIndex = 57;
            // 
            // e_note_label
            // 
            this.e_note_label.AutoSize = true;
            this.e_note_label.Location = new System.Drawing.Point(467, 47);
            this.e_note_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_note_label.Name = "e_note_label";
            this.e_note_label.Size = new System.Drawing.Size(65, 12);
            this.e_note_label.TabIndex = 51;
            this.e_note_label.Text = "员工备注：";
            // 
            // e_sex_comboBox
            // 
            this.e_sex_comboBox.Enabled = false;
            this.e_sex_comboBox.FormattingEnabled = true;
            this.e_sex_comboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.e_sex_comboBox.Location = new System.Drawing.Point(300, 20);
            this.e_sex_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_sex_comboBox.Name = "e_sex_comboBox";
            this.e_sex_comboBox.Size = new System.Drawing.Size(133, 20);
            this.e_sex_comboBox.TabIndex = 58;
            // 
            // e_id_textbox
            // 
            this.e_id_textbox.Enabled = false;
            this.e_id_textbox.Location = new System.Drawing.Point(80, 20);
            this.e_id_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_id_textbox.Name = "e_id_textbox";
            this.e_id_textbox.Size = new System.Drawing.Size(135, 21);
            this.e_id_textbox.TabIndex = 53;
            // 
            // m_addr_label
            // 
            this.m_addr_label.AutoSize = true;
            this.m_addr_label.Location = new System.Drawing.Point(467, 20);
            this.m_addr_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_addr_label.Name = "m_addr_label";
            this.m_addr_label.Size = new System.Drawing.Size(65, 12);
            this.m_addr_label.TabIndex = 52;
            this.m_addr_label.Text = "员工电话：";
            // 
            // e_dp_textbox
            // 
            this.e_dp_textbox.Enabled = false;
            this.e_dp_textbox.Location = new System.Drawing.Point(300, 53);
            this.e_dp_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_dp_textbox.Name = "e_dp_textbox";
            this.e_dp_textbox.Size = new System.Drawing.Size(135, 21);
            this.e_dp_textbox.TabIndex = 55;
            // 
            // e_id_label
            // 
            this.e_id_label.AutoSize = true;
            this.e_id_label.Location = new System.Drawing.Point(10, 20);
            this.e_id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_id_label.Name = "e_id_label";
            this.e_id_label.Size = new System.Drawing.Size(65, 12);
            this.e_id_label.TabIndex = 47;
            this.e_id_label.Text = "员工编号：";
            // 
            // e_name_label
            // 
            this.e_name_label.AutoSize = true;
            this.e_name_label.Location = new System.Drawing.Point(10, 53);
            this.e_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_name_label.Name = "e_name_label";
            this.e_name_label.Size = new System.Drawing.Size(65, 12);
            this.e_name_label.TabIndex = 48;
            this.e_name_label.Text = "员工姓名：";
            // 
            // e_name_textbox
            // 
            this.e_name_textbox.Enabled = false;
            this.e_name_textbox.Location = new System.Drawing.Point(80, 53);
            this.e_name_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_name_textbox.Name = "e_name_textbox";
            this.e_name_textbox.Size = new System.Drawing.Size(135, 21);
            this.e_name_textbox.TabIndex = 54;
            // 
            // e_dp_label
            // 
            this.e_dp_label.AutoSize = true;
            this.e_dp_label.Location = new System.Drawing.Point(240, 53);
            this.e_dp_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_dp_label.Name = "e_dp_label";
            this.e_dp_label.Size = new System.Drawing.Size(65, 12);
            this.e_dp_label.TabIndex = 50;
            this.e_dp_label.Text = "员工部门：";
            // 
            // e_sex_label
            // 
            this.e_sex_label.AutoSize = true;
            this.e_sex_label.Location = new System.Drawing.Point(240, 20);
            this.e_sex_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_sex_label.Name = "e_sex_label";
            this.e_sex_label.Size = new System.Drawing.Size(65, 12);
            this.e_sex_label.TabIndex = 49;
            this.e_sex_label.Text = "员工性别：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.e_id,
            this.e_name,
            this.e_sex,
            this.e_dp,
            this.e_tel,
            this.e_note});
            this.dataGridView1.Location = new System.Drawing.Point(8, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(720, 289);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // e_id
            // 
            this.e_id.HeaderText = "员工编号";
            this.e_id.MinimumWidth = 8;
            this.e_id.Name = "e_id";
            this.e_id.ReadOnly = true;
            this.e_id.Width = 150;
            // 
            // e_name
            // 
            this.e_name.HeaderText = "员工姓名";
            this.e_name.MinimumWidth = 8;
            this.e_name.Name = "e_name";
            this.e_name.ReadOnly = true;
            this.e_name.Width = 150;
            // 
            // e_sex
            // 
            this.e_sex.HeaderText = "员工性别";
            this.e_sex.MinimumWidth = 8;
            this.e_sex.Name = "e_sex";
            this.e_sex.ReadOnly = true;
            this.e_sex.Width = 150;
            // 
            // e_dp
            // 
            this.e_dp.HeaderText = "员工部门";
            this.e_dp.MinimumWidth = 8;
            this.e_dp.Name = "e_dp";
            this.e_dp.ReadOnly = true;
            this.e_dp.Width = 150;
            // 
            // e_tel
            // 
            this.e_tel.HeaderText = "员工电话";
            this.e_tel.MinimumWidth = 8;
            this.e_tel.Name = "e_tel";
            this.e_tel.ReadOnly = true;
            this.e_tel.Width = 150;
            // 
            // e_note
            // 
            this.e_note.HeaderText = "员工备注";
            this.e_note.MinimumWidth = 8;
            this.e_note.Name = "e_note";
            this.e_note.ReadOnly = true;
            this.e_note.Width = 150;
            // 
            // Basic_Info_Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 443);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Basic_Info_Employee_Form";
            this.Text = "在职员工——基本信息";
            this.Load += new System.EventHandler(this.Basic_Info_Employee_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 确定YToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox e_note_textbox;
        private System.Windows.Forms.TextBox e_tel_textbox;
        private System.Windows.Forms.Label e_note_label;
        private System.Windows.Forms.ComboBox e_sex_comboBox;
        private System.Windows.Forms.TextBox e_id_textbox;
        private System.Windows.Forms.Label m_addr_label;
        private System.Windows.Forms.TextBox e_dp_textbox;
        private System.Windows.Forms.Label e_id_label;
        private System.Windows.Forms.Label e_name_label;
        private System.Windows.Forms.TextBox e_name_textbox;
        private System.Windows.Forms.Label e_dp_label;
        private System.Windows.Forms.Label e_sex_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_dp;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_note;
    }
}