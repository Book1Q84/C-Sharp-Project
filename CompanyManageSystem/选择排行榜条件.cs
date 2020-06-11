using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace CompanyManageSystem
{
    public partial class kucun_tiaojian : Form
    {
        public kucun_tiaojian()
        {
            InitializeComponent();
        }
        private void kucun_tiaojian_Load(object sender, EventArgs e)
        {
            color.load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                if (comboBox1.Text != "无" && comboBox2.Text != "无")
                {
                    globalData.sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE sm_person= '" + comboBox2.Text + "'and sm_unit= '" + comboBox1.Text + "' and product.m_name = sale_product.sm_name ORDER BY sale_product.sm_prices DESC";
                    this.Close();
                }
                else if (comboBox2.Text == "无" && comboBox1.Text != "无")
                {
                    globalData.sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE sm_unit= '" + comboBox1.Text + "' and product.m_name = sale_product.sm_name ORDER BY sale_product.sm_prices DESC";
                    this.Close();
                }
                else if (comboBox1.Text == "无" && comboBox2.Text != "无")
                {
                    globalData.sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE sm_person= '" + comboBox2.Text + "' and product.m_name = sale_product.sm_name ORDER BY sale_product.sm_prices DESC";
                    this.Close();
                }
                else
                {
                    globalData.sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE product.m_name = sale_product.sm_name ORDER BY sale_product.sm_prices DESC";
                    this.Close();
                }
            }
            else if (radioButton1.Checked == true)
            {
                if (comboBox1.Text != "无" && comboBox2.Text != "无")
                {
                    globalData.sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE sm_person= '" + comboBox2.Text + "'and sm_unit= '" + comboBox1.Text + "' and product.m_name = sale_product.sm_name ORDER BY sale_product.sm_count DESC";
                    this.Close();
                }
                else if (comboBox2.Text == "无" && comboBox1.Text != "无")
                {
                    globalData.sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE sm_unit= '" + comboBox1.Text + "' and product.m_name = sale_product.sm_name ORDER BY sale_product.sm_count DESC";
                    this.Close();
                }
                else if (comboBox1.Text == "无" && comboBox2.Text != "无")
                {
                    globalData.sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE sm_person= '" + comboBox2.Text + "' and product.m_name = sale_product.sm_name ORDER BY sale_product.sm_count DESC";
                    this.Close();
                }
                else 
                {
                    globalData.sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE product.m_name = sale_product.sm_name ORDER BY sale_product.sm_count DESC";
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("错误，重选");
            }
        }
    }
}
