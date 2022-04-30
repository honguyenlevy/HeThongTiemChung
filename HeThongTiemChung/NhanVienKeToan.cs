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

        int SoTienPhaiTra;

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
            if (radioButtonThanhToanMotLan.Checked == true) {
                comboBoxLanThanhToan.Text = "";
                textBoxSoTienPhaiThanhToan.Text = dataGridViewHoaDon.CurrentRow.Cells[7].Value != null ? dataGridViewHoaDon.CurrentRow.Cells[7].Value.ToString() : "";
            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
        
            if (radioButtonThanhToanMotLan.Checked == true)
            {

                string MaHd = dataGridViewHoaDon.CurrentRow.Cells[0].Value != null ? dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString() : "";
                HoaDon_Controller.CapNhatTinhTrangHoaDon1Lan(MaHd, DangNhap.SDT);

                
            }
            

            else {
                
                string MaHd = dataGridViewHoaDon.CurrentRow.Cells[0].Value != null ? dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString() : "";

                ChitietHoaDon_Controller ct = ChitietHoaDon_Controller.TaoChitietHoaDon(MaHd, SoTienPhaiTra);
                ChitietHoaDon_Controller.ThemchiTietHoaDon(ct);

                HoaDon_Controller.CapNhatSoTienConNo(MaHd, SoTienPhaiTra);
            }

            
            dataGridViewHoaDon.DataSource = HoaDon_Controller.LayDSHD(MaKH);
        }

        private void textBoxSoDienThoaiKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhanVienKeToan_Load(object sender, EventArgs e)
        {
            


            //comboBoxTenNganHang.DisplayMember = "Text";
            //comboBoxTenNganHang.ValueMember = "Value";

            //comboBoxTenNganHang.Items.Add(new { Text = "Sacombank", Value = "Sacombank" });
            //comboBoxTenNganHang.Items.Add(new { Text = "Agribank", Value = "Agribank" });
            //comboBoxTenNganHang.Items.Add(new { Text = "Vietcombank", Value = "Vietcombank" });
            //comboBoxTenNganHang.Items.Add(new { Text = "AChaubank", Value = "AChaubank" });



            comboBoxLanThanhToan.DisplayMember = "Text";
            comboBoxLanThanhToan.ValueMember = "Value";

            comboBoxLanThanhToan.Items.Add(new { Text = "1", Value = "1" });
            comboBoxLanThanhToan.Items.Add(new { Text = "2", Value = "2" });
            comboBoxLanThanhToan.Items.Add(new { Text = "3", Value = "3" });
            comboBoxLanThanhToan.Items.Add(new { Text = "4", Value = "4" });
            comboBoxLanThanhToan.Items.Add(new { Text = "5", Value = "5" });

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

        private void comboBoxLanThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoTienPhaiTra = Int32.Parse(textBoxSoTienConNo.Text) / Int32.Parse(comboBoxLanThanhToan.Text);
            string SoTienPhaiTra_Str = "";
            SoTienPhaiTra_Str += SoTienPhaiTra;
            textBoxSoTienPhaiThanhToan.Text = SoTienPhaiTra_Str;
        }

        private void dataGridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewHoaDon.CurrentRow != null && dataGridViewHoaDon.CurrentRow.Index > -1)
            {
                textBoxSoTienConNo.Text = dataGridViewHoaDon.CurrentRow.Cells[7].Value != null ? dataGridViewHoaDon.CurrentRow.Cells[7].Value.ToString() : "";


                textBoxTongSoTien.Text = dataGridViewHoaDon.CurrentRow.Cells[6].Value != null ? dataGridViewHoaDon.CurrentRow.Cells[6].Value.ToString() : "";
            }
        }

        private void radioButtonTienMat_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
