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
    public partial class Basic_Info_Unit_Add_Form : Form
    {
        public Basic_Info_Unit_Add_Form()
        {
            InitializeComponent();
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            //List<string> AddPassData = new List<string>();  
            globalData.AddPassData.Add(u_id_textbox.Text);
            globalData.AddPassData.Add(u_name_textbox.Text);
            globalData.AddPassData.Add(u_tel_textbox.Text);
            globalData.AddPassData.Add(u_tex_textbox.Text);
            globalData.AddPassData.Add(u_telperson_textbox.Text);
            globalData.AddPassData.Add(u_account_textbox.Text);
            globalData.AddPassData.Add(u_addr_textbox.Text);
            this.Hide();
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Basic_Info_Unit_Add_Form_Load(object sender, EventArgs e)
        {
            color.load();
        }
    }
}
