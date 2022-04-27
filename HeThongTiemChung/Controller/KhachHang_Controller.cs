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
    class KhachHang_Controller
    {
        private string MaKH;
        private string HoTen ;
        private string NgaySinh;
        private string GioiTinh;
        private string SDT;
        private string DiaChi;

       
        public static KhachHang_Controller TaoMoiKH(string i_MaKH,string i_HoTen, string i_NgaySinh, string i_GioiTinh, string i_SDT, string i_DiaChi)
        {
          
          
            KhachHang_Controller a = new KhachHang_Controller();
            a.MaKH = i_MaKH;
            a.HoTen = i_HoTen;
            a.NgaySinh = i_NgaySinh;
            a.GioiTinh = i_GioiTinh;
            a.SDT = i_SDT;
            a.DiaChi = i_DiaChi;
            MessageBox.Show(a.HoTen);
            return a;
        }
        public static bool  ThemKhachHang(KhachHang_Controller a)
        {
            
            bool result = KhachHang_DB.ThemKhachHang(a.MaKH,a.HoTen,a.NgaySinh,a.GioiTinh,a.SDT,a.DiaChi);
            return result;

        }

        public static DataSet LayThongTinKH(string SDT)
        {

            DataSet dt = KhachHang_DB.LayThongTinKH(SDT);

            return dt;

        }
    }
}
