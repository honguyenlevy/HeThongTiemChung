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
    public partial class KH_ThanhToan_MotLan : Form
    {
        public KH_ThanhToan_MotLan()
        {
            InitializeComponent();
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            if (textBoxTongTien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn hóa đơn để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTongTien.Focus();
                return;
            }

            if (comboBoxTenNganHang.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên ngân hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxTenNganHang.Focus();
                return;
            }

            if (textBoxSoThe.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSoThe.Focus();
                return;
            }

            string MaHd= dataGridViewThongTinHoaDon.CurrentRow.Cells[0].Value != null ? dataGridViewThongTinHoaDon.CurrentRow.Cells[0].Value.ToString() : "";
            HoaDon_Controller.CapNhatTinhTrangHoaDon1Lan(MaHd, "NULL");

            dataGridViewThongTinHoaDon.DataSource = HoaDon_Controller.LayDSHD(DangNhap.SDT).Tables[0];

            HoaDon_Controller.CapNhatSoTienConNo(MaHd, Int32.Parse(textBoxTongTien.Text));

            textBoxTongTien.Text = "";
            comboBoxTenNganHang.Text = "";
            textBoxSoThe.Text = "";

            dataGridViewThongTinHoaDon.DataSource = HoaDon_Controller.LayDSHD(DangNhap.SDT).Tables[0];
        }

        private void dataGridViewThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewThongTinHoaDon.CurrentRow != null && dataGridViewThongTinHoaDon.CurrentRow.Index > -1)
            {
                string value2 = dataGridViewThongTinHoaDon.CurrentRow.Cells[6].Value != null ? dataGridViewThongTinHoaDon.CurrentRow.Cells[6].Value.ToString() : "";
                textBoxTongTien.Text = value2;
            }
        }

        private void KH_ThanhToan_MotLan_Load(object sender, EventArgs e)
        {
            dataGridViewThongTinHoaDon.DataSource = HoaDon_Controller.LayDSHD(DangNhap.SDT).Tables[0];

            comboBoxTenNganHang.DisplayMember = "Text";
            comboBoxTenNganHang.ValueMember = "Value";

            comboBoxTenNganHang.Items.Add(new { Text = "Sacombank", Value = "Sacombank" });
            comboBoxTenNganHang.Items.Add(new { Text = "Agribank", Value = "Agribank" });
            comboBoxTenNganHang.Items.Add(new { Text = "Vietcombank", Value = "Vietcombank" });
            comboBoxTenNganHang.Items.Add(new { Text = "AChaubank", Value = "AChaubank" });


            
        }
    }
}
