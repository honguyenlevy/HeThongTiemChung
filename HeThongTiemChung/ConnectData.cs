using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HeThongTiemChung
{
    class ConnectData
    {

        public static string SqlConnectionString()
        {

            //return @"Data Source=LAPTOP-TBTQKC84\SQLEXPRESS;Initial Catalog=QUANLITIEMCHUNG;Integrated Security=True";
            //return @"Data Source=LAPTOP-TBTQKC84\SQLEXPRESS;Initial Catalog=QLTIEMCHUNG;Integrated Security=True";
            return @"Data Source=HONGUYENLEVY;Initial Catalog=QLTIEMCHUNG;Integrated Security=True";
        }
        public static SqlConnection SqlConnect()
        {
               SqlConnection connection = new SqlConnection(SqlConnectionString());
           
                connection.Open();
                
              
              return connection;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = SqlConnect(); //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

    }
}
