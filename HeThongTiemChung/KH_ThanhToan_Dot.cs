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
        public KH_ThanhToan_Dot()
        {
            InitializeComponent();
        }

        private void dataGridViewThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewThongTinHoaDon.CurrentRow != null && dataGridViewThongTinHoaDon.CurrentRow.Index > -1)
            {
                string value1 = dataGridViewThongTinHoaDon.CurrentRow.Cells[0].Value != null ? dataGridViewThongTinHoaDon.CurrentRow.Cells[0].Value.ToString() : "";
                textBoxSoLanThanhToan.Text = value1;

                string value2 = dataGridViewThongTinHoaDon.CurrentRow.Cells[1].Value != null ? dataGridViewThongTinHoaDon.CurrentRow.Cells[1].Value.ToString() : "";
                textBoxTongTien.Text = value2;
            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
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


           
        }

        private void comboBoxLanThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBoxDiaChi.Text = TrungTam_Controller.LayDiaChiTrungTam(comboBoxTrungTam.Text);
        }
    }
}
