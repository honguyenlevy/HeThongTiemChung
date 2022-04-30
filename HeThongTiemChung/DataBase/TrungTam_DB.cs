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
    class TrungTam_DB
    {
        public static SqlConnection conn = ConnectData.SqlConnect();
        public static DataSet GetThongTinTrungTam()
        {
            string sql = "select * from trungtam";


            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;

        }
        

        public static string LayDiaChiTrungTam(string TenTrungTam)
        {
            string sql = "SELECT DIACHI FROM TRUNGTAM WHERE TENTRUNGTAM = N'"+TenTrungTam+"'";
            
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;

        }


        public static string LayMaTrungTam(string TenTrungTam)
        {
            string sql = "SELECT MATRUNGTAM FROM TRUNGTAM WHERE TENTRUNGTAM = N'" + TenTrungTam + "'";

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
