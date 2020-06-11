namespace CompanyManageSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.进货管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进货退货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进货分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进货统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售退货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.往来单位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公司职员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本单位信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统数据备份恢复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统数据清理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.辅助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录InternetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动WordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prodouct_count_label = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.employee_count_label = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sales_this_mouth_label = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.M_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进货管理ToolStripMenuItem,
            this.销售管理ToolStripMenuItem,
            this.库存管理ToolStripMenuItem,
            this.基础数据ToolStripMenuItem,
            this.系统维护ToolStripMenuItem,
            this.辅助ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 进货管理ToolStripMenuItem
            // 
            this.进货管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进货单ToolStripMenuItem,
            this.进货退货单ToolStripMenuItem,
            this.进货分析ToolStripMenuItem,
            this.进货统计ToolStripMenuItem});
            this.进货管理ToolStripMenuItem.Name = "进货管理ToolStripMenuItem";
            resources.ApplyResources(this.进货管理ToolStripMenuItem, "进货管理ToolStripMenuItem");
            this.进货管理ToolStripMenuItem.Click += new System.EventHandler(this.进货管理ToolStripMenuItem_Click);
            // 
            // 进货单ToolStripMenuItem
            // 
            this.进货单ToolStripMenuItem.Name = "进货单ToolStripMenuItem";
            resources.ApplyResources(this.进货单ToolStripMenuItem, "进货单ToolStripMenuItem");
            this.进货单ToolStripMenuItem.Click += new System.EventHandler(this.进货单ToolStripMenuItem_Click);
            // 
            // 进货退货单ToolStripMenuItem
            // 
            this.进货退货单ToolStripMenuItem.Name = "进货退货单ToolStripMenuItem";
            resources.ApplyResources(this.进货退货单ToolStripMenuItem, "进货退货单ToolStripMenuItem");
            this.进货退货单ToolStripMenuItem.Click += new System.EventHandler(this.进货退货单ToolStripMenuItem_Click);
            // 
            // 进货分析ToolStripMenuItem
            // 
            this.进货分析ToolStripMenuItem.Name = "进货分析ToolStripMenuItem";
            resources.ApplyResources(this.进货分析ToolStripMenuItem, "进货分析ToolStripMenuItem");
            this.进货分析ToolStripMenuItem.Click += new System.EventHandler(this.进货分析ToolStripMenuItem_Click);
            // 
            // 进货统计ToolStripMenuItem
            // 
            this.进货统计ToolStripMenuItem.Name = "进货统计ToolStripMenuItem";
            resources.ApplyResources(this.进货统计ToolStripMenuItem, "进货统计ToolStripMenuItem");
            this.进货统计ToolStripMenuItem.Click += new System.EventHandler(this.进货统计ToolStripMenuItem_Click);
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售单ToolStripMenuItem,
            this.销售退货单ToolStripMenuItem,
            this.销售分析ToolStripMenuItem,
            this.销售统计ToolStripMenuItem});
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            resources.ApplyResources(this.销售管理ToolStripMenuItem, "销售管理ToolStripMenuItem");
            this.销售管理ToolStripMenuItem.Click += new System.EventHandler(this.销售管理ToolStripMenuItem_Click);
            // 
            // 销售单ToolStripMenuItem
            // 
            this.销售单ToolStripMenuItem.Name = "销售单ToolStripMenuItem";
            resources.ApplyResources(this.销售单ToolStripMenuItem, "销售单ToolStripMenuItem");
            this.销售单ToolStripMenuItem.Click += new System.EventHandler(this.销售单ToolStripMenuItem_Click);
            // 
            // 销售退货单ToolStripMenuItem
            // 
            this.销售退货单ToolStripMenuItem.Name = "销售退货单ToolStripMenuItem";
            resources.ApplyResources(this.销售退货单ToolStripMenuItem, "销售退货单ToolStripMenuItem");
            this.销售退货单ToolStripMenuItem.Click += new System.EventHandler(this.销售退货单ToolStripMenuItem_Click);
            // 
            // 销售分析ToolStripMenuItem
            // 
            this.销售分析ToolStripMenuItem.Name = "销售分析ToolStripMenuItem";
            resources.ApplyResources(this.销售分析ToolStripMenuItem, "销售分析ToolStripMenuItem");
            this.销售分析ToolStripMenuItem.Click += new System.EventHandler(this.销售分析ToolStripMenuItem_Click);
            // 
            // 销售统计ToolStripMenuItem
            // 
            this.销售统计ToolStripMenuItem.Name = "销售统计ToolStripMenuItem";
            resources.ApplyResources(this.销售统计ToolStripMenuItem, "销售统计ToolStripMenuItem");
            this.销售统计ToolStripMenuItem.Click += new System.EventHandler(this.销售统计ToolStripMenuItem_Click);
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            resources.ApplyResources(this.库存管理ToolStripMenuItem, "库存管理ToolStripMenuItem");
            this.库存管理ToolStripMenuItem.Click += new System.EventHandler(this.库存管理ToolStripMenuItem_Click);
            // 
            // 基础数据ToolStripMenuItem
            // 
            this.基础数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存商品ToolStripMenuItem,
            this.往来单位ToolStripMenuItem,
            this.公司职员ToolStripMenuItem});
            this.基础数据ToolStripMenuItem.Name = "基础数据ToolStripMenuItem";
            resources.ApplyResources(this.基础数据ToolStripMenuItem, "基础数据ToolStripMenuItem");
            // 
            // 库存商品ToolStripMenuItem
            // 
            this.库存商品ToolStripMenuItem.Name = "库存商品ToolStripMenuItem";
            resources.ApplyResources(this.库存商品ToolStripMenuItem, "库存商品ToolStripMenuItem");
            this.库存商品ToolStripMenuItem.Click += new System.EventHandler(this.库存商品ToolStripMenuItem_Click);
            // 
            // 往来单位ToolStripMenuItem
            // 
            this.往来单位ToolStripMenuItem.Name = "往来单位ToolStripMenuItem";
            resources.ApplyResources(this.往来单位ToolStripMenuItem, "往来单位ToolStripMenuItem");
            this.往来单位ToolStripMenuItem.Click += new System.EventHandler(this.往来单位ToolStripMenuItem_Click);
            // 
            // 公司职员ToolStripMenuItem
            // 
            this.公司职员ToolStripMenuItem.Name = "公司职员ToolStripMenuItem";
            resources.ApplyResources(this.公司职员ToolStripMenuItem, "公司职员ToolStripMenuItem");
            this.公司职员ToolStripMenuItem.Click += new System.EventHandler(this.公司职员ToolStripMenuItem_Click);
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.本单位信息ToolStripMenuItem,
            this.系统管理设置ToolStripMenuItem,
            this.系统数据备份恢复ToolStripMenuItem,
            this.系统数据清理ToolStripMenuItem});
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            resources.ApplyResources(this.系统维护ToolStripMenuItem, "系统维护ToolStripMenuItem");
            this.系统维护ToolStripMenuItem.Click += new System.EventHandler(this.系统维护ToolStripMenuItem_Click);
            // 
            // 本单位信息ToolStripMenuItem
            // 
            this.本单位信息ToolStripMenuItem.Name = "本单位信息ToolStripMenuItem";
            resources.ApplyResources(this.本单位信息ToolStripMenuItem, "本单位信息ToolStripMenuItem");
            // 
            // 系统管理设置ToolStripMenuItem
            // 
            this.系统管理设置ToolStripMenuItem.Name = "系统管理设置ToolStripMenuItem";
            resources.ApplyResources(this.系统管理设置ToolStripMenuItem, "系统管理设置ToolStripMenuItem");
            // 
            // 系统数据备份恢复ToolStripMenuItem
            // 
            this.系统数据备份恢复ToolStripMenuItem.Name = "系统数据备份恢复ToolStripMenuItem";
            resources.ApplyResources(this.系统数据备份恢复ToolStripMenuItem, "系统数据备份恢复ToolStripMenuItem");
            // 
            // 系统数据清理ToolStripMenuItem
            // 
            this.系统数据清理ToolStripMenuItem.Name = "系统数据清理ToolStripMenuItem";
            resources.ApplyResources(this.系统数据清理ToolStripMenuItem, "系统数据清理ToolStripMenuItem");
            // 
            // 辅助ToolStripMenuItem
            // 
            this.辅助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录InternetToolStripMenuItem,
            this.启动WordToolStripMenuItem,
            this.启动ExcelToolStripMenuItem,
            this.启动计算器ToolStripMenuItem});
            this.辅助ToolStripMenuItem.Name = "辅助ToolStripMenuItem";
            resources.ApplyResources(this.辅助ToolStripMenuItem, "辅助ToolStripMenuItem");
            this.辅助ToolStripMenuItem.Click += new System.EventHandler(this.辅助ToolStripMenuItem_Click);
            // 
            // 登录InternetToolStripMenuItem
            // 
            this.登录InternetToolStripMenuItem.Name = "登录InternetToolStripMenuItem";
            resources.ApplyResources(this.登录InternetToolStripMenuItem, "登录InternetToolStripMenuItem");
            this.登录InternetToolStripMenuItem.Click += new System.EventHandler(this.登录InternetToolStripMenuItem_Click);
            // 
            // 启动WordToolStripMenuItem
            // 
            this.启动WordToolStripMenuItem.Name = "启动WordToolStripMenuItem";
            resources.ApplyResources(this.启动WordToolStripMenuItem, "启动WordToolStripMenuItem");
            this.启动WordToolStripMenuItem.Click += new System.EventHandler(this.启动WordToolStripMenuItem_Click);
            // 
            // 启动ExcelToolStripMenuItem
            // 
            this.启动ExcelToolStripMenuItem.Name = "启动ExcelToolStripMenuItem";
            resources.ApplyResources(this.启动ExcelToolStripMenuItem, "启动ExcelToolStripMenuItem");
            this.启动ExcelToolStripMenuItem.Click += new System.EventHandler(this.启动ExcelToolStripMenuItem_Click);
            // 
            // 启动计算器ToolStripMenuItem
            // 
            this.启动计算器ToolStripMenuItem.Name = "启动计算器ToolStripMenuItem";
            resources.ApplyResources(this.启动计算器ToolStripMenuItem, "启动计算器ToolStripMenuItem");
            this.启动计算器ToolStripMenuItem.Click += new System.EventHandler(this.启动计算器ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出程序ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            resources.ApplyResources(this.退出程序ToolStripMenuItem, "退出程序ToolStripMenuItem");
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            resources.ApplyResources(this.退出登录ToolStripMenuItem, "退出登录ToolStripMenuItem");
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            resources.ApplyResources(this.关于ToolStripMenuItem, "关于ToolStripMenuItem");
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prodouct_count_label);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // prodouct_count_label
            // 
            resources.ApplyResources(this.prodouct_count_label, "prodouct_count_label");
            this.prodouct_count_label.ForeColor = System.Drawing.Color.Red;
            this.prodouct_count_label.Name = "prodouct_count_label";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.employee_count_label);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // employee_count_label
            // 
            resources.ApplyResources(this.employee_count_label, "employee_count_label");
            this.employee_count_label.ForeColor = System.Drawing.Color.Red;
            this.employee_count_label.Name = "employee_count_label";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sales_this_mouth_label);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // sales_this_mouth_label
            // 
            resources.ApplyResources(this.sales_this_mouth_label, "sales_this_mouth_label");
            this.sales_this_mouth_label.ForeColor = System.Drawing.Color.Red;
            this.sales_this_mouth_label.Name = "sales_this_mouth_label";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_id,
            this.M_name,
            this.M_count,
            this.M_price});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            // 
            // M_id
            // 
            resources.ApplyResources(this.M_id, "M_id");
            this.M_id.Name = "M_id";
            // 
            // M_name
            // 
            resources.ApplyResources(this.M_name, "M_name");
            this.M_name.Name = "M_name";
            // 
            // M_count
            // 
            resources.ApplyResources(this.M_count, "M_count");
            this.M_count.Name = "M_count";
            // 
            // M_price
            // 
            resources.ApplyResources(this.M_price, "M_price");
            this.M_price.Name = "M_price";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 进货管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基础数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 辅助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 进货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进货退货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进货分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进货统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售退货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 往来单位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公司职员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本单位信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统数据备份恢复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统数据清理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录InternetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动WordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动ExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动计算器ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label prodouct_count_label;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label employee_count_label;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label sales_this_mouth_label;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_price;
        private System.Windows.Forms.ListBox listBox1;
    }
}