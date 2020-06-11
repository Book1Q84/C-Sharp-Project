namespace CompanyManageSystem
{
    partial class kucun
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.上下限设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择查询日期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择排行榜条件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.确定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上下限设置ToolStripMenuItem,
            this.选择查询日期ToolStripMenuItem,
            this.选择排行榜条件ToolStripMenuItem,
            this.确定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 上下限设置ToolStripMenuItem
            // 
            this.上下限设置ToolStripMenuItem.Name = "上下限设置ToolStripMenuItem";
            this.上下限设置ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.上下限设置ToolStripMenuItem.Text = "上下限报警设置";
            this.上下限设置ToolStripMenuItem.Click += new System.EventHandler(this.上下限设置ToolStripMenuItem_Click);
            // 
            // 选择查询日期ToolStripMenuItem
            // 
            this.选择查询日期ToolStripMenuItem.Name = "选择查询日期ToolStripMenuItem";
            this.选择查询日期ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.选择查询日期ToolStripMenuItem.Text = "选择查询日期";
            this.选择查询日期ToolStripMenuItem.Click += new System.EventHandler(this.选择查询日期ToolStripMenuItem_Click);
            // 
            // 选择排行榜条件ToolStripMenuItem
            // 
            this.选择排行榜条件ToolStripMenuItem.Name = "选择排行榜条件ToolStripMenuItem";
            this.选择排行榜条件ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.选择排行榜条件ToolStripMenuItem.Text = "选择排行榜条件";
            this.选择排行榜条件ToolStripMenuItem.Click += new System.EventHandler(this.选择排行榜条件ToolStripMenuItem_Click);
            // 
            // 确定ToolStripMenuItem
            // 
            this.确定ToolStripMenuItem.Name = "确定ToolStripMenuItem";
            this.确定ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.确定ToolStripMenuItem.Text = "确定";
            this.确定ToolStripMenuItem.Click += new System.EventHandler(this.确定ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(554, 328);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kucun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 358);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "kucun";
            this.Text = "库存管理";
            this.Load += new System.EventHandler(this.kucun_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 上下限设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择查询日期ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择排行榜条件ToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 确定ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

