using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapChieuPhimDTO;
using RapChieuPhimBUS;

namespace DA_RapChieuPhim
{
    public partial class FormThongKe : Form
    {
        List<VeDTO> lsVe;
        List<NhanVienDTO> lsNV;
        List<LuongDTO> lsLuong;
        List<PhimDTO> lsPhim;
        NhanVienDTO nv;
        ////List<CaDTO> lsCa;
        //CaDTO ca = new CaDTO();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            LoadDSVe();
            LoadDSNV();
            LoadDSLuong();
            LoadDSPhim();
            //LoadDSVeTheoCaChieu();
        }

        private void LoadDSVe()
        {
            VeBUS ve = new VeBUS();
            lsVe = ve.LoadVe();
        }

        private void LoadDSNV()
        {
            NhanVienBUS nv = new NhanVienBUS();
            lsNV = nv.LoadDSNVien();
        }

        private void LoadDSLuong()
        {
            NhanVienBUS luongnv = new NhanVienBUS();
            lsNV = luongnv.LoadDSNVien();
        }

        private void LoadDSPhim()
        {
            PhimBUS phim = new PhimBUS();
            lsPhim = phim.LoadPhim();
        }

        //private void LoadDSVeTheoCaChieu()
        //{
        //    CaBUS ca = new CaBUS();
        //    lsCa = ca.LoadCa();
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            formXemBaoCao f = new formXemBaoCao();
            if(rdbVe.Checked)
            {
                f.XemVe(lsVe);
            }
            
            if(rdbNV.Checked)
            {
                f.XemNv(lsNV);
            }

            if (rdbLuongNV.Checked)
            {
                f.XemLuongNV();
            }
            
            if(rdbPhim.Checked)
            {
                f.XemPhim(lsPhim);
            }

            //if(rdbGiaVeTheoSuat.Checked)
            //{
            //    f.XemGiaVeTheoCa(lsVe,ca);
            //}

            f.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        
    }
}
