namespace CompanyManageSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.login_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Login_password_label = new System.Windows.Forms.Label();
            this.Login_account_label = new System.Windows.Forms.Label();
            this.Login_password = new System.Windows.Forms.TextBox();
            this.Login_account = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.login_code);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Login_button);
            this.groupBox1.Controls.Add(this.Login_password_label);
            this.groupBox1.Controls.Add(this.Login_account_label);
            this.groupBox1.Controls.Add(this.Login_password);
            this.groupBox1.Controls.Add(this.Login_account);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(373, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(333, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("宋体", 9F);
            this.checkBox2.Location = new System.Drawing.Point(240, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 16);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "记住账户密码";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.checkBox1.Location = new System.Drawing.Point(240, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "显示密码";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login_code
            // 
            this.login_code.Location = new System.Drawing.Point(75, 174);
            this.login_code.Name = "login_code";
            this.login_code.Size = new System.Drawing.Size(113, 28);
            this.login_code.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "验证码：";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.code.Font = new System.Drawing.Font("宋体", 18.8F);
            this.code.ForeColor = System.Drawing.Color.Red;
            this.code.Image = ((System.Drawing.Image)(resources.GetObject("code.Image")));
            this.code.Location = new System.Drawing.Point(221, 174);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(0, 26);
            this.code.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户登录 Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_button.Location = new System.Drawing.Point(59, 255);
            this.Login_button.Margin = new System.Windows.Forms.Padding(2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(230, 32);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "登录";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Login_password_label
            // 
            this.Login_password_label.AutoSize = true;
            this.Login_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_password_label.Location = new System.Drawing.Point(4, 117);
            this.Login_password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_password_label.Name = "Login_password_label";
            this.Login_password_label.Size = new System.Drawing.Size(67, 24);
            this.Login_password_label.TabIndex = 3;
            this.Login_password_label.Text = "密码：";
            // 
            // Login_account_label
            // 
            this.Login_account_label.AutoSize = true;
            this.Login_account_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_account_label.Location = new System.Drawing.Point(4, 70);
            this.Login_account_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_account_label.Name = "Login_account_label";
            this.Login_account_label.Size = new System.Drawing.Size(67, 24);
            this.Login_account_label.TabIndex = 2;
            this.Login_account_label.Text = "账号：";
            // 
            // Login_password
            // 
            this.Login_password.Location = new System.Drawing.Point(75, 113);
            this.Login_password.Margin = new System.Windows.Forms.Padding(2);
            this.Login_password.Name = "Login_password";
            this.Login_password.PasswordChar = '*';
            this.Login_password.Size = new System.Drawing.Size(160, 28);
            this.Login_password.TabIndex = 1;
            // 
            // Login_account
            // 
            this.Login_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_account.Location = new System.Drawing.Point(75, 70);
            this.Login_account.Margin = new System.Windows.Forms.Padding(2);
            this.Login_account.Name = "Login_account";
            this.Login_account.Size = new System.Drawing.Size(160, 28);
            this.Login_account.TabIndex = 0;
            this.Login_account.TextChanged += new System.EventHandler(this.Login_account_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(736, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "企业进销存管理系统";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Login_password_label;
        private System.Windows.Forms.Label Login_account_label;
        private System.Windows.Forms.TextBox Login_password;
        private System.Windows.Forms.TextBox Login_account;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.TextBox login_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

