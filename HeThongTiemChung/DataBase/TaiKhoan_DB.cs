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
    class TaiKhoan_DB
    {
        public static SqlConnection conn = ConnectData.SqlConnect();

        public static DataSet GetTTTaiKhoan_KH(string SDT)
        {
            string sql = "select count(*) from khachhang where  sodienthoai =" + SDT;

            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);

           
            return data;

        }
        public static DataSet GetTTTaiKhoan_NV(string manv)
        {
            string sql = "select loainhanvien from nhanvien where  manhanvien = '" + manv +"'";
            //string sql = "select loainhanvien from nhanvien where  manhanvien ='nv1'";

            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;

        }

    }
}
