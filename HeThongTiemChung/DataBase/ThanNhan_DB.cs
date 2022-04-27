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

    class ThanNhan_DB
    {
        public static SqlConnection conn = ConnectData.SqlConnect();

        public static bool ThemThanNhan(string MaKH,string HoTen, string QuanHe,  string SDT)
        {
            // Nữa làm hàm random mã nè
            string sql = "insert into ThanNhan values('" + MaKH+"', '" + HoTen +  " ','" + QuanHe + "','" + SDT  +"' )";

            ConnectData.RunSQL(sql);

            return true;

        }
    }

}
