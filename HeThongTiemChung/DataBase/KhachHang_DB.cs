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
   
    class KhachHang_DB
    {
        public static SqlConnection conn = ConnectData.SqlConnect();

        public static  bool ThemKhachHang(string MaKH,string HoTen,  string NgaySinh,string GioiTinh, string SDT , string DiaChi )
        {
            // Làm hàm random mã nè ( thay cho số 4)

            string sql = "insert into khachhang values('" +MaKH +"', '" + DiaChi + "' , '" + GioiTinh +" ','" + HoTen + "','" + NgaySinh +"','" + SDT +"' )";

            ConnectData.RunSQL(sql);
            return true;

        }
        public static DataSet LayThongTinKH(string SDT)
        {
            string sql = "select * from khachhang where sodienthoai = '" + SDT +"'";


            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;
        }
    }
}
