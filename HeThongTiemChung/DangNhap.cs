using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Khách hàng
            //OpenChilForm(new KhachHang(), sender);

            //Nhân viên tiếp tân
            //OpenChilForm(new NhanVienTiepTan(), sender);

            //Nhân viên kế toán
            OpenChilForm(new NhanVienKeToan(), sender);

            //Nhân viên quản lý
            //OpenChilForm(new NhanVienQuanLy(), sender);

            //Nhân viên 
            //OpenChilForm(new NhanVien(), sender);

            //Bộ phận quản lý
            //OpenChilForm(new BoPhanQuanLy(), sender);
        }
    }
}
