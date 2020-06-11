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
using System.Globalization;

namespace CompanyManageSystem
{
    public partial class saleSum : Form
    {
        MySqlConnection conn;//声明一个MySqlConnection对象
        MySqlDataAdapter adapter;//声明一个MySqlDataAdapter对象

        public saleSum()
        {
            InitializeComponent();
        }
        /*
        * 连接数据库
        */
        private void dataBaseConnection()
        {
            String connetStr = "server=127.0.0.1;port=3306;database=c#;username=root;password=123456;Charset=utf8;";
            // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
            conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("已经建立连接");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);//出现异常
            }
        }
        /*
        * 获得saleproduct表格数据
        * 
        */
        private DataTable getSaleproduct()
        {
            String sql = "select * from sale_product";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            DataSet dsa = new DataSet();
            sda.Fill(dsa);
            sda.Fill(ds);
            dataGridView1.DataSource = dsa.Tables[0];
            //MessageBox.Show(ds.Rows[0][0].ToString()+ ds.Rows[0][1].ToString()+ ds.Rows[0][2].ToString());
            return ds;
        }
        /*
         * 调用sum_count获得总销售数量
         */
        private String sum_count(DataTable saleproduct)
        {
            int count=0;
            for(int i = 0; i < saleproduct.Rows.Count; i++)
            {
                count += Convert.ToInt32(saleproduct.Rows[i][3].ToString());
            }
            return count.ToString();
        }
        /*
         * 调用sum_yingshou获得总应收金额
         */
        private String sum_yingshou(DataTable saleproduct)
        {
            double count = 0;
            for (int i = 0; i < saleproduct.Rows.Count; i++)
            {
                count += Convert.ToInt32(saleproduct.Rows[i][12].ToString());
            }
            return count.ToString();
        }
        /*
         *调用sum_shishou获得总实收金额
         */
        private String sum_shishou(DataTable saleproduct)
        {
            double count = 0;
            for (int i = 0; i < saleproduct.Rows.Count; i++)
            {
                count += Convert.ToInt32(saleproduct.Rows[i][13].ToString());
            }
            return count.ToString();
        }
        /*
         *调用sum_cha获得总差价
         */
        private String sum_cha(DataTable saleproduct)
        {
            double count = 0;
            for (int i = 0; i < saleproduct.Rows.Count; i++)
            {
                count += Convert.ToInt32(saleproduct.Rows[i][11].ToString());
            }
            return count.ToString();
        }
        private void slaeSum_Load(object sender, EventArgs e)
        {
            color.load();
            dataBaseConnection();//连接数据库
            //获取saleproduct表数据
            DataTable saleproduct = new DataTable();
            saleproduct = this.getSaleproduct();          //调用getSaleproduct方法
            //调用sum_count获得总销售数量
            textBox1.Text = sum_count(saleproduct);
            //调用sum_yingshou获得总应收金额
            textBox2.Text = sum_yingshou(saleproduct);
            //调用sum_shishou获得总实收金额
            textBox3.Text = sum_shishou(saleproduct);
            //调用sum_cha获得总差价
            textBox4.Text = sum_cha(saleproduct);
            
            //关闭数据库连接
            conn.Close();
        }
    }
}
