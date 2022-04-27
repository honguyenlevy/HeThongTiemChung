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
    class ThanNhan_Controller
    {
        public string MaKH;
        public  string HoTen;
        public  string QuanHe;
        public  string SDT;

        public static ThanNhan_Controller TaoMoiThanNhan(string i_MaKH,string i_HoTen, string i_QuanHe, string i_SDT)
        {
            ThanNhan_Controller a = new ThanNhan_Controller();
            a.MaKH = i_MaKH;
            a.HoTen = i_HoTen;
            a.QuanHe = i_QuanHe;
            a.SDT = i_SDT;
            return a;
        }
        public static bool ThemThanNhan(ThanNhan_Controller a)
        {
            

            bool result = ThanNhan_DB.ThemThanNhan(a.MaKH,a.HoTen,a.QuanHe,a.SDT);
           

            return result;
        }
    }
}
