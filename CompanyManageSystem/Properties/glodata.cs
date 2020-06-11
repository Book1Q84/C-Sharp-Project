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
    class glodata
    {
        public static string sql= "SELECT e_id as 编号,e_name as 姓名,e_sex as 性别,e_dp as 单位,e_tel as 电话, e_note as 备注 FROM employee";
  
    }
}
