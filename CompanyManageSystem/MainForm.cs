using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CompanyManageSystem
{
    
    public partial class MainForm : Form
    {
        MySqlConnection conn;
        public MainForm()
        {
            String connetStr = "server=127.0.0.1;port=3306;database=c#;username=root;password=123456;Charset=utf8;";
            conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
            }
            finally
            {
                conn.Close();
            }
            InitializeComponent();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String AuthorMessage = "作者：\n陈凯\n陈兴利\n李旺钊\n王爱波";
            MessageBox.Show(AuthorMessage);
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*显示系统时间*/
            DateTime dt = new DateTime();
            dt = System.DateTime.Now;
            string strFu = dt.ToString("HH:mm:ss");
            label1.Text = strFu;

            
            int product_count = 0;
            int employee_count = 0;
            double sales_this_mouth = 0;
            List<String> employee_list = new List<string>();

            if (conn.State.Equals(System.Data.ConnectionState.Open))
            {
                /*显示库存商品数*/
                String product_query = "select count(m_id) from product;";
                /*显示在职员工数量*/
                String employee_query = "select count(e_id) from employee;";
                /*显示本月销售业绩*/
                String sales_this_mouth_query = "SELECT sum(sm_prices) FROM sale_product WHERE DATE_FORMAT(sm_date, '%Y%m' ) = DATE_FORMAT( CURDATE( ) , '%Y%m' );";
                /*显示在职人员名单*/
                String employee_list_query = "select e_name from employee";
                /*显示库存商品简览*/
                String product_brief_query = "select m_id,m_name,m_count,m_price*m_count as m_totalprice from product";

                MySqlCommand SCom1 = new MySqlCommand();//执行查询库存商品数命令
                SCom1.CommandText = product_query;
                SCom1.Connection = conn;
                SCom1.CommandType = CommandType.Text;
                product_count = Int16.Parse(SCom1.ExecuteScalar().ToString());

                MySqlCommand SCom2 = new MySqlCommand();//执行查询在职员工数量命令
                SCom2.CommandText = employee_query;
                SCom2.Connection = conn;
                SCom2.CommandType = CommandType.Text;
                employee_count = Int16.Parse(SCom2.ExecuteScalar().ToString());

                MySqlCommand SCom3 = new MySqlCommand();//执行查询本月销售业绩
                SCom3.CommandText = sales_this_mouth_query;
                SCom3.Connection = conn;
                SCom3.CommandType = CommandType.Text;
                sales_this_mouth = double.Parse(SCom3.ExecuteScalar().ToString());


                MySqlCommand SCom4 = new MySqlCommand();//查询在职人员名单
                SCom4.CommandText = employee_list_query;
                SCom4.Connection = conn;
                SCom4.CommandType = CommandType.Text;
                MySqlDataReader reader1 = SCom4.ExecuteReader();
                while (reader1.Read())
                {
                    employee_list.Add(reader1.GetString("e_name"));
                }
                reader1.Close();

                MySqlCommand SCom5 = new MySqlCommand();//查询库存商品简览
                SCom5.CommandText = product_brief_query;
                SCom5.Connection = conn;
                SCom5.CommandType = CommandType.Text;
                MySqlDataReader reader2 = SCom5.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader2.Read())
                {
                    dataGridView1.Rows.Add(reader2.GetString("m_id"), reader2.GetString("m_name"), reader2.GetString("m_count"), reader2.GetString("m_totalprice"));
                }
                reader2.Close();

                /*listbox需要在清除之后再添加，否则会导致数据重复*/
                listBox1.Items.Clear();
                for (int i = 0; i < employee_list.Count; i++)
                {
                    listBox1.Items.Add(employee_list[i]);
                }
                prodouct_count_label.Text = product_count.ToString();
                employee_count_label.Text = employee_count.ToString();
                sales_this_mouth_label.Text = sales_this_mouth.ToString(); 
            }
            else
            {
                conn.Open();
            }
            
        }

        private void 库存商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basic_Info_Product_Form basic_Info_Product_Form = new Basic_Info_Product_Form();
            basic_Info_Product_Form.ShowDialog();
        }

        private void 往来单位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basic_Info_Unit_Form basic_Info_Unit_Form = new Basic_Info_Unit_Form();
            basic_Info_Unit_Form.ShowDialog();
        }

        private void 公司职员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basic_Info_Employee_Form basic_Info_Employee_Form = new Basic_Info_Employee_Form();
            basic_Info_Employee_Form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            color.load();
        }

        private void 进货管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goods_input_Form goods_input_form = new goods_input_Form();
            goods_input_form.ShowDialog();
        }

        private void 进货退货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goods_back_Form goods_back_form = new goods_back_Form();
            goods_back_form.ShowDialog();
        }

        private void 进货分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goods_analyse_Form goods_analyse_form = new goods_analyse_Form();
            goods_analyse_form.ShowDialog();
        }

        private void 进货统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goods_statistics_Form goods_statistics_form = new goods_statistics_Form();
            goods_statistics_form.ShowDialog();
        }

        private void 库存上下限预警ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 库存管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kucun Form1 = new kucun();
            Form1.ShowDialog();
        }

        private void 系统维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            weihu Form2 = new weihu();
            Form2.ShowDialog();
        }

        private void 辅助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 登录InternetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hao.360.com/?a1004");
        }

        private void 启动WordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16" + "\\" + "WINWORD.EXE");
        }

        private void 启动ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16" + "\\" + "EXCEL.EXE");
        }

        private void 启动计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = "calc.exe ";
            System.Diagnostics.Process Proc = System.Diagnostics.Process.Start(Info);
        }

        private void 销售管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 销售单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm();
            sale.ShowDialog();
        }

        private void 销售退货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleReturn saleReturn = new saleReturn();
            saleReturn.ShowDialog();
        }

        private void 销售分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleanalyse saleanalyse = new saleanalyse();
            saleanalyse.ShowDialog();
        }

        private void 销售统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleSum saleSum = new saleSum();
            saleSum.ShowDialog();
        }

    }
}
