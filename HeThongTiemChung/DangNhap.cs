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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void OpenChilForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDangNhap.Controls.Add(childForm);
            this.panelDangNhap.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void buttonDangKyThongTin_Click(object sender, EventArgs e)
        {

        }


        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

            if (textBoxSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập SDT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSDT.Focus();
                return;
            }
            if (textBoxMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMatKhau.Focus();
                return;
            }

            string check = textBoxSDT.Text.Substring(0, 1);
            

            if (check == "0")
            {
                bool ok = TaiKhoan.KiemTraTaiKhoan_KH(textBoxSDT.Text);

                if (!ok)
                {
                    MessageBox.Show("Sai");
                }
                else
                {
                   
                    OpenChilForm(new KhachHang(), sender);
                }
            }

            else
            {
                

                //Nhân viên tiếp tân 1
                string Loai = TaiKhoan.KiemTraTaiKhoan_NV(textBoxSDT.Text);


                if (Loai == "-1")
                {
                    MessageBox.Show("SAI TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU");
                }
                
                if (Loai.Substring(0, 1) == "1")
                {
                    OpenChilForm(new NhanVienTiepTan(), sender);
                }
                else if (Loai.Substring(0, 1) == "2")
                {
                    //Nhân viên kế toán 2
                    OpenChilForm(new NhanVienKeToan(), sender);
                }

                //Nhân viên quản lý 3
                else if (Loai.Substring(0, 1) == "3")
                {
                    //Nhân viên kế toán 2
                    OpenChilForm(new NhanVienQuanLy(), sender);
                }

                else if (Loai.Substring(0, 1) == "0")
                {
                    //Nhân viên0
                    OpenChilForm(new NhanVien(), sender);
                }

                else if (Loai.Substring(0, 1) == "4")
                {
                    //QUanr ly
                    OpenChilForm(new BoPhanQuanLy(), sender);
                }
            }

        }
    }
}


