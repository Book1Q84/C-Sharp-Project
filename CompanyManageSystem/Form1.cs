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
using System.Threading;
using System.Timers;
namespace CompanyManageSystem
{
    public partial class kucun : Form
    {
        public kucun()
        {
            InitializeComponent();

        }

        public void 上下限设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kucun_baojing fm2 = new kucun_baojing();
            fm2.Show();
        }

        public void 选择查询日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kucun_chaxun fm3 = new kucun_chaxun();
            fm3.Show();
        }

        private void 选择排行榜条件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kucun_tiaojian fm4 = new kucun_tiaojian();
            fm4.Show();

        }


        private void kucun_Load(object sender, EventArgs e)
        {
            color.load();
            string constr = "server=127.0.0.1;port=3306;database=c#;username=root;password=123456;Charset=utf8;";
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            string sql = globalData.sql;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr = cmd.ExecuteReader();
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 确定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constr = "server=127.0.0.1;port=3306;user=root;password=123456; database=c#;charset=utf8";
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            string sql = globalData.sql;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr = cmd.ExecuteReader();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            int row = dataGridView1.Rows.Count;
            string name;
            for (int i = 0; i < row - 1; i++)
            {
                name = dataGridView1.Rows[i].Cells[0].Value.ToString();
               int str =int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                if ((globalData.up.CompareTo(str)) == -1)
                {
                    MessageBox.Show("超出上限:" + name);
                }
                if ((globalData.low.CompareTo(str)) == 1)
                {
                    MessageBox.Show("超出下限:" + name);
                }
            }
        }
    }
}
