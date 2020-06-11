using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CompanyManageSystem
{
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string  text1= "";


        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox1.BackColor);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String AuthorMessage = "作者：\n陈凯\n陈兴利\n李旺钊\n王爱波";
            MessageBox.Show(AuthorMessage);
        }
        

        private void Login_button_Click(object sender, EventArgs e)
        {
            
            /*登录界面登录按钮相关代码*/
            if (Login_account.Text == "login" && Login_password.Text == "password")
            {
                if (login_code.Text == text1)
                {
                    if (checkBox2.Checked == true)
                    { File.WriteAllText("C:/Users/lwz/Desktop/user.txt", Login_account.Text+","+Login_password.Text); }
                    if (checkBox2.Checked == false)
                    { File.Delete("C:/Users/lwz/Desktop/user.txt"); }
                    /*登录后隐藏登录界面，主界面显示*/
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else if (login_code.Text == "")
                { MessageBox.Show("验证码不能为空！", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
                else
                { MessageBox.Show("验证码输入错误！", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
            }
            else if(Login_password.Text == "" && Login_account.Text == "")
            { MessageBox.Show("密码账户不能为空！", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
            else 
            { MessageBox.Show("账号密码错误！", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:/Users/lwz/Desktop/user.txt"))
            {
                StreamReader rd = File.OpenText("C:/Users/lwz/Desktop/user.txt");
                string s=rd.ReadLine();
                string[]ss=s.Split(',');
                if (ss.Length == 2)
                {
                    Login_account.Text = ss[0];
                    Login_password.Text = ss[1];
                    checkBox2.Checked =true;
                }
                if (ss.Length == 1)
                {
                    Login_account.Text = ss[0];
                    checkBox2.Checked = true;
                }
                rd.Close();
            }
            var random = new Random((int)DateTime.Now.Ticks);
            const string textArray = "0123456789ABCDEFGHJKLMNOPQRSTUVWXYZ";
            for (var i = 0; i < 6; i++)
            {
                text1 = text1 + textArray.Substring(random.Next() % textArray.Length, 1);
            }
            code.Text = text1;

        }

        private void Login_account_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { Login_password.PasswordChar = new char(); }
            if (checkBox1.Checked==false)
            { Login_password.PasswordChar = '*'; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
