using MySql.Data.MySqlClient;
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
    public partial class Basic_Info_Employee_Form : Form
    {
        MySqlConnection conn;
        /*用作修改中，定位要修改或删除的字段*/
        String id_b;
        public Basic_Info_Employee_Form()
        {
            InitializeComponent();
        }

        private void Basic_Info_Employee_Form_Load(object sender, EventArgs e)
        {
            color.load();
            /*页面加载时，测试数据库链接，并查询在职员工信息*/
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=c#;Charset=utf8;";
            String data_query = "select * from employee";
            conn = new MySqlConnection(connetStr);
            conn.Open();
            MySqlCommand command1 = new MySqlCommand();//查询在职员工
            command1.CommandText = data_query;
            command1.Connection = conn;
            command1.CommandType = CommandType.Text;
            MySqlDataReader reader = command1.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                /*e_note为空时，无法使用reader.GetString为datagridview添加数据
                 需要进行isdbnull判断，否则会抛出<数据为空。不能对空值调用此方法或属性>错误*/
                if (reader.IsDBNull(5))
                {
                    String e_note = "";
                    dataGridView1.Rows.Add(reader.GetString("e_id"), reader.GetString("e_name"), reader.GetString("e_sex"),
                    reader.GetString("e_dp"), reader.GetString("e_tel"),
                    e_note);
                }
                else
                {
                    dataGridView1.Rows.Add(reader.GetString("e_id"), reader.GetString("e_name"), reader.GetString("e_sex"),
                    reader.GetString("e_dp"), reader.GetString("e_tel"),
                    reader.GetString("e_note"));
                }
                
            }
            reader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*在选中某一单元格内容的情况下，将该行数据显示在textbox中，并启用编辑和删除按钮*/
            int row_index = dataGridView1.CurrentCell.RowIndex;
            e_id_textbox.Text = dataGridView1[0, row_index].Value.ToString();
            e_name_textbox.Text = dataGridView1[1, row_index].Value.ToString();
            e_sex_comboBox.SelectedItem = dataGridView1[2, row_index].Value.ToString();
            e_dp_textbox.Text = dataGridView1[3, row_index].Value.ToString();
            e_tel_textbox.Text = dataGridView1[4, row_index].Value.ToString();
            e_note_textbox.Text = dataGridView1[5, row_index].Value.ToString();
            if (dataGridView1.CurrentCell.Value != null)
            {
                编辑ToolStripMenuItem.Enabled = true;
                删除ToolStripMenuItem.Enabled = true;
                id_b = e_id_textbox.Text;
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*唤起添加窗口，并将globaldata.addpassdata的数据传递到this窗口中，供调用*/
            Basic_Info_Employee_Add_Form basic_Info_Employee_Add_Form = new Basic_Info_Employee_Add_Form();
            basic_Info_Employee_Add_Form.ShowDialog();
            if (globalData.AddPassData.Count != 0)
            {
                String id = globalData.AddPassData[0];
                String name = globalData.AddPassData[1];
                String sex = globalData.AddPassData[2];
                String dp = globalData.AddPassData[3];
                String tel = globalData.AddPassData[4];
                String note = globalData.AddPassData[5];
                dataGridView1.Rows.Add(id, name, sex, dp, tel, note);
                /*globalData.SQL_list定义见globalData类>globalData.cs
                 用于事务运行*/
                globalData.SQL_list.Add("insert into employee values(" + int.Parse(id) + ",\'" + name + "\', \'" + sex + "\', \'" + dp + "\', \'" + tel + "\', \'" + note + "\')");
            }
            globalData.AddPassData.Clear();
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*点击编辑按钮后，使textbox都可编辑，并可以确定*/
            确定YToolStripMenuItem.Enabled = true;
            e_id_textbox.Enabled = true;
            e_name_textbox.Enabled = true;
            e_sex_comboBox.Enabled = true;
            e_tel_textbox.Enabled = true;
            e_note_textbox.Enabled = true;
            e_dp_textbox.Enabled = true;

        }

        private void 确定YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*1、将编辑完的内容写到dataGridView相应单元格中*/
            dataGridView1[0, dataGridView1.CurrentRow.Index].Value = e_id_textbox.Text;
            dataGridView1[1, dataGridView1.CurrentRow.Index].Value = e_name_textbox.Text;
            dataGridView1[2, dataGridView1.CurrentRow.Index].Value = e_sex_comboBox.SelectedItem.ToString();
            dataGridView1[3, dataGridView1.CurrentRow.Index].Value = e_dp_textbox.Text;
            dataGridView1[4, dataGridView1.CurrentRow.Index].Value = e_tel_textbox.Text;
            dataGridView1[5, dataGridView1.CurrentRow.Index].Value = e_note_textbox.Text;
            /*并将编辑完的内容放入变量，写入sql_list中*/
            String id = e_id_textbox.Text;
            String name = e_name_textbox.Text;
            String sex = e_sex_comboBox.SelectedItem.ToString();
            String dp = e_dp_textbox.Text;
            String tel = e_tel_textbox.Text;
            String note = e_note_textbox.Text;
            //注意update需要有where 不然会抛出mysql异常
            globalData.SQL_list.Add("UPDATE employee " +
                "SET e_id=" + int.Parse(id) + ",e_tel=\'" + tel + "\',e_note=\'" + note + "\',e_dp=\'" + dp + "\',e_name=\'" + name +  "\',e_sex=\'" + sex + "\'" +
                " where e_id=" + id_b);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*获取当前选中单元格的所在行，并添加进sql_list，并使用remove方法删除*/
            int CurrentRow = dataGridView1.CurrentRow.Index;
            String del_id = dataGridView1[0, CurrentRow].Value.ToString();
            globalData.SQL_list.Add("DELETE FROM employee WHERE e_id=" + del_id + ";");
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*保存，*/
            MySqlTransaction transaction = conn.BeginTransaction();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.Transaction = transaction;

                try
                {
                    for (int n = 0; n < globalData.SQL_list.Count; n++)
                    {
                        string strsql = globalData.SQL_list[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    //cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("保存成功！");
                    globalData.SQL_list.Clear();
                }
                catch (MySqlException exc)
                {
                    Console.WriteLine(exc.Message);
                    MessageBox.Show("保存失败！请检查信息是否有误");
                    transaction.Rollback();
                }
        }
    }
}
