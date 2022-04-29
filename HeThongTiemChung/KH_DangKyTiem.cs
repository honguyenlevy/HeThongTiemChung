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

            Random Ma = new Random();
            string MaPDK = "DK" + Ma.Next(00000001, 99999999).ToString();
            PhieuDangKy_Controller pdk = PhieuDangKy_Controller.TaoPhieuDangKy(MaPDK, "MaKH", dateTimePickerNgayDangKy.Text, dateTimePickerNgayMuonTiem.Text, comboBoxTrungTam.Text);

            PhieuDangKy_Controller.ThemPhieuDangKy(pdk);

            string MaVaccine = comboBoxTenGoiVaccine.Text;
            string Gia = textBoxGiaGoiVaccine.Text;

            if (radioButtonChonGoiVaccine.Checked == true) {
                MaVaccine = comboBoxTenGoiVaccine.Text;
                Gia = textBoxGiaVaccine.Text;

              

            }
            int SoLuong = Int32.Parse(textBoxChonSoLuong.Text);
            
            ChitietPhieuTiem_Controller ct = ChitietPhieuTiem_Controller.TaoChiTiet(MaPDK, MaVaccine, Int32.Parse(Gia), SoLuong);

            ChitietPhieuTiem_Controller.ThemChiTiet(ct);

            Ma = new Random();
            string MaHD = "HD" + Ma.Next(00000001, 99999999).ToString();

            int tongtien = Int32.Parse(textBoxChonSoLuong.Text) * Int32.Parse(Gia);

            HoaDon_Controller hd = HoaDon_Controller.TaoHoaDon(MaHD, "MaKH", "NULL", 0, "Mot Lan", dateTimePickerNgayDangKy.Text, tongtien);
            HoaDon_Controller.ThemHoaDon(hd);




        }

        private void radioButtonChonGoiVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = GoiVacxin_Controller.LayDSGoiVacXin().Tables[0];

            DataSet dt = GoiVacxin_Controller.LayDSGoiVacXin();

            comboBoxTenGoiVaccine.DataSource = dt.Tables[0];
            comboBoxTenGoiVaccine.DisplayMember = "TENGOI";
            comboBoxTenGoiVaccine.ValueMember = "TENGOI";
            comboBoxTenGoiVaccine.SelectedIndex = -1;

            textBoxGiaVaccine.Text = "";

            comboBoxTenVaccine.Text = "";

            textBoxSoLuongTonVaccine.Text = "";
        }

        private void radioButtonChonVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];

            DataSet dt = Vacxin_Controller.LayDSVacXin();

            comboBoxTenVaccine.DataSource = dt.Tables[0];
            comboBoxTenVaccine.DisplayMember = "TENVACXIN";
            comboBoxTenVaccine.ValueMember = "TENVACXIN";
            comboBoxTenVaccine.SelectedIndex = -1;


            textBoxGiaGoiVaccine.Text =  "";

            comboBoxTenGoiVaccine.Text =  "";

            textBoxSoLuongTonGoiVaccine.Text = "";

        }

        private void KH_DangKyTiem_Load(object sender, EventArgs e)
        {

           

            radioButtonChonVaccine.Checked = true;



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
            //textBoxGiaGoiVaccine.Text = GoiVacxin_Controller.LayGiaGoiVaccine(comboBoxTenGoiVaccine.Text);
            //textBoxSoLuongTonGoiVaccine.Text = GoiVacxin_Controller.LaySoLuongGoiVaccine(comboBoxTenGoiVaccine.Text);

        }

        private void comboBoxTenVaccine_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBoxGiaVaccine.Text = Vacxin_Controller.LayGiaVaccine(comboBoxTenVaccine.Text);
            //textBoxSoLuongTonVaccine.Text = Vacxin_Controller.LaySoLuongVaccine(comboBoxTenVaccine.Text);
        }

        private void dataGridViewVaccine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButtonChonGoiVaccine.Checked == true)
            {
                if (dataGridViewVaccine.CurrentRow != null && dataGridViewVaccine.CurrentRow.Index > -1)
                {
                    textBoxGiaGoiVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[1].Value != null ? dataGridViewVaccine.CurrentRow.Cells[1].Value.ToString() : "";

                    comboBoxTenGoiVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[3].Value != null ? dataGridViewVaccine.CurrentRow.Cells[3].Value.ToString() : "";

                    textBoxSoLuongTonGoiVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[2].Value != null ? dataGridViewVaccine.CurrentRow.Cells[2].Value.ToString() : "";

                }
            }
            else
            {
                if (dataGridViewVaccine.CurrentRow != null && dataGridViewVaccine.CurrentRow.Index > -1)
                {
                    textBoxGiaVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[2].Value != null ? dataGridViewVaccine.CurrentRow.Cells[2].Value.ToString() : "";

                    comboBoxTenVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[1].Value != null ? dataGridViewVaccine.CurrentRow.Cells[1].Value.ToString() : "";

                    textBoxSoLuongTonVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[3].Value != null ? dataGridViewVaccine.CurrentRow.Cells[3].Value.ToString() : "";

                }

            }



        }
    }
}
