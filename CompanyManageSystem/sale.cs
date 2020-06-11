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
    public partial class SaleForm : System.Windows.Forms.Form
    {
        MySqlConnection conn;//声明一个MySqlConnection对象
        MySqlDataAdapter adapter;//声明一个MySqlDataAdapter对象

        public SaleForm()
        {
            InitializeComponent();
        }
        private void SaleForm_Load(object sender, EventArgs e)
        {
            textBox9.Text = DateTime.Now.ToString();
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
         * 
         * 将dataGridView中的数据存储到DataTable的对象中
         */
        private void Convert_dgv_to_dt(DataTable dtShow)
        {
            /*
             *用dataGridView1来初始化dtShow 
             *由于dataGridView1没有绑定数据源，所以用以下强制转化
             */
            // 列强制转换
            for (int count = 0; count < dataGridView1.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dataGridView1.Columns[count].Name.ToString());
                dtShow.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dataGridView1.Rows.Count; count++)
            {
                DataRow dr = dtShow.NewRow();
                for (int countsub = 0; countsub < dataGridView1.Columns.Count; countsub++)
                {
                    if (Convert.ToString(dataGridView1.Rows[count].Cells[countsub].Value) != "")
                    {
                        dr[countsub] = Convert.ToString(dataGridView1.Rows[count].Cells[countsub].Value);
                    }
                }
                dtShow.Rows.Add(dr);
            }
        }
        private DataTable dbconn(String strSql)
        {
            this.adapter = new MySqlDataAdapter(strSql, conn);
            DataTable dtSelect = new DataTable();
            int rnt = this.adapter.Fill(dtSelect);
            return dtSelect;
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
         * 获得unit表格数据
         * 
         */
        private DataTable getUnit()
        {
            String sql = "select * from unit";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            //MessageBox.Show(ds.Rows[0][0].ToString()+ ds.Rows[0][1].ToString()+ ds.Rows[0][2].ToString());
            return ds;
        }
        /*
         * 获得employee表格数据
         * 
         */
        private DataTable getEmployee()
        {
            String sql = "select * from employee";
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
         * 调用deleteSaleproduct，删除删除dataGridView中有而product中不存在的数据，单指库存商品名称这一项
         */
        private DataTable deleteSaleproduct(DataTable product, DataTable dtUpdate)
        {
            int flag = 0;
            for (int j = 0; j < dtUpdate.Rows.Count; j++)
            {
                for (int i = 0; i < product.Rows.Count; i++)
                {
                    flag = 0;
                    if (dtUpdate.Rows[j][1].ToString() == product.Rows[i][1].ToString() &&
                        dtUpdate.Rows[j][2].ToString() == product.Rows[i][3].ToString() &&
                        Convert.ToInt32(dtUpdate.Rows[j][3].ToString()) <= Convert.ToInt32(product.Rows[i][5].ToString()))
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    dtUpdate.Rows[j].Delete();
                    dtUpdate.AcceptChanges();
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("表格中存在不合法的数据,销售产品在库存中不存在或者数量大于库存，货物单位不正确!\n" +
                    "如果有合法的数据，该部分合法数据会存储到数据库里。");
            }
            return dtUpdate;
        }
        /*
         * 调用deleteUnit，删除dataGridView中有而employee中不存在的数据，单指销售单位这一项
         */
        private Boolean deleteUnit(DataTable unit, String unitName)
        {
            Boolean flag = false;
            for (int i = 0; i < unit.Rows.Count; i++)
            {
                if (unitName == unit.Rows[i][1].ToString())
                {
                    flag = true;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("表格中存在不合法的数据,往来单位在往来单位表中不存在!\n" +
                    "如果有合法的数据，该部分合法数据会存储到数据库里。");
            }
            return flag;
        }
        /*
        * 调用deleteEmployee，删除dataGridView中有而employee中不存在的数据，单指经手人这一项
        */
        private Boolean deleteEmployee(DataTable employee, String employeeName)
        {
            Boolean flag = false;
            for (int i = 0; i < employee.Rows.Count; i++)
            {
                if (employeeName == employee.Rows[i][1].ToString())
                {
                    flag = true;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("表格中存在不合法的数据,经手人在职工表中不存在!\n" +
                    "如果有合法的数据，该部分合法数据会存储到数据库里。");
            }
            return flag;
        }
        /*
       * 调用deletesaleproduct，删除dataGridView中有而saleproduct中不存在的数据，单指销售编号这一项
       */
        private DataTable deletesaleproduct(DataTable saleproduct, DataTable dtUpdate, String salerecepit)
        {
            Boolean flag = true;
            for (int j = 0; j < dtUpdate.Rows.Count; j++)
            {
                for (int i = 0; i < saleproduct.Rows.Count; i++)
                {
                    if(dtUpdate.Rows[j][0].ToString() != "")
                    {
                        if (Convert.ToInt32(dtUpdate.Rows[j][0].ToString()) == Convert.ToInt32(saleproduct.Rows[i][0].ToString())
                           || salerecepit == saleproduct.Rows[i][8].ToString())
                        {
                            flag = false;
                            dtUpdate.Rows[j].Delete();
                            dtUpdate.AcceptChanges();
                        }
                    }
                }
            }
            if (flag == false)
            {
                MessageBox.Show("表格中存在不合法的数据,销售编号或者收据编号在销售产品表中已存在!\n" +
                    "如果有合法的数据，该部分合法数据会存储到数据库里。");
            }
            return dtUpdate;
        }

        /*
         * 判断dataGridView中的数据是否在product表中存在，如果存在存储，不存在就删除
         */
        private Boolean dbUpdate()
        {
            String strSql = "select * from sale_product";
            DataTable dtUpdate = new DataTable();
            dtUpdate = this.dbconn(strSql);//调用dbconn方法
            dtUpdate.Rows.Clear();//调用Clear方法
            DataTable dtShow = new DataTable();
            //通过调用Convert_dgv_to_dt用dataGridView1来初始化dtShow
            Convert_dgv_to_dt(dtShow);
            //将dtShow中的值复制到dtUpdate
            for (int i = 0; i < dtShow.Rows.Count; i++)
            {
                if (dtShow.Rows[i][0].ToString() != "")
                {
                    dtUpdate.ImportRow(dtShow.Rows[i]);//使用ImportRow方法复制dtShow中的值
                }
            }
            //获取product表数据
            DataTable product = new DataTable();
            product = this.getProduct();                //调用getProduct方法
            //调用deleteSaleproduct，删除product中产品名称不存在的数据
            dtUpdate = deleteSaleproduct(product, dtUpdate);

            //获取unit表中数据
            DataTable unit = new DataTable();
            unit = this.getUnit();//调用getUnit方法
            //调用deleteUnit,判断dataGridView中是否有unit表中单位不存在的数据，仅针对往来单位这一项
            Boolean b1 = deleteUnit(unit, textBox7.Text.ToString());

            //获取employee表中数据
            DataTable employee = new DataTable();
            employee = this.getEmployee();//调用getEmployee方法
            //调用deleteEmployee,判断dataGridView中是否有employee表中单位不存在的数据，仅针对职工这一项
            Boolean b2 = deleteEmployee(employee, textBox5.Text.ToString());

            //获取saleproduct表中数据
            DataTable saleproduct = new DataTable();
            saleproduct = this.getSaleproduct();//调用getSaleproduct方法
            //调用deletesaleproduct
            dtUpdate = deletesaleproduct(saleproduct, dtUpdate, textBox8.Text.ToString());

            if (b1 == true && b2 == true)
            {
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy/MM/dd";
                for (int i = 0; i < dtUpdate.Rows.Count; i++)
                {
                    dtUpdate.Rows[i][6] = textBox5.Text.ToString();//经手人
                    dtUpdate.Rows[i][7] = Convert.ToDateTime(textBox9.Text.ToString(), dtFormat);//录单日期
                    dtUpdate.Rows[i][8] = textBox8.Text.ToString();//单据编号
                    dtUpdate.Rows[i][9] = textBox7.Text.ToString();//销售单位
                    dtUpdate.Rows[i][10] = textBox6.Text.ToString();//摘要
                    dtUpdate.Rows[i][11] = Convert.ToDouble(textBox4.Text.ToString());//差额
                    dtUpdate.Rows[i][12] = Convert.ToDouble(textBox2.Text.ToString());//应收金额
                    dtUpdate.Rows[i][13] = Convert.ToDouble(textBox3.Text.ToString());//实收金额
                }
                /*
                 * 将dtUpdate中的值存放到adapter中,通过adapter存到数据库中
                 */
                try
                {
                    MySqlCommandBuilder CommandBuilder;
                    CommandBuilder = new MySqlCommandBuilder(this.adapter);
                    this.adapter.Update(dtUpdate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                //修改库存商品数量，减去销售的商品数量
                for (int j = 0; j < dtUpdate.Rows.Count; j++)
                {
                    for (int i = 0; i < product.Rows.Count; i++)
                    {
                        if (dtUpdate.Rows[j][1].ToString() == product.Rows[i][1].ToString() &&
                            dtUpdate.Rows[j][2].ToString() == product.Rows[i][3].ToString() &&
                            Convert.ToInt32(dtUpdate.Rows[j][3].ToString()) <= Convert.ToInt32(product.Rows[i][5].ToString()))
                        {

                            MySqlCommand cmd = new MySqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = "update product set m_count="
                                + (Convert.ToInt32(product.Rows[i][5].ToString()) - Convert.ToInt32(dtUpdate.Rows[j][3].ToString()))
                                + " where m_name='" + dtUpdate.Rows[j][1] + "'";
                            cmd.ExecuteNonQuery();

                        }
                    }
                }
                dtUpdate.AcceptChanges();//提交销售单
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataBaseConnection();//连接数据库
            if (dbUpdate())//调用dbUpdate方法提交销售表单
            {
                MessageBox.Show("提交成功");
                conn.Close();//提交成功后关闭连接
            }
        }
        /*
         * 退出按钮，关闭销售单窗口
         */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         * 应收金额文本框点击事件
         */
        private void textBox2_Click(object sender, EventArgs e)
        {
            DataTable dtShow = new DataTable();
            //通过调用Convert_dgv_to_dt用dataGridView1来初始化dtShow
            Convert_dgv_to_dt(dtShow);
            double prices = 0;
            for (int i = 0; i < dtShow.Rows.Count; i++)
            {
                if (dtShow.Rows[i][3].ToString() != "")
                {
                    prices += Convert.ToDouble(dtShow.Rows[i][3].ToString()) * Convert.ToDouble(dtShow.Rows[i][4].ToString());
                }
            }
            textBox2.Text = prices.ToString();
        }
        /*
         * 差额文本框点击事件
         */
        private void textBox4_Click(object sender, EventArgs e)
        {
            DataTable dtShow = new DataTable();
            //通过调用Convert_dgv_to_dt用dataGridView1来初始化dtShow
            Convert_dgv_to_dt(dtShow);
            double prices = 0;
            for (int i = 0; i < dtShow.Rows.Count; i++)
            {
                if (dtShow.Rows[i][3].ToString() != "")
                {
                    prices += Convert.ToDouble(dtShow.Rows[i][3].ToString()) * Convert.ToDouble(dtShow.Rows[i][4].ToString());
                }
            }
            if (textBox3.Text.ToString() != "")
            {
                prices = prices - Convert.ToDouble(textBox3.Text.ToString());
            }
            else if (textBox3.Text.ToString() == "")
            {
                prices = prices - 0;
            }
            textBox4.Text = prices.ToString();
        }
        /*
         * 进货数量文本框点击事件
         */
        private void textBox1_Click(object sender, EventArgs e)
        {
            DataTable dtShow = new DataTable();
            //通过调用Convert_dgv_to_dt用dataGridView1来初始化dtShow
            Convert_dgv_to_dt(dtShow);
            int count = 0;
            for (int i = 0; i < dtShow.Rows.Count; i++)
            {
                if (dtShow.Rows[i][3].ToString() != "")
                {
                    count += Convert.ToInt32(dtShow.Rows[i][3].ToString());
                }
            }
            textBox1.Text = count.ToString();
        }
        /*
         * 实收金额判断提醒是否小于应收金额
         *
         *
         */
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.ToString() != "")
            {
                if (Convert.ToDouble(textBox3.Text.ToString()) < Convert.ToDouble(textBox2.Text.ToString()))
                {
                    MessageBox.Show("请注意，您输入的实际收款金额小于应收金额！！");
                    textBox4.Text = (Convert.ToDouble(textBox2.Text.ToString()) -
                Convert.ToDouble(textBox3.Text.ToString())).ToString();
                }
                else if (Convert.ToDouble(textBox3.Text.ToString()) < Convert.ToDouble(textBox2.Text.ToString()))
                {
                    MessageBox.Show("请注意，您输入的实际收款金额大于应收金额！！");
                    textBox4.Text = (Convert.ToDouble(textBox2.Text.ToString()) -
                Convert.ToDouble(textBox3.Text.ToString())).ToString();
                }
            }
            else if (textBox3.Text.ToString() == "")
            {
                textBox4.Text = (Convert.ToDouble(textBox2.Text.ToString()) - 0).ToString();
            }
        }
    }
}
