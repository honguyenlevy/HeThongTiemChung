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
    public partial class KH_ThanhToan_Dot : Form
    {

        int SoTienPhaiTra;

        public KH_ThanhToan_Dot()
        {
            InitializeComponent();
        }

        private void dataGridViewThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewThongTinHoaDon.CurrentRow != null && dataGridViewThongTinHoaDon.CurrentRow.Index > -1)
            {
                textBoxSoTienConNo.Text= dataGridViewThongTinHoaDon.CurrentRow.Cells[7].Value != null ? dataGridViewThongTinHoaDon.CurrentRow.Cells[7].Value.ToString() : "";
               

                textBoxTongTien.Text = dataGridViewThongTinHoaDon.CurrentRow.Cells[6].Value != null ? dataGridViewThongTinHoaDon.CurrentRow.Cells[6].Value.ToString() : "";

               
                
            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            if (textBoxSoTienConNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn hóa đơn để biết số tiền còn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSoTienConNo.Focus();
                return;
            }

            if (comboBoxLanThanhToan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn số lần thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxLanThanhToan.Focus();
                return;
            }

            if (comboBoxTenNganHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên ngân hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxTenNganHang.Focus();
                return;
            }

            if (textBoxSoThe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSoThe.Focus();
                return;
            }

            if (textBoxOTP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập OTP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxOTP.Focus();
                return;
            }

            string MaHd= dataGridViewThongTinHoaDon.CurrentRow.Cells[0].Value != null ? dataGridViewThongTinHoaDon.CurrentRow.Cells[0].Value.ToString() : "";

            ChitietHoaDon_Controller ct = ChitietHoaDon_Controller.TaoChitietHoaDon(MaHd, SoTienPhaiTra);
            ChitietHoaDon_Controller.ThemchiTietHoaDon(ct);

            HoaDon_Controller.CapNhatSoTienConNo(MaHd, SoTienPhaiTra);

            textBoxSoTienConNo.Text = "";
            textBoxTongTien.Text = "";
            comboBoxLanThanhToan.Text = "";
            textBoxSoTienCanThanhToan.Text = "";
            comboBoxTenNganHang.Text = "";
            textBoxSoThe.Text = "";
            textBoxOTP.Text = "";

            dataGridViewThongTinHoaDon.DataSource = HoaDon_Controller.LayDSHD(DangNhap.SDT).Tables[0];
        }

        private void KH_ThanhToan_Dot_Load(object sender, EventArgs e)
        {
            dataGridViewThongTinHoaDon.DataSource = HoaDon_Controller.LayDSHD(DangNhap.SDT).Tables[0];


            comboBoxTenNganHang.DisplayMember = "Text";
            comboBoxTenNganHang.ValueMember = "Value";

            comboBoxTenNganHang.Items.Add(new { Text = "Sacombank", Value = "Sacombank" });
            comboBoxTenNganHang.Items.Add(new { Text = "Agribank", Value = "Agribank" });
            comboBoxTenNganHang.Items.Add(new { Text = "Vietcombank", Value = "Vietcombank" });
            comboBoxTenNganHang.Items.Add(new { Text = "AChaubank", Value = "AChaubank" });



            comboBoxLanThanhToan.DisplayMember = "Text";
            comboBoxLanThanhToan.ValueMember = "Value";

            comboBoxLanThanhToan.Items.Add(new { Text = "1", Value = "1" });
            comboBoxLanThanhToan.Items.Add(new { Text = "2", Value = "2" });
            comboBoxLanThanhToan.Items.Add(new { Text = "3", Value = "3" });
            comboBoxLanThanhToan.Items.Add(new { Text = "4", Value = "4" });
            comboBoxLanThanhToan.Items.Add(new { Text = "5", Value = "5" });


        }

        private void comboBoxLanThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoTienPhaiTra = Int32.Parse(textBoxSoTienConNo.Text) / Int32.Parse(comboBoxLanThanhToan.Text);
            string SoTienPhaiTra_Str = "";
            SoTienPhaiTra_Str += SoTienPhaiTra;
            textBoxSoTienCanThanhToan.Text = SoTienPhaiTra_Str;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
