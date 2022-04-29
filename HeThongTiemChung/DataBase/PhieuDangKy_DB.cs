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
    class PhieuDangKy_DB
    {
        public static SqlConnection conn = ConnectData.SqlConnect();

        public static bool ThemPhieuDangKy(string MaPhieu,  string NgayDangKy, string NgayMuonTiem, string MaKH, string MaTrungTam)
        {


            string sql = "insert into phieudangkytiem values('" + MaPhieu +  "' , '" + NgayDangKy + " ','" + NgayMuonTiem + "', '" + MaKH + "' , '" + MaTrungTam +"' )";

            ConnectData.RunSQL(sql);
            return true;

        }
    }
}
