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
    class GoiVacxin_Controller
    {
        public static DataSet LayDSGoiVacXin()
        {
            DataSet dt = GoiVaccxin_DB.GetTDsGoiVacxin();
            return dt;
        }

        public static string LayGiaGoiVaccine(string TenGoi)
        {
            string dt = GoiVaccxin_DB.LayGiaGoiVaccine(TenGoi);
            return dt;
        }

        public static string LaySoLuongGoiVaccine(string TenGoi)
        {
            string dt = GoiVaccxin_DB.LaySoLuongGoiVaccine(TenGoi);
            return dt;
        }
    }
}
