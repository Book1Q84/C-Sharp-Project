namespace CompanyManageSystem
{
    partial class Basic_Info_Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basic_Info_Product_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.确定YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_price_textbox = new System.Windows.Forms.TextBox();
            this.m_price_label = new System.Windows.Forms.Label();
            this.m_addr_textbox = new System.Windows.Forms.TextBox();
            this.m_count_textbox = new System.Windows.Forms.TextBox();
            this.m_dp_textbox = new System.Windows.Forms.TextBox();
            this.m_type_textbox = new System.Windows.Forms.TextBox();
            this.m_name_textbox = new System.Windows.Forms.TextBox();
            this.m_id_textbox = new System.Windows.Forms.TextBox();
            this.m_addr_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_dp_label = new System.Windows.Forms.Label();
            this.m_type_label = new System.Windows.Forms.Label();
            this.m_name_label = new System.Windows.Forms.Label();
            this.m_id_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.m_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_dp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip1.Size = new System.Drawing.Size(742, 30);
            this.menuStrip1.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.m_price_textbox);
            this.groupBox1.Controls.Add(this.m_price_label);
            this.groupBox1.Controls.Add(this.m_addr_textbox);
            this.groupBox1.Controls.Add(this.m_count_textbox);
            this.groupBox1.Controls.Add(this.m_dp_textbox);
            this.groupBox1.Controls.Add(this.m_type_textbox);
            this.groupBox1.Controls.Add(this.m_name_textbox);
            this.groupBox1.Controls.Add(this.m_id_textbox);
            this.groupBox1.Controls.Add(this.m_addr_label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m_dp_label);
            this.groupBox1.Controls.Add(this.m_type_label);
            this.groupBox1.Controls.Add(this.m_name_label);
            this.groupBox1.Controls.Add(this.m_id_label);
            this.groupBox1.Location = new System.Drawing.Point(9, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(720, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库存商品——基本信息";
            // 
            // m_price_textbox
            // 
            this.m_price_textbox.Enabled = false;
            this.m_price_textbox.Location = new System.Drawing.Point(629, 17);
            this.m_price_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_price_textbox.Name = "m_price_textbox";
            this.m_price_textbox.Size = new System.Drawing.Size(79, 21);
            this.m_price_textbox.TabIndex = 13;
            // 
            // m_price_label
            // 
            this.m_price_label.AutoSize = true;
            this.m_price_label.Location = new System.Drawing.Point(569, 20);
            this.m_price_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_price_label.Name = "m_price_label";
            this.m_price_label.Size = new System.Drawing.Size(65, 12);
            this.m_price_label.TabIndex = 12;
            this.m_price_label.Text = "商品单价：";
            // 
            // m_addr_textbox
            // 
            this.m_addr_textbox.Enabled = false;
            this.m_addr_textbox.Location = new System.Drawing.Point(460, 51);
            this.m_addr_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_addr_textbox.Name = "m_addr_textbox";
            this.m_addr_textbox.Size = new System.Drawing.Size(248, 21);
            this.m_addr_textbox.TabIndex = 11;
            // 
            // m_count_textbox
            // 
            this.m_count_textbox.Enabled = false;
            this.m_count_textbox.Location = new System.Drawing.Point(460, 17);
            this.m_count_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_count_textbox.Name = "m_count_textbox";
            this.m_count_textbox.Size = new System.Drawing.Size(79, 21);
            this.m_count_textbox.TabIndex = 10;
            // 
            // m_dp_textbox
            // 
            this.m_dp_textbox.Enabled = false;
            this.m_dp_textbox.Location = new System.Drawing.Point(262, 51);
            this.m_dp_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_dp_textbox.Name = "m_dp_textbox";
            this.m_dp_textbox.Size = new System.Drawing.Size(135, 21);
            this.m_dp_textbox.TabIndex = 9;
            // 
            // m_type_textbox
            // 
            this.m_type_textbox.Enabled = false;
            this.m_type_textbox.Location = new System.Drawing.Point(262, 17);
            this.m_type_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_type_textbox.Name = "m_type_textbox";
            this.m_type_textbox.Size = new System.Drawing.Size(135, 21);
            this.m_type_textbox.TabIndex = 8;
            // 
            // m_name_textbox
            // 
            this.m_name_textbox.Enabled = false;
            this.m_name_textbox.Location = new System.Drawing.Point(87, 51);
            this.m_name_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_name_textbox.Name = "m_name_textbox";
            this.m_name_textbox.Size = new System.Drawing.Size(111, 21);
            this.m_name_textbox.TabIndex = 7;
            // 
            // m_id_textbox
            // 
            this.m_id_textbox.Enabled = false;
            this.m_id_textbox.Location = new System.Drawing.Point(87, 17);
            this.m_id_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_id_textbox.Name = "m_id_textbox";
            this.m_id_textbox.Size = new System.Drawing.Size(111, 21);
            this.m_id_textbox.TabIndex = 6;
            // 
            // m_addr_label
            // 
            this.m_addr_label.AutoSize = true;
            this.m_addr_label.Location = new System.Drawing.Point(400, 53);
            this.m_addr_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_addr_label.Name = "m_addr_label";
            this.m_addr_label.Size = new System.Drawing.Size(65, 12);
            this.m_addr_label.TabIndex = 5;
            this.m_addr_label.Text = "商品产地：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "商品数量：";
            // 
            // m_dp_label
            // 
            this.m_dp_label.AutoSize = true;
            this.m_dp_label.Location = new System.Drawing.Point(200, 53);
            this.m_dp_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_dp_label.Name = "m_dp_label";
            this.m_dp_label.Size = new System.Drawing.Size(65, 12);
            this.m_dp_label.TabIndex = 3;
            this.m_dp_label.Text = "商品规格：";
            // 
            // m_type_label
            // 
            this.m_type_label.AutoSize = true;
            this.m_type_label.Location = new System.Drawing.Point(200, 20);
            this.m_type_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_type_label.Name = "m_type_label";
            this.m_type_label.Size = new System.Drawing.Size(65, 12);
            this.m_type_label.TabIndex = 2;
            this.m_type_label.Text = "商品型号：";
            // 
            // m_name_label
            // 
            this.m_name_label.AutoSize = true;
            this.m_name_label.Location = new System.Drawing.Point(20, 53);
            this.m_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_name_label.Name = "m_name_label";
            this.m_name_label.Size = new System.Drawing.Size(65, 12);
            this.m_name_label.TabIndex = 1;
            this.m_name_label.Text = "商品名称：";
            // 
            // m_id_label
            // 
            this.m_id_label.AutoSize = true;
            this.m_id_label.Location = new System.Drawing.Point(20, 20);
            this.m_id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_id_label.Name = "m_id_label";
            this.m_id_label.Size = new System.Drawing.Size(59, 12);
            this.m_id_label.TabIndex = 0;
            this.m_id_label.Text = "商品编号:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_id,
            this.m_name,
            this.m_type,
            this.m_dp,
            this.m_addr,
            this.m_count,
            this.m_price});
            this.dataGridView1.Location = new System.Drawing.Point(9, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(720, 295);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // m_id
            // 
            this.m_id.HeaderText = "商品编号";
            this.m_id.MinimumWidth = 8;
            this.m_id.Name = "m_id";
            this.m_id.ReadOnly = true;
            this.m_id.Width = 150;
            // 
            // m_name
            // 
            this.m_name.HeaderText = "商品名称";
            this.m_name.MinimumWidth = 8;
            this.m_name.Name = "m_name";
            this.m_name.ReadOnly = true;
            this.m_name.Width = 150;
            // 
            // m_type
            // 
            this.m_type.HeaderText = "商品型号";
            this.m_type.MinimumWidth = 8;
            this.m_type.Name = "m_type";
            this.m_type.ReadOnly = true;
            this.m_type.Width = 150;
            // 
            // m_dp
            // 
            this.m_dp.HeaderText = "商品单位";
            this.m_dp.MinimumWidth = 8;
            this.m_dp.Name = "m_dp";
            this.m_dp.ReadOnly = true;
            this.m_dp.Width = 150;
            // 
            // m_addr
            // 
            this.m_addr.HeaderText = "商品产地";
            this.m_addr.MinimumWidth = 8;
            this.m_addr.Name = "m_addr";
            this.m_addr.ReadOnly = true;
            this.m_addr.Width = 150;
            // 
            // m_count
            // 
            this.m_count.HeaderText = "商品数量";
            this.m_count.MinimumWidth = 8;
            this.m_count.Name = "m_count";
            this.m_count.ReadOnly = true;
            this.m_count.Width = 150;
            // 
            // m_price
            // 
            this.m_price.HeaderText = "商品价格";
            this.m_price.MinimumWidth = 8;
            this.m_price.Name = "m_price";
            this.m_price.ReadOnly = true;
            this.m_price.Width = 150;
            // 
            // Basic_Info_Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Basic_Info_Product_Form";
            this.Text = "库存商品——基本信息";
            this.Load += new System.EventHandler(this.Basic_Info_Product_Form_Load);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_price_textbox;
        private System.Windows.Forms.Label m_price_label;
        private System.Windows.Forms.TextBox m_addr_textbox;
        private System.Windows.Forms.TextBox m_count_textbox;
        private System.Windows.Forms.TextBox m_dp_textbox;
        private System.Windows.Forms.TextBox m_type_textbox;
        private System.Windows.Forms.TextBox m_name_textbox;
        private System.Windows.Forms.TextBox m_id_textbox;
        private System.Windows.Forms.Label m_addr_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label m_dp_label;
        private System.Windows.Forms.Label m_type_label;
        private System.Windows.Forms.Label m_name_label;
        private System.Windows.Forms.Label m_id_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_dp;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_price;
        private System.Windows.Forms.ToolStripMenuItem 确定YToolStripMenuItem;
    }
}