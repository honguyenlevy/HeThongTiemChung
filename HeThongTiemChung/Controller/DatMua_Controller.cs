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
    class DatMua_Controller
    {
        private string MaVaccine;
        int SoLuong;

        public static DatMua_Controller TaoDatMua(string MaVaccine , int SoLuong)
        {
            DatMua_Controller d = new DatMua_Controller();
            d.MaVaccine = MaVaccine;
            d.SoLuong = SoLuong;
            return d;
        }

        public static void CapNhatDatMua(DatMua_Controller d)
        {
            DatMua_DB.CapNhatDatMua(d.MaVaccine, d.SoLuong);
        }

        public static DataSet LayDsDatMua()
        {
            DataSet dt = DatMua_DB.LayDsDatMua();
            return dt;
        }
    }
}
