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
    public partial class NVTT_DatMua : Form
    {
        public NVTT_DatMua()
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

        }

        private void dataGridViewVaccine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButtonChonGoiVaccine.Checked == true)
            {
                if (dataGridViewVaccine.CurrentRow != null && dataGridViewVaccine.CurrentRow.Index > -1)
                {
                    textBoxTen.Text = dataGridViewVaccine.CurrentRow.Cells[3].Value != null ? dataGridViewVaccine.CurrentRow.Cells[3].Value.ToString() : "";
                   
                }
            }
            else
            {

                if (dataGridViewVaccine.CurrentRow != null && dataGridViewVaccine.CurrentRow.Index > -1)
                {
                    textBoxTen.Text = dataGridViewVaccine.CurrentRow.Cells[1].Value != null ? dataGridViewVaccine.CurrentRow.Cells[1].Value.ToString() : "";
                    
                }

            }
        }

        private void NVTT_DatMua_Load(object sender, EventArgs e)
        {
            dataGridViewVaccine.DataSource = Vacxin_Controller.LayDSVacXin().Tables[0];
        }

        private void buttonSearchKH_Click(object sender, EventArgs e)
        {

            DataSet KH = KhachHang_Controller.LayThongTinKH(textBoxSoDienThoaiKhachHang.Text);
            if (KH.Tables.Count < 1)
            {
                MessageBox.Show("KHÔNG CÓ KHÁCH HÀNG ");
            }
            else
            {
               
                textBoxTenKhachHang.Text = KH.Tables[0].Rows[0][3].ToString();
               
            }
        }
    }
}
