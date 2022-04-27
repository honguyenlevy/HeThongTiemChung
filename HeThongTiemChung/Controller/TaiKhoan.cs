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
using   HeThongTiemChung.DataBase;

namespace HeThongTiemChung.Controller
{
    class TaiKhoan
    {
       public static bool KiemTraTaiKhoan_KH(string sdt)
        {
            DataSet data = TaiKhoan_DB.GetTTTaiKhoan_KH(sdt);
            
            string count = data.Tables[0].Rows[0][0].ToString();
          

            bool check = true;
            if (count == "0")
                check = false;
            return check;
        }

        public static string KiemTraTaiKhoan_NV(string sdt)
        {
            DataSet data = TaiKhoan_DB.GetTTTaiKhoan_NV(sdt);
            string Loai = "-1";
            if (data.Tables[0].Rows.Count >0)
            {
                Loai = data.Tables[0].Rows[0][0].ToString();
            }

            return Loai;
        }


    }
}
