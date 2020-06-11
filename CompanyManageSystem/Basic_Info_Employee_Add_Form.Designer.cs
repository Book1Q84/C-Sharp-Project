namespace CompanyManageSystem
{
    partial class Basic_Info_Employee_Add_Form
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.yes_button = new System.Windows.Forms.Button();
            this.e_tel_textbox = new System.Windows.Forms.TextBox();
            this.e_note_textbox = new System.Windows.Forms.TextBox();
            this.e_dp_textbox = new System.Windows.Forms.TextBox();
            this.e_name_textbox = new System.Windows.Forms.TextBox();
            this.e_id_textbox = new System.Windows.Forms.TextBox();
            this.m_addr_label = new System.Windows.Forms.Label();
            this.e_note_label = new System.Windows.Forms.Label();
            this.e_dp_label = new System.Windows.Forms.Label();
            this.e_sex_label = new System.Windows.Forms.Label();
            this.e_name_label = new System.Windows.Forms.Label();
            this.e_id_label = new System.Windows.Forms.Label();
            this.e_sex_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(154, 259);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(63, 26);
            this.cancel_button.TabIndex = 45;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // yes_button
            // 
            this.yes_button.Location = new System.Drawing.Point(19, 259);
            this.yes_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(63, 26);
            this.yes_button.TabIndex = 44;
            this.yes_button.Text = "确定";
            this.yes_button.UseVisualStyleBackColor = true;
            this.yes_button.Click += new System.EventHandler(this.yes_button_Click);
            // 
            // e_tel_textbox
            // 
            this.e_tel_textbox.Location = new System.Drawing.Point(83, 155);
            this.e_tel_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_tel_textbox.Name = "e_tel_textbox";
            this.e_tel_textbox.Size = new System.Drawing.Size(135, 21);
            this.e_tel_textbox.TabIndex = 41;
            // 
            // e_note_textbox
            // 
            this.e_note_textbox.Location = new System.Drawing.Point(19, 207);
            this.e_note_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_note_textbox.Multiline = true;
            this.e_note_textbox.Name = "e_note_textbox";
            this.e_note_textbox.Size = new System.Drawing.Size(200, 49);
            this.e_note_textbox.TabIndex = 40;
            // 
            // e_dp_textbox
            // 
            this.e_dp_textbox.Location = new System.Drawing.Point(83, 121);
            this.e_dp_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_dp_textbox.Name = "e_dp_textbox";
            this.e_dp_textbox.Size = new System.Drawing.Size(135, 21);
            this.e_dp_textbox.TabIndex = 39;
            // 
            // e_name_textbox
            // 
            this.e_name_textbox.Location = new System.Drawing.Point(83, 51);
            this.e_name_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_name_textbox.Name = "e_name_textbox";
            this.e_name_textbox.Size = new System.Drawing.Size(135, 21);
            this.e_name_textbox.TabIndex = 37;
            // 
            // e_id_textbox
            // 
            this.e_id_textbox.Location = new System.Drawing.Point(83, 15);
            this.e_id_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_id_textbox.Name = "e_id_textbox";
            this.e_id_textbox.Size = new System.Drawing.Size(135, 21);
            this.e_id_textbox.TabIndex = 36;
            // 
            // m_addr_label
            // 
            this.m_addr_label.AutoSize = true;
            this.m_addr_label.Location = new System.Drawing.Point(17, 160);
            this.m_addr_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_addr_label.Name = "m_addr_label";
            this.m_addr_label.Size = new System.Drawing.Size(65, 12);
            this.m_addr_label.TabIndex = 35;
            this.m_addr_label.Text = "员工电话：";
            // 
            // e_note_label
            // 
            this.e_note_label.AutoSize = true;
            this.e_note_label.Location = new System.Drawing.Point(17, 193);
            this.e_note_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_note_label.Name = "e_note_label";
            this.e_note_label.Size = new System.Drawing.Size(65, 12);
            this.e_note_label.TabIndex = 34;
            this.e_note_label.Text = "员工备注：";
            // 
            // e_dp_label
            // 
            this.e_dp_label.AutoSize = true;
            this.e_dp_label.Location = new System.Drawing.Point(17, 123);
            this.e_dp_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_dp_label.Name = "e_dp_label";
            this.e_dp_label.Size = new System.Drawing.Size(65, 12);
            this.e_dp_label.TabIndex = 33;
            this.e_dp_label.Text = "员工部门：";
            // 
            // e_sex_label
            // 
            this.e_sex_label.AutoSize = true;
            this.e_sex_label.Location = new System.Drawing.Point(17, 90);
            this.e_sex_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_sex_label.Name = "e_sex_label";
            this.e_sex_label.Size = new System.Drawing.Size(65, 12);
            this.e_sex_label.TabIndex = 32;
            this.e_sex_label.Text = "员工性别：";
            // 
            // e_name_label
            // 
            this.e_name_label.AutoSize = true;
            this.e_name_label.Location = new System.Drawing.Point(17, 51);
            this.e_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_name_label.Name = "e_name_label";
            this.e_name_label.Size = new System.Drawing.Size(65, 12);
            this.e_name_label.TabIndex = 31;
            this.e_name_label.Text = "员工姓名：";
            // 
            // e_id_label
            // 
            this.e_id_label.AutoSize = true;
            this.e_id_label.Location = new System.Drawing.Point(17, 17);
            this.e_id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_id_label.Name = "e_id_label";
            this.e_id_label.Size = new System.Drawing.Size(65, 12);
            this.e_id_label.TabIndex = 30;
            this.e_id_label.Text = "员工编号：";
            // 
            // e_sex_comboBox
            // 
            this.e_sex_comboBox.FormattingEnabled = true;
            this.e_sex_comboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.e_sex_comboBox.Location = new System.Drawing.Point(86, 88);
            this.e_sex_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_sex_comboBox.Name = "e_sex_comboBox";
            this.e_sex_comboBox.Size = new System.Drawing.Size(133, 20);
            this.e_sex_comboBox.TabIndex = 46;
            // 
            // Basic_Info_Employee_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 300);
            this.Controls.Add(this.e_sex_comboBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.yes_button);
            this.Controls.Add(this.e_tel_textbox);
            this.Controls.Add(this.e_note_textbox);
            this.Controls.Add(this.e_dp_textbox);
            this.Controls.Add(this.e_name_textbox);
            this.Controls.Add(this.e_id_textbox);
            this.Controls.Add(this.m_addr_label);
            this.Controls.Add(this.e_note_label);
            this.Controls.Add(this.e_dp_label);
            this.Controls.Add(this.e_sex_label);
            this.Controls.Add(this.e_name_label);
            this.Controls.Add(this.e_id_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Basic_Info_Employee_Add_Form";
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.Basic_Info_Employee_Add_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.TextBox e_tel_textbox;
        private System.Windows.Forms.TextBox e_note_textbox;
        private System.Windows.Forms.TextBox e_dp_textbox;
        private System.Windows.Forms.TextBox e_name_textbox;
        private System.Windows.Forms.TextBox e_id_textbox;
        private System.Windows.Forms.Label m_addr_label;
        private System.Windows.Forms.Label e_note_label;
        private System.Windows.Forms.Label e_dp_label;
        private System.Windows.Forms.Label e_sex_label;
        private System.Windows.Forms.Label e_name_label;
        private System.Windows.Forms.Label e_id_label;
        private System.Windows.Forms.ComboBox e_sex_comboBox;
    }
}