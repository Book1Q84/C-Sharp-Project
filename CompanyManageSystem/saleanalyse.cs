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
    public partial class saleanalyse : Form
    {
        MySqlConnection conn;//声明一个MySqlConnection对象
        MySqlDataAdapter adapter;//声明一个MySqlDataAdapter对象
        
        public saleanalyse()
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
        * 获得product表格数据
        * 
        */
        private DataTable getProduct()
        {
            String sql = "select * from product";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            //MessageBox.Show(ds.Rows[0][0].ToString()+ ds.Rows[0][1].ToString()+ ds.Rows[0][2].ToString());
            return ds;
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
            sda.Fill(ds);
            //MessageBox.Show(ds.Rows[0][0].ToString()+ ds.Rows[0][1].ToString()+ ds.Rows[0][2].ToString());
            return ds;
        }
        /*
        * 统计出各个同名称产品销售的数量和所占比例
        * 
        */
        private void analyse(DataTable product,DataTable saleproduct,saleProduct[] sale)
        {
            double count1 = 0;//统计同一名称商品销售数量
            for (int j = 0; j < product.Rows.Count; j++)
            {
                count1 = 0;
                sale[j].setproductName(product.Rows[j][1].ToString());
                sale[j].setPercent(0);
                sale[j].setproductCount(0);
                for (int i = 0; i < saleproduct.Rows.Count; i++)
                {
                    if (saleproduct.Rows[i][1].ToString() == product.Rows[j][1].ToString())
                    {
                        count1 += Convert.ToDouble(saleproduct.Rows[i][3].ToString());
                        sale[j].setproductCount(count1);
                    }
                }
            }
            double count = 0;//初始化count
            //计算所有销售出去产品的总数量
            for(int i = 0; i < sale.Length; i++)
            {
                count += sale[i].getproductCount();
            }
            //计算各产品占总销售产品的比例的角度在圆饼图中
            for (int i = 0; i < sale.Length; i++)
            {
                if (count == 0)
                {
                    sale[i].setPercentangle(0);
                    sale[i].setPercent(0);
                }
                else if (count > 0)
                {
                    sale[i].setPercentangle(Convert.ToSingle((360 / Convert.ToSingle(count))
                    * Convert.ToSingle(sale[i].getproductCount())));
                    sale[i].setPercent(sale[i].getproductCount() / count);
                }
            }
        }
        /*
         * 根据同类名称产品销售的数量绘制饼状图
         */
        private void createImage(ref saleProduct[] sale)
        {
            //创建画图对象
            int width = 600, height = 1050;
            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            try
            {
                //清空背景色
                g.Clear(Color.White);
                Pen pen1 = new Pen(Color.Red);
                //创建4个Brush对象用于设置颜色
                Brush brush1 = new SolidBrush(Color.White);
                Brush[] brush = new Brush[4];
                brush[0] = new SolidBrush(Color.PowderBlue);
                brush[1] = new SolidBrush(Color.Blue);
                brush[2] = new SolidBrush(Color.Wheat);
                brush[3] = new SolidBrush(Color.Orange);
                //创建两个Font对象设置字体
                Font[] font = new Font[2];
                font[0] = new Font("Courier New", 16, FontStyle.Bold);
                font[1] = new Font("Courier New", 8);
                //绘制背景图
                g.FillRectangle(brush1, 0, 0, width, height);
                g.DrawString("商品销售比例饼状图", font[0], brush[1], new Point(80, 20));//书写标题
                int piex = 100, piey = 60, piew = 200, pieh = 200;
                float angle = 0;
                //int index = 0;
                for (int i = 0; i < sale.Length; i++)
                {
                    switch (i % 4)
                    {
                        case 0:
                            g.FillPie(brush[0], piex, piey, piew, pieh, angle, (float)(sale[i].getPercentangle()));
                            angle += (float)(sale[i].getPercentangle());
                            break;
                        case 1:
                            g.FillPie(brush[1], piex, piey, piew, pieh, angle, (float)(sale[i].getPercentangle()));
                            angle += (float)(sale[i].getPercentangle());
                            break;
                        case 2:
                            g.FillPie(brush[2], piex, piey, piew, pieh, angle, (float)(sale[i].getPercentangle()));
                            angle += (float)(sale[i].getPercentangle());
                            break;
                        case 3:
                            g.FillPie(brush[3], piex, piey, piew, pieh, angle, (float)(sale[i].getPercentangle()));
                            angle += (float)(sale[i].getPercentangle());
                            break;
                    }
                }
                //绘制标识
                g.DrawRectangle(pen1, 50, 300, 310, 130);//绘制矩形范围框
                int x = 320;
                for (int i = 0; i < sale.Length; i++)
                {
                    if (sale[i].getproductCount() > 0)
                    {
                        g.FillRectangle(brush[i % 4], 90, x, 20, 10);//绘制小矩形
                        g.DrawString(sale[i].getproductName() + "占总销售量比例:"
                            + sale[i].getPercent() * 100 + "%\n", font[1], brush[1], 120, x);
                        x += 40;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pictureBox1.Image = bitmap;
        }
        private void saleanalyse_Load(object sender, EventArgs e)
        {
            color.load();
            dataBaseConnection();//连接数据库
            //获取product表数据
            DataTable product = new DataTable();
            product = this.getProduct();                //调用getProduct方法
            //获取saleproduct表数据
            DataTable saleproduct = new DataTable();
            saleproduct = this.getSaleproduct();          //调用getSaleproduct方法
            //创建对象数组
            saleProduct[] sale = new saleProduct[product.Rows.Count];
            for(int i = 0; i < product.Rows.Count; i++)
            {
                sale[i] = new saleProduct();
            }
            
            //调用analyse()方法，统计出各个同名称产品销售的数量
            analyse(product,saleproduct,sale);
            //调用createImage()方法，根据同类名称产品销售的数量绘制饼状图
            createImage(ref sale);
            
            //关闭数据库连接
            conn.Close();
        }
    }
    class saleProduct
    {
        private String productName;//销售出去的同一商品名称的产品名称
        private double productCount;//销售出去的同一商品名称的产品数量
        private double percent;//销售出去的同一商品名称的产品占所有销售出去产品的比例
        private double percentangle;//销售出去的同一商品名称的产品占所有销售出去产品的比例的角度

        public void setproductName(String productName)
        {
            this.productName = productName;
        }
        public String getproductName()
        {
            return this.productName;
        }

        public void setproductCount(double productCount)
        {
            this.productCount = productCount;
        }
        public double getproductCount()
        {
            return this.productCount;
        }
        public void setPercent(double percent)
        {
            this.percent = percent;
        }
        public double getPercent()
        {
            return this.percent;
        }
        public void setPercentangle(double percentangle)
        {
            this.percentangle = percentangle;
        }
        public double getPercentangle()
        {
            return this.percentangle;
        }
    }
}
