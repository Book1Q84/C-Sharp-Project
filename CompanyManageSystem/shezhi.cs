using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace CompanyManageSystem
{
    public partial class shezhi : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
        const uint WM_APPCOMMAND = 0x319;
        const uint APPCOMMAND_VOLUME_UP = 0x0a;
        const uint APPCOMMAND_VOLUME_DOWN = 0x09;
        const uint APPCOMMAND_VOLUME_MUTE = 0x08;
        public shezhi()
        {
            InitializeComponent();
        }

        private void shezhi_Load(object sender, EventArgs e)
        {
            color.load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_APPCOMMAND, 0x30292, APPCOMMAND_VOLUME_UP * 0x10000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_APPCOMMAND, 0x30292, APPCOMMAND_VOLUME_DOWN * 0x10000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_APPCOMMAND, 0x200eb0, APPCOMMAND_VOLUME_MUTE * 0x10000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认定时嘛", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                timer1.Enabled = true;
                MessageBox.Show("定时成功！系统关闭时间为：" + dateTimePicker1.Text, "提示");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                DialogResult dr = MessageBox.Show("确认取消嘛:" + dateTimePicker1.Text, "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("取消成功", "提示");
                }
            }
            else
            {
                MessageBox.Show("还没定时呢！", "提示");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label3.Text == dateTimePicker1.Text)
            {
                Environment.Exit(0);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "护眼")
            {
                color.clo = "护眼";
            }
            if (comboBox1.Text == "蓝色")
            {
                color.clo = "蓝色";
            }
            if (comboBox1.Text == "红色")
            {
                color.clo = "红色";
            }
            if (comboBox1.Text == "黄色")
            {
                color.clo = "黄色";
            }
            if (comboBox1.Text == "绿色")
            {
                color.clo = "绿色";
            }
            if (comboBox1.Text == "灰色")
            {
                color.clo = "灰色";
            }
            if (comboBox1.Text == "白色")
            {
                color.clo = "白色";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            color.load();
        }
    }
}
