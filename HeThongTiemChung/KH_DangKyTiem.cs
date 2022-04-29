using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HeThongTiemChung.Controller;


namespace HeThongTiemChung
{
    public partial class KH_DangKyTiem : Form
    {
        public KH_DangKyTiem()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxChonGoiVaccine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChonVaccine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonChonGoiVaccine.Checked == true)
            {
                //KhachHang_Controller a = KhachHang_Controller.DangKyTiemGoi(dateTimePickerNgayDangKy.Text, dateTimePickerNgayMuonTiem.Text, comboBoxTrungTam.Text, textBoxDiaChi.Text, comboBoxTenGoiVaccine.Text, textBoxGiaGoiVaccine.Text, textBoxSoLuongTonGoiVaccine.Text, textBoxChonSoLuong.Text);

            }



        }

        private void radioButtonChonGoiVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = GoiVacxin_Controller.LayDSGoiVacXin().Tables[0];

            DataSet dt = GoiVacxin_Controller.LayDSGoiVacXin();

            comboBoxTenGoiVaccine.DataSource = dt.Tables[0];
            comboBoxTenGoiVaccine.DisplayMember = "TENGOI";
            comboBoxTenGoiVaccine.ValueMember = "TENGOI";
            comboBoxTenGoiVaccine.SelectedIndex = -1;
        }

        private void radioButtonChonVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];

            DataSet dt = Vacxin_Controller.LayDSVacXin();

            comboBoxTenVaccine.DataSource = dt.Tables[0];
            comboBoxTenVaccine.DisplayMember = "TENVACXIN";
            comboBoxTenVaccine.ValueMember = "TENVACXIN";
            comboBoxTenVaccine.SelectedIndex = -1;
        }

        private void KH_DangKyTiem_Load(object sender, EventArgs e)
        {
            DataSet dt = TrungTam_Controller.LayThongTinTT();


            comboBoxTrungTam.DataSource = dt.Tables[0];
            comboBoxTrungTam.DisplayMember = "TENTRUNGTAM";
            comboBoxTrungTam.ValueMember = "TENTRUNGTAM";
            comboBoxTrungTam.SelectedIndex = -1;
        }

        private void comboBoxTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDiaChi.Text = TrungTam_Controller.LayDiaChiTrungTam(comboBoxTrungTam.Text);
        }

        private void comboBoxTenGoiVaccine_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxGiaGoiVaccine.Text = GoiVacxin_Controller.LayGiaGoiVaccine(comboBoxTenGoiVaccine.Text);
            textBoxSoLuongTonGoiVaccine.Text = GoiVacxin_Controller.LaySoLuongGoiVaccine(comboBoxTenGoiVaccine.Text);

        }

        private void comboBoxTenVaccine_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxGiaVaccine.Text = Vacxin_Controller.LayGiaVaccine(comboBoxTenVaccine.Text);
            textBoxSoLuongTonVaccine.Text = Vacxin_Controller.LaySoLuongVaccine(comboBoxTenVaccine.Text);
        }

        private void dataGridViewVaccine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
