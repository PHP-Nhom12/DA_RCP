using RapChieuPhimBUS;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_RapChieuPhim
{
    public partial class QLVe : Form
    {
        public QLVe()
        {
            InitializeComponent();
        }
        VeBUS ve = new VeBUS();
        PhongBUS phong = new PhongBUS();
        ThanhVienBUS tv = new ThanhVienBUS();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Loadve();
        }

        private void Loadve()
        {
            gcVe.DataSource = ve.LoadVe();

            lUpTenPhong.DataSource = phong.LoadPhong();
            lUPTenTV.DataSource = tv.LoadTV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<VeDTO> lsVe = new List<VeDTO>();
            VeBUS ve = new VeBUS();
            if (radTenPhong.Checked)
            {
                lsVe = ve.TimVe(1, txtQuery.Text);
            }
            else if (radTenThanhVien.Checked)
            {
                lsVe = ve.TimVe(2, txtQuery.Text);
            }
            else if (radTenPhim.Checked)
            {
                lsVe = ve.TimVe(3, txtQuery.Text);
            }
            else
            {
                lsVe = ve.TimVe(0, txtQuery.Text);
            }

            gcVe.DataSource = lsVe;
        }

    }
}
