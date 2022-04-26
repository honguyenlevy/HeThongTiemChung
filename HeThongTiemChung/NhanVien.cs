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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private Form activeForm;
        private Form activeForm1;

        private void OpenTopForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelTopNhanVienTiepTan.Controls.Add(childForm);
            this.panelTopNhanVienTiepTan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm1 != null)
            {
                activeForm1.Close();
            }
            activeForm1 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelNhanVien.Controls.Add(childForm);
            this.panelNhanVien.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void labelDangKyLichRanh_Click(object sender, EventArgs e)
        {
            OpenTopForm(new TopDangKyLichRanh(), sender);
            OpenChildForm(new NV_DangKyLichRanh(), sender);
        }

        private void labelXemLichLamViec_Click(object sender, EventArgs e)
        {
            OpenTopForm(new TopXemLichLamViec(), sender);
            OpenChildForm(new NV_XemLichLamViec(), sender);
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
