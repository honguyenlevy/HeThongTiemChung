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
    public partial class NhanVienQuanLy : Form
    {
        public NhanVienQuanLy()
        {
            InitializeComponent();
        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            int SoLuong = Int32.Parse(textBoxSoLuong.Text);
            DatMua_Controller d = DatMua_Controller.TaoDatMua(textBoxMaDon.Text, -SoLuong);
            DatMua_Controller.CapNhatDatMua(d);
        }

        private void dataGridViewDonDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDonDat.CurrentRow != null && dataGridViewDonDat.CurrentRow.Index > -1)
            {
                textBoxMaDon.Text = dataGridViewDonDat.CurrentRow.Cells[1].Value != null ? dataGridViewDonDat.CurrentRow.Cells[1].Value.ToString() : "";
                textBoxSoLuong.Text = dataGridViewDonDat.CurrentRow.Cells[2].Value != null ? dataGridViewDonDat.CurrentRow.Cells[2].Value.ToString() : "";



            }
        }

        private void NhanVienQuanLy_Load(object sender, EventArgs e)
        {
            dataGridViewDonDat.DataSource = DatMua_Controller.LayDsDatMua().Tables[0];
        }
    }
}
