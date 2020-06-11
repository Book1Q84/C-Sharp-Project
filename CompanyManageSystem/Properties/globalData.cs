using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManageSystem
{
    class globalData
    {
        public static string sql = "SELECT sm_name as 名称,m_type as 类型,sm_price as 单价,m_count as 库存,sm_prices as 销售金额,sm_count as 销售数量,sm_person 经手人,sm_unit 往来单位  FROM product,sale_product WHERE product.m_name = sale_product.sm_name";
        public static int up = 100;
        public static int low = 0;
        public static List<String> AddPassData = new List<string>();
        public static List<String> SQL_list = new List<string>();
    }
}
