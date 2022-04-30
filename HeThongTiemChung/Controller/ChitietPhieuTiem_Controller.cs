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
        private string MaPhieu;
        private string MaVaccine;
        private int TinhTrang;
        private int SoLuong;


        public static ChitietPhieuTiem_Controller TaoChiTiet(string MaHD, int SoLuong, int TinhTrang, string MaVaccine  )
        {
            ChitietPhieuTiem_Controller ct = new ChitietPhieuTiem_Controller();
            ct.MaPhieu = MaHD;
            ct.MaVaccine = MaVaccine;
            ct.TinhTrang = TinhTrang;
            ct.SoLuong = SoLuong;

            return ct;
        }

        public static void ThemChiTiet(ChitietPhieuTiem_Controller ct)
        {

            ChitietPhieuTiem_DB.ThemChiTiet(ct.MaPhieu, ct.SoLuong,ct.TinhTrang,ct.MaVaccine);
        }
    }
}
