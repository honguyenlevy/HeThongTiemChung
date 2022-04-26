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
    public partial class NhanVienTiepTan : Form
    {
        public NhanVienTiepTan()
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
            this.panelNhanVienTiepTan.Controls.Add(childForm);
            this.panelNhanVienTiepTan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void labelDangKyTiem_Click(object sender, EventArgs e)
        {
            OpenTopForm(new TopDangKyTiem(), sender);
            OpenChildForm(new NVTT_DangKyTiem(), sender);
        }

        private void labelDatMua_Click(object sender, EventArgs e)
        {
            OpenTopForm(new TopDatMua(), sender);
            OpenChildForm(new NVTT_DatMua(), sender);
        }

        private void NhanVienTiepTan_Load(object sender, EventArgs e)
        {

        }
    }
}
