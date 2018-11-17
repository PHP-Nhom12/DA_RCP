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
        VeDTO vechon = null;
        VeBUS ve = new VeBUS();
        PhongBUS phong = new PhongBUS();
        ThanhVienBUS tv = new ThanhVienBUS();
        PhimBUS phim = new PhimBUS();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Loadve();
        }

        private void Loadve()
        {
            gcVe.DataSource = ve.LoadVe();
            lUpTenPhim.DataSource = phim.LoadPhim();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (vechon != null)
            {
                if (ve.XoaVe(vechon.MaVe))
                {
                    MessageBox.Show("Da xoa ve");
                    gcVe.DataSource = ve.LoadVe();
                }
                else
                {
                    MessageBox.Show("Xoa that bai");
                }
            }
        }

        private void gvVe_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] rows = gvVe.GetSelectedRows();
            foreach (int item in rows)
            {
                if (item >= 0)
                {
                    if (vechon == null)
                    {
                        vechon = new VeDTO();
                    }
                    vechon.MaVe = int.Parse(gvVe.GetRowCellValue(item, ColMaVe).ToString().Trim());
                    vechon.MaPhim = int.Parse(gvVe.GetRowCellValue(item, ColTenPhim).ToString().Trim());
                    vechon.ViTriNgoi = gvVe.GetRowCellValue(item, ColVitri).ToString().Trim();
                    vechon.PhongChieu = int.Parse(gvVe.GetRowCellValue(item, ColPhong).ToString().Trim());
                    vechon.GiaVe = int.Parse(gvVe.GetRowCellValue(item, ColGiaVe).ToString().Trim());
                    vechon.MaTV = int.Parse(gvVe.GetRowCellValue(item, ColTenTV).ToString().Trim());
                }
            }
        }
    }
}
