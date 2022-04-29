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
    class DatMua_DB
    {

        public static SqlConnection conn = ConnectData.SqlConnect();

        public static bool CapNhatDatMua(string MaVaccine, int SoLuong)
        {


            string sql = "update datmua set soluong = soluong + " + SoLuong + " where mavaccine = '" + MaVaccine + "'";

            ConnectData.RunSQL(sql);
            return true;

        }


        public static DataSet LayDSHD(string sdt)
        {
            DataSet dt = HoaDon_DB.LayDSHD(sdt);
            return dt;
        }


        public static DataSet LayDsDatMua()
        {
            string sql = "SELECT *  from datmua where soluong >0";


            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;
        }
    }
}
