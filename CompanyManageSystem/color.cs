using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CompanyManageSystem
{
    class color
    {
        public static string clo = "白色";
        public static void load()
        {
            switch (clo)
            {
                case "护眼":
                    Cornsilk();
                    break;
                case "蓝色":
                    Blue();
                    break;
                case "绿色":
                    Green();
                    break;
                case "黄色":
                    Yellow();
                    break;
                case "红色":
                    Red();
                    break;
                case "灰色":
                    Gray();
                    break;
                case "白色":
                    White();
                    break;
            }
        }
        public static void Cornsilk()
        {
            Form fm = Application.OpenForms["MainForm"];
            if (fm != null)
            {
                fm.BackColor = Color.Cornsilk;
            }
            Form fm1 = Application.OpenForms["weihu"];
            if (fm1 != null)
            {
                fm1.BackColor = Color.Cornsilk;
            }
            Form fm2 = Application.OpenForms["Basic_Info_Employee_Add_Form"];
            if (fm2 != null)
            {
                fm2.BackColor = Color.Cornsilk;
            }
            Form fm3 = Application.OpenForms["shezhi"];
            if (fm3 != null)
            {
                fm3.BackColor = Color.Cornsilk;
            }
            Form fm4 = Application.OpenForms["Basic_Info_Employee_Form"];
            if (fm4 != null)
            {
                fm4.BackColor = Color.Cornsilk;
            }
            Form fm5 = Application.OpenForms["Basic_Info_Product_Add_Form"];
            if (fm5 != null)
            {
                fm5.BackColor = Color.Cornsilk;
            }
            Form fm6 = Application.OpenForms["Basic_Info_Product_Form"];
            if (fm6 != null)
            {
                fm6.BackColor = Color.Cornsilk;
            }
            Form fm7 = Application.OpenForms["Basic_Info_Unit_Add_Form"];
            if (fm7 != null)
            {
                fm7.BackColor = Color.Cornsilk;
            }
            Form fm8 = Application.OpenForms["Basic_Info_Unit_Form"];
            if (fm8 != null)
            {
                fm8.BackColor = Color.Cornsilk;
            }
            Form fm9 = Application.OpenForms["kucun"];
            if (fm9 != null)
            {
                fm9.BackColor = Color.Cornsilk;
            }
            Form fm10 = Application.OpenForms["goods_back_Form"];
            if (fm10 != null)
            {
                fm10.BackColor = Color.Cornsilk;
            }
            Form fm11 = Application.OpenForms["goods_analyse_Form"];
            if (fm11 != null)
            {
                fm11.BackColor = Color.Cornsilk;
            }
            Form fm12 = Application.OpenForms["goods_input_Form"];
            if (fm12 != null)
            {
                fm12.BackColor = Color.Cornsilk;
            }
            Form fm13 = Application.OpenForms["goods_statistics_Form"];
            if (fm13 != null)
            {
                fm13.BackColor = Color.Cornsilk;
            }
            Form fm14 = Application.OpenForms["SaleForm"];
            if (fm14 != null)
            {
                fm14.BackColor = Color.Cornsilk;
            }
            Form fm15 = Application.OpenForms["saleanalyse"];
            if (fm15 != null)
            {
                fm15.BackColor = Color.Cornsilk;
            }
            Form fm16 = Application.OpenForms["saleReturn"];
            if (fm16 != null)
            {
                fm16.BackColor = Color.Cornsilk;
            }
            Form fm17 = Application.OpenForms["saleSum"];
            if (fm17 != null)
            {
                fm17.BackColor = Color.Cornsilk;
            }
            Form fm18 = Application.OpenForms["kucun_baojing"];
            if (fm18 != null)
            {
                fm18.BackColor = Color.Cornsilk;
            }
            Form fm19 = Application.OpenForms["kucun_chaxun"];
            if (fm19 != null)
            {
                fm19.BackColor = Color.Cornsilk;
            }
            Form fm20 = Application.OpenForms["kucun_tiaojian"];
            if (fm20 != null)
            {
                fm20.BackColor = Color.Cornsilk;
            }
        }














        public static void Blue()
        {
            Form fm = Application.OpenForms["MainForm"];
            if (fm != null)
            {
                fm.BackColor = Color.Blue;
            }
            Form fm1 = Application.OpenForms["weihu"];
            if (fm1 != null)
            {
                fm1.BackColor = Color.Blue;
            }
            Form fm2 = Application.OpenForms["Basic_Info_Employee_Add_Form"];
            if (fm2 != null)
            {
                fm2.BackColor = Color.Blue;
            }
            Form fm3 = Application.OpenForms["shezhi"];
            if (fm3 != null)
            {
                fm3.BackColor = Color.Blue;
            }
            Form fm4 = Application.OpenForms["Basic_Info_Employee_Form"];
            if (fm4 != null)
            {
                fm4.BackColor = Color.Blue;
            }
            Form fm5 = Application.OpenForms["Basic_Info_Product_Add_Form"];
            if (fm5 != null)
            {
                fm5.BackColor = Color.Blue;
            }
            Form fm6 = Application.OpenForms["Basic_Info_Product_Form"];
            if (fm6 != null)
            {
                fm6.BackColor = Color.Blue;
            }
            Form fm7 = Application.OpenForms["Basic_Info_Unit_Add_Form"];
            if (fm7 != null)
            {
                fm7.BackColor = Color.Blue;
            }
            Form fm8 = Application.OpenForms["Basic_Info_Unit_Form"];
            if (fm8 != null)
            {
                fm8.BackColor = Color.Blue;
            }
            Form fm9 = Application.OpenForms["kucun"];
            if (fm9 != null)
            {
                fm9.BackColor = Color.Blue;
            }
            Form fm10 = Application.OpenForms["goods_back_Form"];
            if (fm10 != null)
            {
                fm10.BackColor = Color.Blue;
            }
            Form fm11 = Application.OpenForms["goods_analyse_Form"];
            if (fm11 != null)
            {
                fm11.BackColor = Color.Blue;
            }
            Form fm12 = Application.OpenForms["goods_input_Form"];
            if (fm12 != null)
            {
                fm12.BackColor = Color.Blue;
            }
            Form fm13 = Application.OpenForms["goods_statistics_Form"];
            if (fm13 != null)
            {
                fm13.BackColor = Color.Blue;
            }
            Form fm14 = Application.OpenForms["SaleForm"];
            if (fm14 != null)
            {
                fm14.BackColor = Color.Blue;
            }
            Form fm15 = Application.OpenForms["saleanalyse"];
            if (fm15 != null)
            {
                fm15.BackColor = Color.Blue;
            }
            Form fm16 = Application.OpenForms["saleReturn"];
            if (fm16 != null)
            {
                fm16.BackColor = Color.Blue;
            }
            Form fm17 = Application.OpenForms["saleSum"];
            if (fm17 != null)
            {
                fm17.BackColor = Color.Blue;
            }
            Form fm18 = Application.OpenForms["kucun_baojing"];
            if (fm18 != null)
            {
                fm18.BackColor = Color.Blue;
            }
            Form fm19 = Application.OpenForms["kucun_chaxun"];
            if (fm19 != null)
            {
                fm19.BackColor = Color.Blue;
            }
            Form fm20 = Application.OpenForms["kucun_tiaojian"];
            if (fm20 != null)
            {
                fm20.BackColor = Color.Blue;
            }
        }











        public static void Red()
        {
            Form fm = Application.OpenForms["MainForm"];
            if (fm != null)
            {
                fm.BackColor = Color.Red;
            }
            Form fm1 = Application.OpenForms["weihu"];
            if (fm1 != null)
            {
                fm1.BackColor = Color.Red;
            }
            Form fm2 = Application.OpenForms["Basic_Info_Employee_Add_Form"];
            if (fm2 != null)
            {
                fm2.BackColor = Color.Red;
            }
            Form fm3 = Application.OpenForms["shezhi"];
            if (fm3 != null)
            {
                fm3.BackColor = Color.Red;
            }
            Form fm4 = Application.OpenForms["Basic_Info_Employee_Form"];
            if (fm4 != null)
            {
                fm4.BackColor = Color.Red;
            }
            Form fm5 = Application.OpenForms["Basic_Info_Product_Add_Form"];
            if (fm5 != null)
            {
                fm5.BackColor = Color.Red;
            }
            Form fm6 = Application.OpenForms["Basic_Info_Product_Form"];
            if (fm6 != null)
            {
                fm6.BackColor = Color.Red;
            }
            Form fm7 = Application.OpenForms["Basic_Info_Unit_Add_Form"];
            if (fm7 != null)
            {
                fm7.BackColor = Color.Red;
            }
            Form fm8 = Application.OpenForms["Basic_Info_Unit_Form"];
            if (fm8 != null)
            {
                fm8.BackColor = Color.Red;
            }
            Form fm9 = Application.OpenForms["kucun"];
            if (fm9 != null)
            {
                fm9.BackColor = Color.Red;
            }
            Form fm10 = Application.OpenForms["goods_back_Form"];
            if (fm10 != null)
            {
                fm10.BackColor = Color.Red;
            }
            Form fm11 = Application.OpenForms["goods_analyse_Form"];
            if (fm11 != null)
            {
                fm11.BackColor = Color.Red;
            }
            Form fm12 = Application.OpenForms["goods_input_Form"];
            if (fm12 != null)
            {
                fm12.BackColor = Color.Red;
            }
            Form fm13 = Application.OpenForms["goods_statistics_Form"];
            if (fm13 != null)
            {
                fm13.BackColor = Color.Red;
            }
            Form fm14 = Application.OpenForms["SaleForm"];
            if (fm14 != null)
            {
                fm14.BackColor = Color.Red;
            }
            Form fm15 = Application.OpenForms["saleanalyse"];
            if (fm15 != null)
            {
                fm15.BackColor = Color.Red;
            }
            Form fm16 = Application.OpenForms["saleReturn"];
            if (fm16 != null)
            {
                fm16.BackColor = Color.Red;
            }
            Form fm17 = Application.OpenForms["saleSum"];
            if (fm17 != null)
            {
                fm17.BackColor = Color.Red;
            }
            Form fm18 = Application.OpenForms["kucun_baojing"];
            if (fm18 != null)
            {
                fm18.BackColor = Color.Red;
            }
            Form fm19 = Application.OpenForms["kucun_chaxun"];
            if (fm19 != null)
            {
                fm19.BackColor = Color.Red;
            }
            Form fm20 = Application.OpenForms["kucun_tiaojian"];
            if (fm20 != null)
            {
                fm20.BackColor = Color.Red;
            }
        }









        public static void Green()
        {
            Form fm = Application.OpenForms["MainForm"];
            if (fm != null)
            {
                fm.BackColor = Color.Green;
            }
            Form fm1 = Application.OpenForms["weihu"];
            if (fm1 != null)
            {
                fm1.BackColor = Color.Green;
            }
            Form fm2 = Application.OpenForms["Basic_Info_Employee_Add_Form"];
            if (fm2 != null)
            {
                fm2.BackColor = Color.Green;
            }
            Form fm3 = Application.OpenForms["shezhi"];
            if (fm3 != null)
            {
                fm3.BackColor = Color.Green;
            }
            Form fm4 = Application.OpenForms["Basic_Info_Employee_Form"];
            if (fm4 != null)
            {
                fm4.BackColor = Color.Green;
            }
            Form fm5 = Application.OpenForms["Basic_Info_Product_Add_Form"];
            if (fm5 != null)
            {
                fm5.BackColor = Color.Green;
            }
            Form fm6 = Application.OpenForms["Basic_Info_Product_Form"];
            if (fm6 != null)
            {
                fm6.BackColor = Color.Green;
            }
            Form fm7 = Application.OpenForms["Basic_Info_Unit_Add_Form"];
            if (fm7 != null)
            {
                fm7.BackColor = Color.Green;
            }
            Form fm8 = Application.OpenForms["Basic_Info_Unit_Form"];
            if (fm8 != null)
            {
                fm8.BackColor = Color.Green;
            }
            Form fm9 = Application.OpenForms["kucun"];
            if (fm9 != null)
            {
                fm9.BackColor = Color.Green;
            }
            Form fm10 = Application.OpenForms["goods_back_Form"];
            if (fm10 != null)
            {
                fm10.BackColor = Color.Green;
            }
            Form fm11 = Application.OpenForms["goods_analyse_Form"];
            if (fm11 != null)
            {
                fm11.BackColor = Color.Green;
            }
            Form fm12 = Application.OpenForms["goods_input_Form"];
            if (fm12 != null)
            {
                fm12.BackColor = Color.Green;
            }
            Form fm13 = Application.OpenForms["goods_statistics_Form"];
            if (fm13 != null)
            {
                fm13.BackColor = Color.Green;
            }
            Form fm14 = Application.OpenForms["SaleForm"];
            if (fm14 != null)
            {
                fm14.BackColor = Color.Green;
            }
            Form fm15 = Application.OpenForms["saleanalyse"];
            if (fm15 != null)
            {
                fm15.BackColor = Color.Green;
            }
            Form fm16 = Application.OpenForms["saleReturn"];
            if (fm16 != null)
            {
                fm16.BackColor = Color.Green;
            }
            Form fm17 = Application.OpenForms["saleSum"];
            if (fm17 != null)
            {
                fm17.BackColor = Color.Green;
            }
            Form fm18 = Application.OpenForms["kucun_baojing"];
            if (fm18 != null)
            {
                fm18.BackColor = Color.Green;
            }
            Form fm19 = Application.OpenForms["kucun_chaxun"];
            if (fm19 != null)
            {
                fm19.BackColor = Color.Green;
            }
            Form fm20 = Application.OpenForms["kucun_tiaojian"];
            if (fm20 != null)
            {
                fm20.BackColor = Color.Green;
            }
        }





        public static void Yellow()
        {
            Form fm = Application.OpenForms["MainForm"];
            if (fm != null)
            {
                fm.BackColor = Color.Yellow;
            }
            Form fm1 = Application.OpenForms["weihu"];
            if (fm1 != null)
            {
                fm1.BackColor = Color.Yellow;
            }
            Form fm2 = Application.OpenForms["Basic_Info_Employee_Add_Form"];
            if (fm2 != null)
            {
                fm2.BackColor = Color.Yellow;
            }
            Form fm3 = Application.OpenForms["shezhi"];
            if (fm3 != null)
            {
                fm3.BackColor = Color.Yellow;
            }
            Form fm4 = Application.OpenForms["Basic_Info_Employee_Form"];
            if (fm4 != null)
            {
                fm4.BackColor = Color.Yellow;
            }
            Form fm5 = Application.OpenForms["Basic_Info_Product_Add_Form"];
            if (fm5 != null)
            {
                fm5.BackColor = Color.Yellow;
            }
            Form fm6 = Application.OpenForms["Basic_Info_Product_Form"];
            if (fm6 != null)
            {
                fm6.BackColor = Color.Yellow;
            }
            Form fm7 = Application.OpenForms["Basic_Info_Unit_Add_Form"];
            if (fm7 != null)
            {
                fm7.BackColor = Color.Yellow;
            }
            Form fm8 = Application.OpenForms["Basic_Info_Unit_Form"];
            if (fm8 != null)
            {
                fm8.BackColor = Color.Yellow;
            }
            Form fm9 = Application.OpenForms["kucun"];
            if (fm9 != null)
            {
                fm9.BackColor = Color.Yellow;
            }
            Form fm10 = Application.OpenForms["goods_back_Form"];
            if (fm10 != null)
            {
                fm10.BackColor = Color.Yellow;
            }
            Form fm11 = Application.OpenForms["goods_analyse_Form"];
            if (fm11 != null)
            {
                fm11.BackColor = Color.Yellow;
            }
            Form fm12 = Application.OpenForms["goods_input_Form"];
            if (fm12 != null)
            {
                fm12.BackColor = Color.Yellow;
            }
            Form fm13 = Application.OpenForms["goods_statistics_Form"];
            if (fm13 != null)
            {
                fm13.BackColor = Color.Yellow;
            }
            Form fm14 = Application.OpenForms["SaleForm"];
            if (fm14 != null)
            {
                fm14.BackColor = Color.Yellow;
            }
            Form fm15 = Application.OpenForms["saleanalyse"];
            if (fm15 != null)
            {
                fm15.BackColor = Color.Yellow;
            }
            Form fm16 = Application.OpenForms["saleReturn"];
            if (fm16 != null)
            {
                fm16.BackColor = Color.Yellow;
            }
            Form fm17 = Application.OpenForms["saleSum"];
            if (fm17 != null)
            {
                fm17.BackColor = Color.Yellow;
            }
            Form fm18 = Application.OpenForms["kucun_baojing"];
            if (fm18 != null)
            {
                fm18.BackColor = Color.Yellow;
            }
            Form fm19 = Application.OpenForms["kucun_chaxun"];
            if (fm19 != null)
            {
                fm19.BackColor = Color.Yellow;
            }
            Form fm20 = Application.OpenForms["kucun_tiaojian"];
            if (fm20 != null)
            {
                fm20.BackColor = Color.Yellow;
            }
        }





        public static void Gray()
        {
            Form fm = Application.OpenForms["MainForm"];
            if (fm != null)
            {
                fm.BackColor = Color.Gray;
            }
            Form fm1 = Application.OpenForms["weihu"];
            if (fm1 != null)
            {
                fm1.BackColor = Color.Gray;
            }
            Form fm2 = Application.OpenForms["Basic_Info_Employee_Add_Form"];
            if (fm2 != null)
            {
                fm2.BackColor = Color.Gray;
            }
            Form fm3 = Application.OpenForms["shezhi"];
            if (fm3 != null)
            {
                fm3.BackColor = Color.Gray;
            }
            Form fm4 = Application.OpenForms["Basic_Info_Employee_Form"];
            if (fm4 != null)
            {
                fm4.BackColor = Color.Gray;
            }
            Form fm5 = Application.OpenForms["Basic_Info_Product_Add_Form"];
            if (fm5 != null)
            {
                fm5.BackColor = Color.Gray;
            }
            Form fm6 = Application.OpenForms["Basic_Info_Product_Form"];
            if (fm6 != null)
            {
                fm6.BackColor = Color.Gray;
            }
            Form fm7 = Application.OpenForms["Basic_Info_Unit_Add_Form"];
            if (fm7 != null)
            {
                fm7.BackColor = Color.Gray;
            }
            Form fm8 = Application.OpenForms["Basic_Info_Unit_Form"];
            if (fm8 != null)
            {
                fm8.BackColor = Color.Gray;
            }
            Form fm9 = Application.OpenForms["kucun"];
            if (fm9 != null)
            {
                fm9.BackColor = Color.Gray;
            }
            Form fm10 = Application.OpenForms["goods_back_Form"];
            if (fm10 != null)
            {
                fm10.BackColor = Color.Gray;
            }
            Form fm11 = Application.OpenForms["goods_analyse_Form"];
            if (fm11 != null)
            {
                fm11.BackColor = Color.Gray;
            }
            Form fm12 = Application.OpenForms["goods_input_Form"];
            if (fm12 != null)
            {
                fm12.BackColor = Color.Gray;
            }
            Form fm13 = Application.OpenForms["goods_statistics_Form"];
            if (fm13 != null)
            {
                fm13.BackColor = Color.Gray;
            }
            Form fm14 = Application.OpenForms["SaleForm"];
            if (fm14 != null)
            {
                fm14.BackColor = Color.Gray;
            }
            Form fm15 = Application.OpenForms["saleanalyse"];
            if (fm15 != null)
            {
                fm15.BackColor = Color.Gray;
            }
            Form fm16 = Application.OpenForms["saleReturn"];
            if (fm16 != null)
            {
                fm16.BackColor = Color.Gray;
            }
            Form fm17 = Application.OpenForms["saleSum"];
            if (fm17 != null)
            {
                fm17.BackColor = Color.Gray;
            }
            Form fm18 = Application.OpenForms["kucun_baojing"];
            if (fm18 != null)
            {
                fm18.BackColor = Color.Gray;
            }
            Form fm19 = Application.OpenForms["kucun_chaxun"];
            if (fm19 != null)
            {
                fm19.BackColor = Color.Gray;
            }
            Form fm20 = Application.OpenForms["kucun_tiaojian"];
            if (fm20 != null)
            {
                fm20.BackColor = Color.Gray;
            }
        }









        public static void White()
        {
            Form fm = Application.OpenForms["MainForm"];
            if (fm != null)
            {
                fm.BackColor = Color.White;
            }
            Form fm1 = Application.OpenForms["weihu"];
            if (fm1 != null)
            {
                fm1.BackColor = Color.White;
            }
            Form fm2 = Application.OpenForms["Basic_Info_Employee_Add_Form"];
            if (fm2 != null)
            {
                fm2.BackColor = Color.White;
            }
            Form fm3 = Application.OpenForms["shezhi"];
            if (fm3 != null)
            {
                fm3.BackColor = Color.White;
            }
            Form fm4 = Application.OpenForms["Basic_Info_Employee_Form"];
            if (fm4 != null)
            {
                fm4.BackColor = Color.White;
            }
            Form fm5 = Application.OpenForms["Basic_Info_Product_Add_Form"];
            if (fm5 != null)
            {
                fm5.BackColor = Color.White;
            }
            Form fm6 = Application.OpenForms["Basic_Info_Product_Form"];
            if (fm6 != null)
            {
                fm6.BackColor = Color.White;
            }
            Form fm7 = Application.OpenForms["Basic_Info_Unit_Add_Form"];
            if (fm7 != null)
            {
                fm7.BackColor = Color.White;
            }
            Form fm8 = Application.OpenForms["Basic_Info_Unit_Form"];
            if (fm8 != null)
            {
                fm8.BackColor = Color.White;
            }
            Form fm9 = Application.OpenForms["kucun"];
            if (fm9 != null)
            {
                fm9.BackColor = Color.White;
            }
            Form fm10 = Application.OpenForms["goods_back_Form"];
            if (fm10 != null)
            {
                fm10.BackColor = Color.White;
            }
            Form fm11 = Application.OpenForms["goods_analyse_Form"];
            if (fm11 != null)
            {
                fm11.BackColor = Color.White;
            }
            Form fm12 = Application.OpenForms["goods_input_Form"];
            if (fm12 != null)
            {
                fm12.BackColor = Color.White;
            }
            Form fm13 = Application.OpenForms["goods_statistics_Form"];
            if (fm13 != null)
            {
                fm13.BackColor = Color.White;
            }
            Form fm14 = Application.OpenForms["SaleForm"];
            if (fm14 != null)
            {
                fm14.BackColor = Color.White;
            }
            Form fm15 = Application.OpenForms["saleanalyse"];
            if (fm15 != null)
            {
                fm15.BackColor = Color.White;
            }
            Form fm16 = Application.OpenForms["saleReturn"];
            if (fm16 != null)
            {
                fm16.BackColor = Color.White;
            }
            Form fm17 = Application.OpenForms["saleSum"];
            if (fm17 != null)
            {
                fm17.BackColor = Color.White;
            }
            Form fm18 = Application.OpenForms["kucun_baojing"];
            if (fm18 != null)
            {
                fm18.BackColor = Color.White;
            }
            Form fm19 = Application.OpenForms["kucun_chaxun"];
            if (fm19 != null)
            {
                fm19.BackColor = Color.White;
            }
            Form fm20 = Application.OpenForms["kucun_tiaojian"];
            if (fm20 != null)
            {
                fm20.BackColor = Color.White;
            }
        }

    }
}
