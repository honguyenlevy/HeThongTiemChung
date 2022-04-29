using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongTiemChung.DataBase;

namespace HeThongTiemChung.Controller
{
    class ChitietPhieuTiem_Controller
    {
        private string MaHoaDon;
        private string MaVaccine;
        private int Gia;
        private int SoLuong;


        public static ChitietPhieuTiem_Controller TaoChiTiet(string MaHD, string MaVaccine, int Gia, int SoLuong)
        {
            ChitietPhieuTiem_Controller ct = new ChitietPhieuTiem_Controller();
            ct.MaHoaDon = MaHD;
            ct.MaVaccine = MaVaccine;
            ct.Gia = Gia;
            ct.SoLuong = SoLuong;

            return ct;
        }

        public static void ThemChiTiet(ChitietPhieuTiem_Controller ct)
        {

            ChitietPhieuTiem_DB.ThemChiTiet(ct.MaHoaDon, ct.MaVaccine, ct.Gia, ct.SoLuong);
        }
    }
}
