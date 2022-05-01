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
    class Vacxin_Controller
    {
        

        public static DataSet LayDSVacXin()
        {
            DataSet dt = Vacxin_DB.GetTDsVacxin();
            return dt;
        }

        public static string LayGiaVaccine(string TenVacxin)
        {
            string dt = Vacxin_DB.LayGiaVaccine(TenVacxin);
            return dt;
        }

        public static string LaySoLuongVaccine(string TenVacxin)
        {
            string dt = Vacxin_DB.LaySoLuongVaccine(TenVacxin);
            return dt;
        }



        public static void CapnhatSLDat(string MaVaccine, int SoLuong)
        {
            Vacxin_DB.CapNhatSoLuongDatMua(MaVaccine, SoLuong);
        }


        public static void CapnhatSLTon(string MaVaccine, int SoLuong)
        {
            Vacxin_DB.CapNhatSoLuongTon(MaVaccine, SoLuong);
        }

        public static DataSet LayVacXinCanDatMua()
        {
            DataSet dt = Vacxin_DB.LayDSVaccineCanDatMua();
            return dt;
        }

        public static DataSet KH_LayDSVacXin()
        {
            DataSet dt = Vacxin_DB.KH_GetTDsVacxin();
            return dt;
        }
    }
}
