namespace CompanyManageSystem
{
    partial class Basic_Info_Unit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basic_Info_Unit_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.确定YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.u_account_textbox = new System.Windows.Forms.TextBox();
            this.u_account_label = new System.Windows.Forms.Label();
            this.u_addr_textbox = new System.Windows.Forms.TextBox();
            this.u_telperson_textbox = new System.Windows.Forms.TextBox();
            this.u_tex_textbox = new System.Windows.Forms.TextBox();
            this.u_tel_textbox = new System.Windows.Forms.TextBox();
            this.u_name_textbox = new System.Windows.Forms.TextBox();
            this.u_id_textbox = new System.Windows.Forms.TextBox();
            this.u_addr_label = new System.Windows.Forms.Label();
            this.u_telperson_label = new System.Windows.Forms.Label();
            this.u_tex_label = new System.Windows.Forms.Label();
            this.e_tel_label = new System.Windows.Forms.Label();
            this.m_name_label = new System.Windows.Forms.Label();
            this.u_id_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.u_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_tex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_telperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip1.TabIndex = 1;
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
            this.编辑ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.编辑ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("编辑ToolStripMenuItem.Image")));
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
            this.编辑ToolStripMenuItem.Text = "编辑（E）";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.BackColor = System.Drawing.Color.Red;
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
            this.确定YToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("确定YToolStripMenuItem.Image")));
            this.确定YToolStripMenuItem.Name = "确定YToolStripMenuItem";
            this.确定YToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
            this.确定YToolStripMenuItem.Text = "确定（Y）";
            this.确定YToolStripMenuItem.Click += new System.EventHandler(this.确定YToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.u_account_textbox);
            this.groupBox1.Controls.Add(this.u_account_label);
            this.groupBox1.Controls.Add(this.u_addr_textbox);
            this.groupBox1.Controls.Add(this.u_telperson_textbox);
            this.groupBox1.Controls.Add(this.u_tex_textbox);
            this.groupBox1.Controls.Add(this.u_tel_textbox);
            this.groupBox1.Controls.Add(this.u_name_textbox);
            this.groupBox1.Controls.Add(this.u_id_textbox);
            this.groupBox1.Controls.Add(this.u_addr_label);
            this.groupBox1.Controls.Add(this.u_telperson_label);
            this.groupBox1.Controls.Add(this.u_tex_label);
            this.groupBox1.Controls.Add(this.e_tel_label);
            this.groupBox1.Controls.Add(this.m_name_label);
            this.groupBox1.Controls.Add(this.u_id_label);
            this.groupBox1.Location = new System.Drawing.Point(9, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(720, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库存商品——基本信息";
            // 
            // u_account_textbox
            // 
            this.u_account_textbox.Enabled = false;
            this.u_account_textbox.Location = new System.Drawing.Point(639, 17);
            this.u_account_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_account_textbox.Name = "u_account_textbox";
            this.u_account_textbox.Size = new System.Drawing.Size(79, 21);
            this.u_account_textbox.TabIndex = 13;
            // 
            // u_account_label
            // 
            this.u_account_label.AutoSize = true;
            this.u_account_label.Location = new System.Drawing.Point(553, 20);
            this.u_account_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.u_account_label.Name = "u_account_label";
            this.u_account_label.Size = new System.Drawing.Size(89, 12);
            this.u_account_label.TabIndex = 12;
            this.u_account_label.Text = "公司银行账户：";
            // 
            // u_addr_textbox
            // 
            this.u_addr_textbox.Enabled = false;
            this.u_addr_textbox.Location = new System.Drawing.Point(460, 51);
            this.u_addr_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_addr_textbox.Name = "u_addr_textbox";
            this.u_addr_textbox.Size = new System.Drawing.Size(248, 21);
            this.u_addr_textbox.TabIndex = 11;
            // 
            // u_telperson_textbox
            // 
            this.u_telperson_textbox.Enabled = false;
            this.u_telperson_textbox.Location = new System.Drawing.Point(471, 17);
            this.u_telperson_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_telperson_textbox.Name = "u_telperson_textbox";
            this.u_telperson_textbox.Size = new System.Drawing.Size(79, 21);
            this.u_telperson_textbox.TabIndex = 10;
            // 
            // u_tex_textbox
            // 
            this.u_tex_textbox.Enabled = false;
            this.u_tex_textbox.Location = new System.Drawing.Point(262, 51);
            this.u_tex_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_tex_textbox.Name = "u_tex_textbox";
            this.u_tex_textbox.Size = new System.Drawing.Size(135, 21);
            this.u_tex_textbox.TabIndex = 9;
            // 
            // u_tel_textbox
            // 
            this.u_tel_textbox.Enabled = false;
            this.u_tel_textbox.Location = new System.Drawing.Point(262, 17);
            this.u_tel_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_tel_textbox.Name = "u_tel_textbox";
            this.u_tel_textbox.Size = new System.Drawing.Size(135, 21);
            this.u_tel_textbox.TabIndex = 8;
            // 
            // u_name_textbox
            // 
            this.u_name_textbox.Enabled = false;
            this.u_name_textbox.Location = new System.Drawing.Point(87, 51);
            this.u_name_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_name_textbox.Name = "u_name_textbox";
            this.u_name_textbox.Size = new System.Drawing.Size(111, 21);
            this.u_name_textbox.TabIndex = 7;
            // 
            // u_id_textbox
            // 
            this.u_id_textbox.Enabled = false;
            this.u_id_textbox.Location = new System.Drawing.Point(87, 17);
            this.u_id_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_id_textbox.Name = "u_id_textbox";
            this.u_id_textbox.Size = new System.Drawing.Size(111, 21);
            this.u_id_textbox.TabIndex = 6;
            // 
            // u_addr_label
            // 
            this.u_addr_label.AutoSize = true;
            this.u_addr_label.Location = new System.Drawing.Point(400, 53);
            this.u_addr_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.u_addr_label.Name = "u_addr_label";
            this.u_addr_label.Size = new System.Drawing.Size(65, 12);
            this.u_addr_label.TabIndex = 5;
            this.u_addr_label.Text = "公司地址：";
            // 
            // u_telperson_label
            // 
            this.u_telperson_label.AutoSize = true;
            this.u_telperson_label.Location = new System.Drawing.Point(400, 20);
            this.u_telperson_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.u_telperson_label.Name = "u_telperson_label";
            this.u_telperson_label.Size = new System.Drawing.Size(77, 12);
            this.u_telperson_label.TabIndex = 4;
            this.u_telperson_label.Text = "公司联系人：";
            // 
            // u_tex_label
            // 
            this.u_tex_label.AutoSize = true;
            this.u_tex_label.Location = new System.Drawing.Point(200, 53);
            this.u_tex_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.u_tex_label.Name = "u_tex_label";
            this.u_tex_label.Size = new System.Drawing.Size(65, 12);
            this.u_tex_label.TabIndex = 3;
            this.u_tex_label.Text = "公司税号：";
            // 
            // e_tel_label
            // 
            this.e_tel_label.AutoSize = true;
            this.e_tel_label.Location = new System.Drawing.Point(200, 20);
            this.e_tel_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_tel_label.Name = "e_tel_label";
            this.e_tel_label.Size = new System.Drawing.Size(65, 12);
            this.e_tel_label.TabIndex = 2;
            this.e_tel_label.Text = "联系电话：";
            // 
            // m_name_label
            // 
            this.m_name_label.AutoSize = true;
            this.m_name_label.Location = new System.Drawing.Point(20, 53);
            this.m_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_name_label.Name = "m_name_label";
            this.m_name_label.Size = new System.Drawing.Size(65, 12);
            this.m_name_label.TabIndex = 1;
            this.m_name_label.Text = "公司名称：";
            // 
            // u_id_label
            // 
            this.u_id_label.AutoSize = true;
            this.u_id_label.Location = new System.Drawing.Point(20, 20);
            this.u_id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.u_id_label.Name = "u_id_label";
            this.u_id_label.Size = new System.Drawing.Size(59, 12);
            this.u_id_label.TabIndex = 0;
            this.u_id_label.Text = "公司编号:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.u_id,
            this.u_name,
            this.u_tel,
            this.u_tex,
            this.u_telperson,
            this.u_account,
            this.u_addr});
            this.dataGridView1.Location = new System.Drawing.Point(8, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(720, 313);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // u_id
            // 
            this.u_id.HeaderText = "公司编号";
            this.u_id.MinimumWidth = 8;
            this.u_id.Name = "u_id";
            this.u_id.ReadOnly = true;
            this.u_id.Width = 150;
            // 
            // u_name
            // 
            this.u_name.HeaderText = "公司名称";
            this.u_name.MinimumWidth = 8;
            this.u_name.Name = "u_name";
            this.u_name.ReadOnly = true;
            this.u_name.Width = 150;
            // 
            // u_tel
            // 
            this.u_tel.HeaderText = "联系电话";
            this.u_tel.MinimumWidth = 8;
            this.u_tel.Name = "u_tel";
            this.u_tel.ReadOnly = true;
            this.u_tel.Width = 150;
            // 
            // u_tex
            // 
            this.u_tex.HeaderText = "公司税号";
            this.u_tex.MinimumWidth = 8;
            this.u_tex.Name = "u_tex";
            this.u_tex.ReadOnly = true;
            this.u_tex.Width = 150;
            // 
            // u_telperson
            // 
            this.u_telperson.HeaderText = "公司联系人";
            this.u_telperson.MinimumWidth = 8;
            this.u_telperson.Name = "u_telperson";
            this.u_telperson.ReadOnly = true;
            this.u_telperson.Width = 150;
            // 
            // u_account
            // 
            this.u_account.HeaderText = "公司银行账户";
            this.u_account.MinimumWidth = 8;
            this.u_account.Name = "u_account";
            this.u_account.ReadOnly = true;
            this.u_account.Width = 150;
            // 
            // u_addr
            // 
            this.u_addr.HeaderText = "公司地址";
            this.u_addr.MinimumWidth = 8;
            this.u_addr.Name = "u_addr";
            this.u_addr.ReadOnly = true;
            this.u_addr.Width = 150;
            // 
            // Basic_Info_Unit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 443);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Basic_Info_Unit_Form";
            this.Text = "往来单位——基础信息";
            this.Load += new System.EventHandler(this.Basic_Info_Unit_Form_Load);
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
        private System.Windows.Forms.TextBox u_account_textbox;
        private System.Windows.Forms.Label u_account_label;
        private System.Windows.Forms.TextBox u_addr_textbox;
        private System.Windows.Forms.TextBox u_telperson_textbox;
        private System.Windows.Forms.TextBox u_tex_textbox;
        private System.Windows.Forms.TextBox u_tel_textbox;
        private System.Windows.Forms.TextBox u_name_textbox;
        private System.Windows.Forms.TextBox u_id_textbox;
        private System.Windows.Forms.Label u_addr_label;
        private System.Windows.Forms.Label u_telperson_label;
        private System.Windows.Forms.Label u_tex_label;
        private System.Windows.Forms.Label e_tel_label;
        private System.Windows.Forms.Label m_name_label;
        private System.Windows.Forms.Label u_id_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_tex;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_telperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_account;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_addr;
    }
}