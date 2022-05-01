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
        private string MaHoaDon;
        private string MaKhachHang;
        private string MaNhanVien;
        private int DuNo;
        private string LoaiThanhToan;
        private string NgayLap;
        private int TongTien;
        private int SoTienConNo;
        private string TinhTrang;

       public static  HoaDon_Controller TaoHoaDon(string MaHD,string MaKh,string MaNV, int DuNo, string LoaiTT, string NgayLap,int Tongtien ,int SoTienConNo, string TinhTrang)
        {
            HoaDon_Controller hd = new HoaDon_Controller();
            hd.MaHoaDon = MaHD;
            hd.MaKhachHang = MaKh;
            hd.MaNhanVien = MaNV;
            hd.DuNo = DuNo;
            hd.LoaiThanhToan = LoaiTT;
            hd.NgayLap = NgayLap;
            hd.TongTien = Tongtien;
            hd.SoTienConNo = SoTienConNo;
            hd.TinhTrang = TinhTrang;

            return hd;

        }

        public static void ThemHoaDon(HoaDon_Controller Hd)
        {
            HoaDon_DB.ThemHoaDon(Hd.MaHoaDon, Hd.MaKhachHang, Hd.MaNhanVien, Hd.DuNo, Hd.LoaiThanhToan, Hd.NgayLap, Hd.TongTien,Hd.SoTienConNo,Hd.TinhTrang);
        }

        public static DataSet LayDSHD(string sdt)
        {
            DataSet dt = HoaDon_DB.LayDSHD( sdt );
            return dt;
        }


        public static void CapNhatTinhTrangHoaDon1Lan(string MaHD, string MaNV)
        {
            HoaDon_DB.CapNhatTinhTrangHoaDon(MaHD, MaNV);
        }

        public static void CapNhatSoTienConNo(string MaHD, int SoTien)
        {
            HoaDon_DB.CapNhatSoTienConNo(MaHD, SoTien);
        }
    }
}
