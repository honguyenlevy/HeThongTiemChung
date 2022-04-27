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
            string sql = "select * from vacxin";
            

            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;

        }
    }
}
