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
    public partial class NhanVienQuanLy : Form
    {
        public NhanVienQuanLy()
        {
            InitializeComponent();
        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            
            //DatMua_Controller d = DatMua_Controlle
            //TaoDatMua(textBoxMaDon.Text, -SoLuong);
            //DatMua_Controller.CapNhatDatMua(d);
             int SoLuong = Int32.Parse(textBoxSoLuong.Text);
            string Ma= dataGridViewDonDat.CurrentRow.Cells[0].Value != null ? dataGridViewDonDat.CurrentRow.Cells[0].Value.ToString() : "";
            if (radioButtonVaccine.Checked == true)
            {
                Vacxin_Controller.CapnhatSLDat(Ma, -SoLuong);
                dataGridViewDonDat.DataSource = Vacxin_Controller.LayVacXinCanDatMua().Tables[0];
            }
            else
            {
                GoiVacxin_Controller.CapnhatSLDat(Ma, -SoLuong);
                dataGridViewDonDat.DataSource = GoiVacxin_Controller.LayGoiVacXinCanDatMua().Tables[0];

            }
            textBoxSoLuong.Text = "";
        }

        private void dataGridViewDonDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButtonVaccine.Checked == true)
            {
                if (dataGridViewDonDat.CurrentRow != null && dataGridViewDonDat.CurrentRow.Index > -1)
                {
                    textBoxMaDon.Text = dataGridViewDonDat.CurrentRow.Cells[1].Value != null ? dataGridViewDonDat.CurrentRow.Cells[1].Value.ToString() : "";
                    textBoxSoLuong.Text = dataGridViewDonDat.CurrentRow.Cells[4].Value != null ? dataGridViewDonDat.CurrentRow.Cells[4].Value.ToString() : "";
                }
            }
            else
            {
                if (dataGridViewDonDat.CurrentRow != null && dataGridViewDonDat.CurrentRow.Index > -1)
                {
                    textBoxMaDon.Text = dataGridViewDonDat.CurrentRow.Cells[3].Value != null ? dataGridViewDonDat.CurrentRow.Cells[3].Value.ToString() : "";
                    textBoxSoLuong.Text = dataGridViewDonDat.CurrentRow.Cells[4].Value != null ? dataGridViewDonDat.CurrentRow.Cells[4].Value.ToString() : "";
                }
            }
        }

        private void NhanVienQuanLy_Load(object sender, EventArgs e)
        {

            radioButtonVaccine.Checked = true;
            


        }

        private void radioButtonVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewDonDat.DataSource = Vacxin_Controller.LayVacXinCanDatMua().Tables[0];

        }

        private void radioButtonGoiVaccine_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewDonDat.DataSource = GoiVacxin_Controller.LayGoiVacXinCanDatMua().Tables[0];
        }
    }
}
