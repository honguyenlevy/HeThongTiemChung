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
    class GoiVacxin_DB
    {
        public static SqlConnection conn = ConnectData.SqlConnect();
        public static DataSet GetTDsGoiVacxin()
        {
            string sql = "SELECT * FROM GOITIEM";


            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;

        }

        public static string LayGiaGoiVaccine(string TenGoi)
        {
            string sql = "SELECT GIAGOI FROM GOITIEM WHERE TENGOI = N'" + TenGoi + "'";

            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;

        }

        public static string LaySoLuongGoiVaccine(string TenGoi)
        {
            string sql = "SELECT SOLUONG FROM GOITIEM WHERE TENGOI = N'" + TenGoi + "'";

            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;

        }


        public static void CapNhatSoLuongDat(string Mavaccine, int SoLuong)
        {
            string sql = "update goitiem set SLDat = SLDat + " + SoLuong + " where magoi = '" + Mavaccine + "'";
            
            ConnectData.RunSQL(sql);

        }


        public static void CapNhatSoLuongTon(string Mavaccine, int SoLuong)
        {
            string sql = "update goitiem set Soluong = Soluong - " + SoLuong + " where magoi = '" + Mavaccine + "'";
            MessageBox.Show(sql);
            ConnectData.RunSQL(sql);

        }

        public static DataSet LayGoiVaccineCanDatMua()
        {
            string sql = "select * from goitiem where sldat > 0;";


            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;
        }
    }
}
