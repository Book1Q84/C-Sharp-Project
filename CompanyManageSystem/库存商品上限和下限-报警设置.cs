using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManageSystem
{
    public partial class kucun_baojing : Form
    {
        public kucun_baojing()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("请输入上下限");
            }
            else if ((IsNumeric(textBox1.Text)) == false || (IsNumeric(textBox2.Text)) == false)
            {
                MessageBox.Show("请输入数字");
            }
            else if ((int.Parse(textBox1.Text.ToString()))<(int.Parse(textBox2.Text.ToString())))
            {
                MessageBox.Show("亲，上限应该比下限大哦");
            }
            else
            {
                globalData.up = int.Parse(textBox1.Text.ToString());
                globalData.low = int.Parse(textBox2.Text.ToString());
                this.Close();
            }
        }
        bool IsNumeric(string str) 
        {
            if (str == null || str.Length == 0)   
                return false;                          
            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] bytestr = ascii.GetBytes(str);         
            foreach (byte c in bytestr)                  
            {
                if (c < 48 || c > 57)                      
                {
                    return false;                            
                }
            }
            return true;                                     
        }
        private void kucun_baojing_Load(object sender, EventArgs e)
        {
            color.load();
        }
    }
}
