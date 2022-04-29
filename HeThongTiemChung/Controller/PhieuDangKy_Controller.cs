using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongTiemChung.DataBase;


namespace HeThongTiemChung.Controller
{
    class PhieuDangKy_Controller
    {
        private string MaPhieu;
        
        private string NgayDangKy;
        private string NgayMuonTiem;
        private string MaKH;
        private string MaTrungTam;


        public static PhieuDangKy_Controller TaoPhieuDangKy(string MaPhieu,string MaKH, string NgayDangKy,string NgayMuonTiem, string MaTrungTam)
        {
            PhieuDangKy_Controller pdk = new PhieuDangKy_Controller();
            pdk.MaPhieu = MaPhieu;
            pdk.MaKH = MaKH;
            pdk.NgayDangKy = NgayDangKy;
            pdk.NgayMuonTiem = NgayMuonTiem;
            pdk.MaTrungTam = MaTrungTam;

            return pdk;
        }

        public static void ThemPhieuDangKy(PhieuDangKy_Controller pdk)
        {
            PhieuDangKy_DB.ThemPhieuDangKy(pdk.MaPhieu,  pdk.NgayDangKy,pdk.NgayMuonTiem, pdk.MaKH, pdk.MaTrungTam);
        }
    }
}
