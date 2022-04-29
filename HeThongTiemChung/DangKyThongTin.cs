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
    public partial class DangKyThongTin : Form
    {
        
        public DangKyThongTin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxLaTreEm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            KhachHang_Controller a = KhachHang_Controller.TaoMoiKH(textBoxMaKH.Text,textBoxHoVaTen.Text, dateTimePickerNgaySinh.Text, comboBoxGioiTinh.Text, textBoxSoDienThoai.Text, textBoxDiaChi.Text);

            bool ok = KhachHang_Controller.ThemKhachHang(a);

            if(checkBoxLaTreEm.Checked==true)
            {
               ThanNhan_Controller  b = ThanNhan_Controller.TaoMoiThanNhan(textBoxMaKH.Text,textBoxHoTenNguoiGiamHo.Text, comboBoxQuanHe.Text, textBoxSoDienThoaiNguoiGiamHo.Text);
                ThanNhan_Controller.ThemThanNhan(b);
            }
        }

        private void DangKyThongTin_Load(object sender, EventArgs e)
        {
            Random MaKH = new Random();
            textBoxMaKH.Text = "KH" + MaKH.Next(00000001, 99999999).ToString();
   


            comboBoxGioiTinh.DisplayMember = "Text";
            comboBoxGioiTinh.ValueMember = "Value";

            comboBoxGioiTinh.Items.Add(new { Text = "Nam", Value = "Nam" });
            comboBoxGioiTinh.Items.Add(new { Text = "Nu", Value = "Nu" });




            comboBoxQuanHe.DisplayMember = "Text";
            comboBoxQuanHe.ValueMember = "Value";

            comboBoxQuanHe.Items.Add(new { Text = "Cha", Value = "Cha" });
            comboBoxQuanHe.Items.Add(new { Text = "Me", Value = "Me" });
            comboBoxQuanHe.Items.Add(new { Text = "Anh", Value = "Anh" });
            comboBoxQuanHe.Items.Add(new { Text = "Chi", Value = "Chi" });
            comboBoxQuanHe.Items.Add(new { Text = "Co", Value = "Co" });
            comboBoxQuanHe.Items.Add(new { Text = "Di", Value = "Di" });
            comboBoxQuanHe.Items.Add(new { Text = "Chu", Value = "Chu" });
            comboBoxQuanHe.Items.Add(new { Text = "Bac", Value = "Bac" });
        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
