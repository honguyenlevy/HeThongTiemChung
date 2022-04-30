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
   
    class ChitietPhieuTiem_DB
    {
        public static SqlConnection conn = ConnectData.SqlConnect();

        public static bool ThemChiTiet(string MaPhieu,  int SoLuong, int TinhTrang ,string MaVaccine)
        {
            

            string sql = "insert into chitietdangky values('" + MaPhieu + "', '" + SoLuong + "' , '" + TinhTrang + " ','" + MaVaccine  + "' )";

            ConnectData.RunSQL(sql);
            return true;

        }
    }
}
