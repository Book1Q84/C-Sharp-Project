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
    public partial class Basic_Info_Product_Add_Form : Form
    {
        public Basic_Info_Product_Add_Form()
        {
            InitializeComponent();
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            //List<string> AddPassData = new List<string>();  
            globalData.AddPassData.Add(m_id_textbox.Text);
            globalData.AddPassData.Add(m_name_textbox.Text);
            globalData.AddPassData.Add(m_type_textbox.Text);
            globalData.AddPassData.Add(m_dp_textbox.Text);
            globalData.AddPassData.Add(m_addr_textbox.Text);
            globalData.AddPassData.Add(m_count_textbox.Text);
            globalData.AddPassData.Add(m_price_textbox.Text);

            this.Hide();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Basic_Info_Product_Add_Form_Load(object sender, EventArgs e)
        {
            color.load();
        }
    }
}
