using RapChieuPhimBUS;
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

    }
}
