﻿using System;
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
        public static DataSet LayDSHD()
        {
            string sql = "SELECT FROM HOADON";


            DataSet data = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(data);


            return data;
        }
    }
}