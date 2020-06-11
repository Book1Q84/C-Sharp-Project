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
    public partial class kucun_chaxun : Form
    {
        public kucun_chaxun()
        {
            InitializeComponent();
        }

        private void kucun_chaxun_Load(object sender, EventArgs e)
        {
            color.load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globalData.sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE sale_product.sm_date BETWEEN '" + dateTimePicker1.Text + "'and'" + dateTimePicker2.Text + "'and product.m_name = sale_product.sm_name ";
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Text = this.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker2.Text = this.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
