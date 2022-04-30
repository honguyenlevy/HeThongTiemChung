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
    class TrungTam_Controller
    {

        public static DataSet LayThongTinTT()
        {

            DataSet dt = TrungTam_DB.GetThongTinTrungTam();

            return dt;

        }

        public static string LayDiaChiTrungTam(string TenTrungTam)
        {
            string dt = TrungTam_DB.LayDiaChiTrungTam(TenTrungTam);
            return dt;
        }

        public static string LayMaTrungTam(string TenTrungTam)
        {
            string dt = TrungTam_DB.LayMaTrungTam(TenTrungTam);
            return dt;
        }
    }
}
