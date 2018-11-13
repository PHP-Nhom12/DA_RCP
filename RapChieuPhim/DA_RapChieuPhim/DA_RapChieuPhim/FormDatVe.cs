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
    public partial class FormDatVe : Form
    {
        VeBUS ve = new VeBUS();
        CaBUS ca = new CaBUS();
        PhimBUS phim = new PhimBUS();
        VoucherBUS voucher = new VoucherBUS();
        PhongBUS phong = new PhongBUS();
        GheBUS ghe = new GheBUS();
        ThanhVienBUS tv = new ThanhVienBUS();
        LichChieuBUS lc = new LichChieuBUS();
        ChiTietLichChieuBUS ctlc = new ChiTietLichChieuBUS();

        public FormDatVe()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            dateNgay.EditValue = DateTime.Now;

            LoadLichChieu();

            LoadCa();
            LoadPhim();
            LoadPhong();

            LoadTV();

        }

        private void LoadLichChieu()
        {
            string date = ((System.DateTime)(dateNgay.EditValue)).Month.ToString() + "/" + ((System.DateTime)(dateNgay.EditValue)).Day.ToString() + "/" + ((System.DateTime)(dateNgay.EditValue)).Year.ToString();
            DateTime ngay = DateTime.ParseExact(date,"MM/dd/yyyy",null);

            List<LichChieuDTO> lsLC = lc.LoadLich(ngay);

            List<ChiTietLichChieuDTO> lsCTLC = new List<ChiTietLichChieuDTO>();

            foreach (LichChieuDTO lichchieu in lsLC)
            {
                lsCTLC = ctlc.loadCTLC(lichchieu.MaLich);
            }

            foreach (ChiTietLichChieuDTO ctlc in lsCTLC)
            {
                lueCa.EditValue = ctlc.MaCa;
                lueTenPhim.EditValue = ctlc.MaPhim;
                lueTenPhong.EditValue = ctlc.MaPhong;
            }
        }

        private void LoadTV()
        {
            lueMaTV.Properties.DataSource = tv.LoadTV();
            lueMaTV.Properties.DisplayMember = "TenTV";
            lueMaTV.Properties.ValueMember = "MaTV";
        }

        private void LoadGhe(int MaPhong)
        {
            lueGhe.Properties.DataSource = ghe.LoadGhe(MaPhong);
            lueGhe.Properties.DisplayMember = "MaGhe";
            lueGhe.Properties.ValueMember = "MaPhong";
        }

        private void LoadPhong()
        {
            lueTenPhong.Properties.DataSource = phong.LoadPhong();
            lueTenPhong.Properties.DisplayMember = "TenPhong";
            lueTenPhong.Properties.ValueMember = "MaPhong";
        }

        private void LoadVoucher(int MaTV)
        {
            lueVoucher.Properties.DataSource = voucher.LoadVoucher(MaTV);
            lueVoucher.Properties.DisplayMember = "TenVoucher";
            lueVoucher.Properties.ValueMember = "MaVoucher";
        }

        private void LoadPhim()
        {
            lueTenPhim.Properties.DataSource = phim.LoadPhim();
            lueTenPhim.Properties.DisplayMember = "TenPhim";
            lueTenPhim.Properties.ValueMember = "MaPhim";

        }

        private void LoadCa()
        {
            lueCa.Properties.DataSource = ca.LoadCa();
            lueCa.Properties.DisplayMember = "TenCa";
            lueCa.Properties.ValueMember = "MaCa";
        }

        private void lueCa_EditValueChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show(lueCa.EditValue.ToString());
        }

        private void lueTenPhim_EditValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lueTenPhim.EditValue.ToString());
        }

        private void lueTenPhong_EditValueChanged(object sender, EventArgs e)
        {
            int MaPhong = int.Parse(lueTenPhong.EditValue.ToString());
            if (MaPhong != 0)
                LoadGhe(MaPhong);
            //MessageBox.Show(lueTenPhong.EditValue.ToString());
        }

        private void lueGhe_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void lueMaTV_EditValueChanged(object sender, EventArgs e)
        {
            int MaTV = int.Parse(lueMaTV.EditValue.ToString());
            if (MaTV != 0)
                LoadVoucher(MaTV);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {

        }


    }
}
