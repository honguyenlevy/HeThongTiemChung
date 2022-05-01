using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HeThongTiemChung.DataBase;

namespace HeThongTiemChung.Controller
{
    class GoiVacxin_Controller
    {
        public static DataSet LayDSGoiVacXin()
        {
            DataSet dt = GoiVacxin_DB.GetTDsGoiVacxin();
            return dt;
        }

        public static string LayGiaGoiVaccine(string TenGoi)
        {
            string dt = GoiVacxin_DB.LayGiaGoiVaccine(TenGoi);
            return dt;
        }

        public static string LaySoLuongGoiVaccine(string TenGoi)
        {
            string dt = GoiVacxin_DB.LaySoLuongGoiVaccine(TenGoi);
            return dt;
        }

        public static void CapnhatSLDat(string MaVaccine, int SoLuong)
        {
            GoiVacxin_DB.CapNhatSoLuongDat(MaVaccine, SoLuong);
        }


        public static DataSet LayGoiVacXinCanDatMua()
        {
            DataSet dt = GoiVacxin_DB.LayGoiVaccineCanDatMua();
            return dt;
        }

        public static void CapnhatSLTon(string MaVaccine, int SoLuong)
        {
            GoiVacxin_DB.CapNhatSoLuongTon(MaVaccine, SoLuong);
        }

        public static DataSet KH_LayDSGoiVacXin()
        {
            DataSet dt = GoiVacxin_DB.KH_GetTDsGoiVacxin();
            return dt;
        }
    }
}
