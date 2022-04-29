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
    public partial class KH_ThanhToan : Form
    {
        public KH_ThanhToan()
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
            this.panelThanhToan.Controls.Add(childForm);
            this.panelThanhToan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void radioButtonThanhToanDot_CheckedChanged(object sender, EventArgs e)
        {
            OpenChilForm(new KH_ThanhToan_Dot(), sender);

        }

        private void radioButtonThanhToanMotLan_CheckedChanged(object sender, EventArgs e)
        {
            OpenChilForm(new KH_ThanhToan_MotLan(), sender);
        }

        private void KH_ThanhToan_Load(object sender, EventArgs e)
        {
            radioButtonThanhToanMotLan.Checked = true;


        }
    }
}
