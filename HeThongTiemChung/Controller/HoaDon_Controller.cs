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
using HeThongTiemChung.DataBase;


namespace HeThongTiemChung.Controller
{
    class HoaDon_Controller
    {
        public static DataSet LayDSHD()
        {
            DataSet dt = HoaDon_DB.LayDSHD();
            return dt;
        }
    }
}
