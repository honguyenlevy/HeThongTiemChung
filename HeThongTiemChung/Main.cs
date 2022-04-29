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
    public partial class Main : Form
    {
        public static DangNhap f1 ;

        public Main()
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
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //OpenChilForm(new DangNhap(), sender);
        }

        private void labelDangNhap_Click(object sender, EventArgs e)
        {
            f1 = new DangNhap();

            OpenChilForm(f1, sender);
           
        }

        private void labelDangKy_Click(object sender, EventArgs e)
        {
            OpenChilForm(new DangKyThongTin(), sender);
        }

        private void labelDangXuat_Click(object sender, EventArgs e)
        {
            OpenChilForm(new DangNhap(), sender);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
