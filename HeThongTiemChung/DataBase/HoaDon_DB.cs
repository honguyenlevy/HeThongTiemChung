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
    class HoaDon_DB
    {
        public static SqlConnection conn = ConnectData.SqlConnect();
        public static DataSet LayDSHD(string sdt)
        {
            string sql = "SELECT *  FROM HOADON where MAKHACHHANG IN (SELECT MAKHACHHANG from khachhang where sodienthoai = '" + sdt + "')";


            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;
        }

        public static bool ThemHoaDon(string MaHD, string MaKh, string MaNV, int DuNo, string LoaiTT, string NgayLap, int Tongtien)
        {


            string sql = "insert into hoadon values('" + MaHD + "', '" + MaKh + "' , '" + MaNV + " ','" + DuNo + "', '" + LoaiTT + "', '" + NgayLap + "', '" + Tongtien+ "' )";

            ConnectData.RunSQL(sql);
            return true;

        }
    }
}
