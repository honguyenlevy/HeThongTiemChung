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
            if (radioButtonChonGoiVaccine.Checked == true)
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

            

            string MaKH = KhachHang_Controller.LayMaKH(textBoxSoDienThoaiKhachHang.Text);

            string MaTT = TrungTam_Controller.LayMaTrungTam(comboBoxTrungTam.Text);

            PhieuDangKy_Controller pdk = PhieuDangKy_Controller.TaoPhieuDangKy(MaPDK, MaKH, dateTimePickerNgayDangKy.Text, dateTimePickerNgayMuonTiem.Text, MaTT);
            PhieuDangKy_Controller.ThemPhieuDangKy(pdk);

            string MaVaccine =  dataGridViewVaccine.CurrentRow.Cells[0].Value != null ? dataGridViewVaccine.CurrentRow.Cells[0].Value.ToString() : "";

            string Gia = textBoxGiaVaccine.Text;

            int SoLuong = Int32.Parse(textBoxChonSoLuong.Text);

            if (radioButtonChonGoiVaccine.Checked == true)
            {

                Gia = textBoxGiaGoiVaccine.Text;

                GoiVacxin_Controller.CapnhatSLTon(MaVaccine, SoLuong);
            }

            else
            {
                Vacxin_Controller.CapnhatSLTon(MaVaccine, SoLuong);
            }


            ChitietPhieuTiem_Controller ct = ChitietPhieuTiem_Controller.TaoChiTiet(MaPDK, SoLuong, 0, MaVaccine);

            ChitietPhieuTiem_Controller.ThemChiTiet(ct);

            Ma = new Random();
            string MaHD = "HD" + Ma.Next(00000001, 99999999).ToString();
            MessageBox.Show(textBoxChonSoLuong.Text);
            MessageBox.Show(Gia);

            int tongtien = Int32.Parse(textBoxChonSoLuong.Text) * Int32.Parse(Gia);

            HoaDon_Controller hd = HoaDon_Controller.TaoHoaDon(MaHD, MaKH, "NULL", 0, dateTimePickerNgayDangKy.Text, "Mot Lan", tongtien, tongtien, "0");
            HoaDon_Controller.ThemHoaDon(hd);



            if (radioButtonChonGoiVaccine.Checked == true)
            {
                dataGridViewVaccine.DataSource = GoiVacxin_Controller.LayDSGoiVacXin().Tables[0];
            }

            else
            {
                dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];
            }

        }

        private void NVTT_DangKyTiem_Load(object sender, EventArgs e)
        {
            //dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];

            DataSet dt = TrungTam_Controller.LayThongTinTT();

            radioButtonChonVaccine.Checked = true;

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

        private void comboBoxTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
