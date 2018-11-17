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
    public partial class FormQL_LChieu : Form
    {
        public FormQL_LChieu()
        {
            InitializeComponent();
        }
        PhongBUS pBUS = new PhongBUS();
        CaBUS ca = new CaBUS();
        PhimBUS phim = new PhimBUS();
        LichChieuBUS lich = new LichChieuBUS();
        private void FormQL_LChieu_Load(object sender, EventArgs e)
        {
            LoadtatCa();
        }

        private void LoadtatCa()
        {
            lUpTenPhong.Properties.DataSource = pBUS.LoadPhong();
            lUpTenPhong.Properties.DisplayMember = "TenPhong";
            lUpTenPhong.Properties.ValueMember = "MaPhong";

            lUPCa.Properties.DataSource = ca.LoadCa();
            lUPCa.Properties.DisplayMember = "TenCa";
            lUPCa.Properties.ValueMember = "MaCa";

            lUPtenPhim.Properties.DataSource = phim.LoadPhim();
            lUPtenPhim.Properties.DisplayMember = "TenPhim";
            lUPtenPhim.Properties.ValueMember = "MaPhim";

            gcLichCHieu.DataSource = lich.LoadLich();

            LupTPhim.DataSource = phim.LoadPhim();
            LupTphong.DataSource = pBUS.LoadPhong();
            LupMaCa.DataSource = ca.LoadCa();

            dtpGioBatDau.Format = DateTimePickerFormat.Custom;
            dtpGioBatDau.CustomFormat = "HH:mm";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioKetThuc.Format = DateTimePickerFormat.Custom;
            dtpGioKetThuc.CustomFormat = "HH:mm";
            dtpGioKetThuc.ShowUpDown = true;

        }     
    }
}
