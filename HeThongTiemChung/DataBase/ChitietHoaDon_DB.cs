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

namespace HeThongTiemChung.DataBase
{
    class ChitietHoaDon_DB
    {
        
        public static SqlConnection conn = ConnectData.SqlConnect();

        
        public static bool ThemChitietHoaDon(string MaHoaDon,  int SoTien)
        {


            string sql = "insert into ct_ttdot (MaHoaDon,SoTien) values('" + MaHoaDon +  "' , '" + SoTien + "' )";

            ConnectData.RunSQL(sql);
            return true;

        }


    }
}
