using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongTiemChung.Controller;

namespace HeThongTiemChung
{
    public partial class NhanVienKeToan : Form
    {
        public static string MaKH;
        public NhanVienKeToan()
        {
            InitializeComponent();
        }

        private void radioButtonThanhToanDot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonThanhToanMotLan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSoDienThoaiKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhanVienKeToan_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSoDienThoaiKhachHang.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSoDienThoaiKhachHang.Focus();
                return;
            }

            DataSet KH = KhachHang_Controller.LayThongTinKH(textBoxSoDienThoaiKhachHang.Text);
            if (KH.Tables.Count < 1)
            {
                MessageBox.Show("KHÔNG CÓ KHÁCH HÀNG ");
            }
            else
            {
                MessageBox.Show("TÌM ĐƯỢC KHÁCH HÀNG");

                textBoxTenKhachHang.Text = KH.Tables[0].Rows[0][3].ToString();
                MaKH= KH.Tables[0].Rows[0][0].ToString();

            }
            dataGridViewHoaDon.DataSource = HoaDon_Controller.LayDSHD(KH.Tables[0].Rows[0][5].ToString()).Tables[0];
        }
    }
}
