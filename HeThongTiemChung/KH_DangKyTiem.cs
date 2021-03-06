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
            if (comboBoxTrungTam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn trung tâm tiêm chủng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxTrungTam.Focus();
                return;
            }

            if (radioButtonChonGoiVaccine.Checked== true)
            {
                if (textBoxChonSoLuong.Text.Length > textBoxSoLuongTonGoiVaccine.Text.Length)
                {
                    MessageBox.Show("Số lượng bạn nhập lớn hơn số lượng tồn vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxChonSoLuong.Focus();
                    return;
                }
            }
            else
            {
                if (textBoxChonSoLuong.Text.Length > textBoxGiaVaccine.Text.Length)
                {
                    MessageBox.Show("Số lượng bạn nhập lớn hơn số lượng tồn vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxChonSoLuong.Focus();
                    return;
                }
            }

            Random Ma = new Random();
            string MaPDK = "DK" + Ma.Next(00000001, 99999999).ToString();

            //PhieuDangKy_Controller pdk = PhieuDangKy_Controller.TaoPhieuDangKy(MaPDK, "MaKH", dateTimePickerNgayDangKy.Text, dateTimePickerNgayMuonTiem.Text, comboBoxTrungTam.Text);

            string MaKH = KhachHang_Controller.LayMaKH(DangNhap.SDT);

            string MaTT = TrungTam_Controller.LayMaTrungTam(comboBoxTrungTam.Text);
            
            PhieuDangKy_Controller pdk = PhieuDangKy_Controller.TaoPhieuDangKy(MaPDK, MaKH, dateTimePickerNgayDangKy.Text, dateTimePickerNgayMuonTiem.Text, MaTT);
            PhieuDangKy_Controller.ThemPhieuDangKy(pdk);

            string MaVaccine = dataGridViewVaccine.CurrentRow.Cells[0].Value != null ? dataGridViewVaccine.CurrentRow.Cells[0].Value.ToString() : "";

            string Gia = textBoxGiaVaccine.Text;

            int SoLuong = Int32.Parse(textBoxChonSoLuong.Text);

            if (radioButtonChonGoiVaccine.Checked == true) {
              
                Gia = textBoxGiaGoiVaccine.Text;

                GoiVacxin_Controller.CapnhatSLTon(MaVaccine, SoLuong);
            }

            else
            {
                Vacxin_Controller.CapnhatSLTon(MaVaccine, SoLuong);
            }
            
            
            //ChitietPhieuTiem_Controller ct = ChitietPhieuTiem_Controller.TaoChiTiet(MaPDK, MaVaccine, Int32.Parse(Gia), SoLuong);

            //ChitietPhieuTiem_Controller.ThemChiTiet(ct);

            Ma = new Random();
            string MaHD = "HD" + Ma.Next(00000001, 99999999).ToString();
            MessageBox.Show(textBoxChonSoLuong.Text);
            MessageBox.Show(Gia);

            int tongtien = Int32.Parse(textBoxChonSoLuong.Text) * Int32.Parse(Gia);

            HoaDon_Controller hd = HoaDon_Controller.TaoHoaDon(MaHD, MaKH, "NULL", 0, dateTimePickerNgayDangKy.Text, "Mot Lan", tongtien,tongtien,"0");
            HoaDon_Controller.ThemHoaDon(hd);

            textBoxGiaVaccine.Text = "";
            textBoxTenVaccine.Text = "";
            textBoxSoLuongTonVaccine.Text = "";

            textBoxGiaGoiVaccine.Text = "";
            textBoxTenGoiVaccine.Text = "";
            textBoxSoLuongTonGoiVaccine.Text = "";

            radioButtonChonVaccine.Checked = true;
            dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];
        }

        private void radioButtonChonGoiVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = GoiVacxin_Controller.LayDSGoiVacXin().Tables[0];
                        

            textBoxGiaVaccine.Text = "";

            textBoxTenVaccine.Text = "";

            textBoxSoLuongTonVaccine.Text = "";
        }

        private void radioButtonChonVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];
                       

            textBoxGiaGoiVaccine.Text =  "";

            textBoxTenGoiVaccine.Text =  "";

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

                    textBoxTenGoiVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[3].Value != null ? dataGridViewVaccine.CurrentRow.Cells[3].Value.ToString() : "";

                    textBoxSoLuongTonGoiVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[2].Value != null ? dataGridViewVaccine.CurrentRow.Cells[2].Value.ToString() : "";

                }
            }
            else
            {
                if (dataGridViewVaccine.CurrentRow != null && dataGridViewVaccine.CurrentRow.Index > -1)
                {
                    textBoxGiaVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[2].Value != null ? dataGridViewVaccine.CurrentRow.Cells[2].Value.ToString() : "";

                    textBoxTenVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[1].Value != null ? dataGridViewVaccine.CurrentRow.Cells[1].Value.ToString() : "";

                    textBoxSoLuongTonVaccine.Text = dataGridViewVaccine.CurrentRow.Cells[3].Value != null ? dataGridViewVaccine.CurrentRow.Cells[3].Value.ToString() : "";

                }

            }



        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
