using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongTiemChung.DataBase;
namespace HeThongTiemChung.Controller
{
    class ChitietHoaDon_Controller
    {
        private string MaHoaDon;
        private int LanThanhToan;
        private int SoTien;


        public ChitietHoaDon_Controller TaoChitietHoaDon( string MaHoaDon,int LanThanhToan, int SoTien)
        {
            ChitietHoaDon_Controller ct = new ChitietHoaDon_Controller();
            ct.MaHoaDon = MaHoaDon;
            ct.LanThanhToan = LanThanhToan;
            ct.SoTien = SoTien;

            return ct;
        }

        public static void ThemchiTietHoaDon(ChitietHoaDon_Controller ct)
        {
            ChitietHoaDon_DB.ThemChitietHoaDon(ct.MaHoaDon, ct.LanThanhToan, ct.SoTien);

        }
    }
}
