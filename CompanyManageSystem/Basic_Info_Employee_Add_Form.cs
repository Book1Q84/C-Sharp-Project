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
    public partial class Basic_Info_Employee_Add_Form : Form
    {
        public Basic_Info_Employee_Add_Form()
        {
            InitializeComponent();
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            globalData.AddPassData.Add(e_id_textbox.Text);
            globalData.AddPassData.Add(e_name_textbox.Text);
            globalData.AddPassData.Add(e_sex_comboBox.SelectedItem.ToString());
            globalData.AddPassData.Add(e_dp_textbox.Text);
            globalData.AddPassData.Add(e_tel_textbox.Text);
            globalData.AddPassData.Add(e_note_textbox.Text);
            this.Hide();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Basic_Info_Employee_Add_Form_Load(object sender, EventArgs e)
        {
            color.load();
        }
    }
}
