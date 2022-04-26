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
    public partial class KhachHang : Form
    {
        public KhachHang()
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
            this.panelTopKhachHang.Controls.Add(childForm);
            this.panelTopKhachHang.Tag = childForm;
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
            this.panelKhachHang.Controls.Add(childForm);
            this.panelKhachHang.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void labelDangKyTiem_Click(object sender, EventArgs e)
        {
            OpenTopForm(new TopDangKyTiem(), sender);
            OpenChildForm(new KH_DangKyTiem(), sender);
        }

        private void labelDatMua_Click(object sender, EventArgs e)
        {
            OpenTopForm(new TopDatMua(), sender);
            OpenChildForm(new KH_DatMua(), sender);
        }

        private void labelThanhToan_Click(object sender, EventArgs e)
        {
            OpenTopForm(new TopThanhToan(), sender);
            OpenChildForm(new KH_ThanhToan(), sender);
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
