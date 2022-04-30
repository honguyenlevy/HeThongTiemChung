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
    public partial class KH_DatMua : Form
    {
        public KH_DatMua()
        {
            InitializeComponent();
        }

        private void radioButtonChonGoiVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = GoiVacxin_Controller.LayDSGoiVacXin().Tables[0];
        }

        private void radioButtonChonVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxSoLuong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSoLuong.Focus();
                return;
            }

            string MaVaccine= dataGridViewVaccine.CurrentRow.Cells[0].Value != null ? dataGridViewVaccine.CurrentRow.Cells[0].Value.ToString() : "";

            if (radioButtonChonVaccine.Checked == true)
            {
                Vacxin_Controller.CapnhatSLDat(MaVaccine, Int32.Parse(textBoxSoLuong.Text));
                dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];
            }
            else
            {
                GoiVacxin_Controller.CapnhatSLDat(MaVaccine, Int32.Parse(textBoxSoLuong.Text));
                

                dataGridViewVaccine.DataSource = GoiVacxin_Controller.LayDSGoiVacXin().Tables[0];
            }

            MessageBox.Show("ĐÃ ĐẶT HÀNG THÀNH CÔNG !");
            textBoxTen.Text = "";
            textBoxSoLuong.Text = "";
          


        }

        private void dataGridViewVaccine_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (radioButtonChonGoiVaccine.Checked == true)
            {
                if (dataGridViewVaccine.CurrentRow != null && dataGridViewVaccine.CurrentRow.Index > -1)
                {
                    string value1 = dataGridViewVaccine.CurrentRow.Cells[3].Value != null ? dataGridViewVaccine.CurrentRow.Cells[3].Value.ToString() : "";
                    textBoxTen.Text = value1;
                }
            }

            else
            {
                if (dataGridViewVaccine.CurrentRow != null && dataGridViewVaccine.CurrentRow.Index > -1)
                {
                    string value1 = dataGridViewVaccine.CurrentRow.Cells[1].Value != null ? dataGridViewVaccine.CurrentRow.Cells[1].Value.ToString() : "";
                    textBoxTen.Text = value1;
                }
            }
        }

        private void KH_DatMua_Load(object sender, EventArgs e)
        {
            radioButtonChonVaccine.Checked = true;
        }
    }
}
