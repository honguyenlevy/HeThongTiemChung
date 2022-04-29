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
    class Vacxin_DB
    {
        public static SqlConnection conn = ConnectData.SqlConnect();
        public static DataSet GetTDsVacxin()
        {
            string sql = "SELECT TENVACXIN, GIATIEN, SOLUONGTON FROM VACXIN";
            

            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;
        }

        public static string LayGiaVaccine(string TenVacxin)
        {
            string sql = "SELECT GIATIEN FROM VACXIN WHERE TENVACXIN = N'" + TenVacxin + "'";

            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;

        }

        public static string LaySoLuongVaccine(string TenVacxin)
        {
            string sql = "SELECT SOLUONGTON FROM VACXIN WHERE TENVACXIN = N'" + TenVacxin + "'";

            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;

        }
    }
}
