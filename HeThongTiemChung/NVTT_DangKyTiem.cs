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
    public partial class NVTT_DangKyTiem : Form
    {
        public NVTT_DangKyTiem()
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

        }

        private void NVTT_DangKyTiem_Load(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];

            DataSet dt = TrungTam_Controller.LayThongTinTT();


            comboBoxTrungTam.DataSource = dt.Tables[0];
            comboBoxTrungTam.DisplayMember = "MATRUNGTAM";
            comboBoxTrungTam.ValueMember = "MATRUNGTAM";
            comboBoxTrungTam.SelectedIndex = -1;

        }

        private void dataGridViewVaccine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButtonChonGoiVaccine.Checked == true)
            {
                if (dataGridViewVaccine.CurrentRow != null && dataGridViewVaccine.CurrentRow.Index > -1)
                {
                    textBoxTenGoi.Text = dataGridViewVaccine.CurrentRow.Cells[3].Value != null ? dataGridViewVaccine.CurrentRow.Cells[3].Value.ToString() : "";
                    textBoxGiaGoiVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[1].Value != null ? dataGridViewVaccine.CurrentRow.Cells[1].Value.ToString() : "";
                    textBoxSoLuongTonGoiVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[2].Value != null ? dataGridViewVaccine.CurrentRow.Cells[2].Value.ToString() : "";

                    textBoxTenVacxin.Text = "";
                    textBoxGiaVaccine.Text = "";
                    textBoxSoLuongTonVaccine.Text = "";
                }
            }
            else
            {
                
                    if (dataGridViewVaccine.CurrentRow != null && dataGridViewVaccine.CurrentRow.Index > -1)
                    {
                        textBoxTenVacxin.Text = dataGridViewVaccine.CurrentRow.Cells[1].Value != null ? dataGridViewVaccine.CurrentRow.Cells[1].Value.ToString() : "";
                        textBoxGiaVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[2].Value != null ? dataGridViewVaccine.CurrentRow.Cells[2].Value.ToString() : "";
                        textBoxSoLuongTonVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[3].Value != null ? dataGridViewVaccine.CurrentRow.Cells[3].Value.ToString() : "";

                    textBoxTenGoi.Text = "";
                    textBoxGiaGoiVaccine.Text="";
                    textBoxSoLuongTonGoiVaccine.Text = "";
                    }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet KH = KhachHang_Controller.LayThongTinKH(textBoxSoDienThoaiKhachHang.Text);
            if (KH.Tables.Count < 1)
            {
                MessageBox.Show("KHÔNG CÓ KHÁCH HÀNG ");
            }
            else
            {
                MessageBox.Show("Co khach");
                textBoxTenKhachHang.Text = KH.Tables[0].Rows[0][3].ToString();
                textBoxDiaChi.Text = KH.Tables[0].Rows[0][1].ToString();
            }
        }
    }
}
