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
    }
}
