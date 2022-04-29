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

        }

        private void dataGridViewThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
