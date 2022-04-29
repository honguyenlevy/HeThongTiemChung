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
            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {

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
    }
}
