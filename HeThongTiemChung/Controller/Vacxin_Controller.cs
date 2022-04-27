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
    class Vacxin_Controller
    {
        

        public static DataSet LayDSVacXin()
        {
            DataSet dt = Vacxin_DB.GetTDsVacxin();
            return dt;
        }
    }
}
