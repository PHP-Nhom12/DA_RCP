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
        // Khai báo các biến chuẩn bị cho 'vechon'
        VeBUS ve = new VeBUS();
        VeDTO vechon = null;
        CaBUS ca = new CaBUS();
        PhimBUS phim = new PhimBUS();
        VoucherBUS voucher = new VoucherBUS();
        PhongBUS phong = new PhongBUS();
        GheBUS ghe = new GheBUS();
        ThanhVienBUS tv = new ThanhVienBUS();
        LichChieuBUS lc = new LichChieuBUS();
        ChiTietLichChieuBUS ctlc = new ChiTietLichChieuBUS();

        // Khai báo các biến để lấy dữ liệu cho dễ
        LichChieuDTO lcDTO = new LichChieuDTO();
        ChiTietLichChieuDTO ctlcDTO = new ChiTietLichChieuDTO();
        List<ChiTietLichChieuDTO> lsCTLC = null;

        // khai báo các biến giữ giá trị lấy về để tính toán và cho 'vechon'
        float Ca_HeSo;
        float Voucher_TiLe = 1;
        int LichChieu_MaLC;
        DateTime LichChieu_NgayNhap;
        int Phim_MaPhim;
        int Phong_MaPhong;
        string Ghe_ViTriNgoi;
        int MaTV;
        int Voucher_MaVoucher;
        private int Ca_MaCa;

        public FormDatVe()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            ResetForm();
        }

        private void LoadLichChieu(DateTime NgayChieu)
        {
            // Dữ liệu trả về dạng MM/dd/yyyy. VD: "11/14/2018"
            string date = ((System.DateTime)(NgayChieu)).Month.ToString() + "/" + ((System.DateTime)(NgayChieu)).Day.ToString() + "/" + ((System.DateTime)(NgayChieu)).Year.ToString();

            // Lấy Lịch chiếu theo ngày vừa chọn
            DateTime ngay = DateTime.ParseExact(date,"MM/dd/yyyy",null);

            List<LichChieuDTO> lsLC = lc.LoadLich(ngay);

            lueCa.EditValue = null;
            lueTenPhim.EditValue = null;
            lueTenPhong.EditValue = null;
            lueGhe.EditValue = null;
            lueMaTV.EditValue = null;
            lueVoucher.EditValue = null;

            // Nếu ko có lịch chiếu của ngày đó
            if (lsLC.Count() == 0)
            {
                MessageBox.Show("Ngày "+date+" chưa có lịch chiếu!");
                lueCa.Enabled = false;
                return;
            }
            else
            {
                lueCa.Enabled = true;
            }

            // Lấy Mã lịch chiếu
            //lsCTLC = new List<ChiTietLichChieuDTO>();

            foreach (LichChieuDTO lichchieu in lsLC)
            {
                //lsCTLC = ctlc.loadCTLC(lichchieu.MaLich);
                LichChieu_MaLC = lichchieu.MaLich;
            }

            //foreach (ChiTietLichChieuDTO ctlc in lsCTLC)
            //{
            //    // Lấy 'Chi tiết lịch chiếu' hiện tại khi 'Ca' thay đổi
            //    ctlcDTO = ctlc;
            //}
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
            lueGhe.Properties.ValueMember = "MaGhe";
        }

        private void LoadPhong(int MaPhim)
        {
            lueTenPhong.Properties.DataSource = phong.LoadPhong(MaPhim);
            lueTenPhong.Properties.DisplayMember = "TenPhong";
            lueTenPhong.Properties.ValueMember = "MaPhong";
        }

        private void LoadVoucher(int MaTV)
        {
            lueVoucher.Properties.DataSource = voucher.LoadVoucher(MaTV);
            lueVoucher.Properties.DisplayMember = "TenVoucher";
            lueVoucher.Properties.ValueMember = "MaVoucher";
        }

        private void LoadPhim(int MaCa)
        {
            lueTenPhim.Properties.DataSource = phim.LoadPhim(MaCa);
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
            if (lueCa.EditValue != null)
            {
                // Cho phép người dùng chọn phim
                lueTenPhim.Enabled = true;

                // Lấy mã ca hiện tại được chọn
                Ca_MaCa = int.Parse(lueCa.EditValue.ToString());

                // Lấy lại danh sách phim theo mã ca vừa chọn
                LoadPhim(Ca_MaCa);

                // Lấy lại chi tiết lịch chiếu theo mã ca vừa thay đổi
                foreach (ChiTietLichChieuDTO ctlichchieu in ctlc.loadCTLC_TheoMaCa(Ca_MaCa))
                {
                    ctlcDTO = ctlichchieu;
                }

                // Lấy đối tượng 'Ca' theo dòng đang chọn
                CaDTO cachon = (CaDTO)lueCa.GetSelectedDataRow();

                if (cachon != null && cachon.HeSo != null)
                {
                    Ca_HeSo = float.Parse(cachon.HeSo.ToString());
                }
                //MessageBox.Show(lueCa.EditValue.ToString());
            }
        }

        private void lueTenPhim_EditValueChanged(object sender, EventArgs e)
        {
            if (lueTenPhim.EditValue != null)
            {
                // Cho phép người dùng chọn phòng
                lueTenPhong.Enabled = true;

                Phim_MaPhim = int.Parse(lueTenPhim.EditValue.ToString());
                if (Phim_MaPhim != 0)
                {
                    LoadPhong(Phim_MaPhim);
                }
            }
            //MessageBox.Show(lueTenPhim.EditValue.ToString());
        }

        private void lueTenPhong_EditValueChanged(object sender, EventArgs e)
        {
            if (lueTenPhong.EditValue != null)
            {
                // Cho phép người dùng chọn ghế
                lueGhe.Enabled = true;

                Phong_MaPhong = int.Parse(lueTenPhong.EditValue.ToString());
                if (Phong_MaPhong != 0)
                    LoadGhe(Phong_MaPhong);
            }
            //MessageBox.Show(lueTenPhong.EditValue.ToString());
        }

        private void lueGhe_EditValueChanged_1(object sender, EventArgs e)
        {
            if (lueGhe.EditValue != null)
            {
                Ghe_ViTriNgoi = lueGhe.EditValue.ToString();
            }
        }

        private void lueMaTV_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMaTV.EditValue != null)
            {
                MaTV = int.Parse(lueMaTV.EditValue.ToString());
                if (MaTV != 0)
                    LoadVoucher(MaTV);
                chbVoucher.Enabled = true;
                lueVoucher.Enabled = true;
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (CheckVeChon())
            {
                ThemVeMoi();
            }
        }

        private bool CheckVeChon()
        {
            // Trả về TRUE nếu đủ dữ liệu và FALSE nếu ko đủ
            if (lueCa.EditValue != null && lueGhe.EditValue != null && dateNgay.EditValue != null && lueTenPhim.EditValue != null && lueTenPhong.EditValue != null)
            {
                if (lueMaTV.EditValue == null)
                {
                    DialogResult tmp = MessageBox.Show("Chưa chọn Thành viên!");
                    return false;
                }
                else
                {
                    if (lueVoucher.EditValue == null && chbVoucher.Checked == true || lueVoucher.EditValue == null)
                    {
                        MessageBox.Show("Chưa chọn Voucher!");
                        return false;
                    }

                    if (vechon == null)
                    {
                        vechon = new VeDTO();
                    }

                    vechon.MaPhim = Phim_MaPhim;
                    vechon.ViTriNgoi = Ghe_ViTriNgoi;
                    vechon.PhongChieu = Phong_MaPhong;
                    if (Voucher_TiLe == 0)
                        Voucher_TiLe = 1;
                    vechon.GiaVe = int.Parse((50000 * Ca_HeSo * Voucher_TiLe).ToString());
                    vechon.NgayTaoVe = DateTime.Today;
                    vechon.MaVoucher = Voucher_MaVoucher;
                    vechon.MaTV = MaTV;
                    vechon.MaLichChieu = LichChieu_MaLC;

                    return true;
                }
            }
            else
            {
                MessageBox.Show("Chưa đủ thông tin");
                return false;
            }
        }

        private void ThemVeMoi()
        {
            if (ve.ThemVe(vechon))
            {
                MessageBox.Show("Thêm Vé Thành Công!");
                ResetForm();
            }
            else
            {
                MessageBox.Show("Thêm Vé Thất Bại!");
            }
        }

        private void ResetForm()
        {
            // Lấy ra ngày hiện tại
            dateNgay.EditValue = DateTime.Now;

            // Lấy lịch chiếu (ca, phim, phòng) theo ngày được chọn
            LoadLichChieu(DateTime.Today);

            // Load dữ liệu cho component Ca (lueCa)
            LoadCa();

            // Load dữ liệu cho component Thành Viên (lueMaTV)
            LoadTV();

            // Vô hiệu hóa các trường dữ liệu trước khi người dùng chọn
            lueTenPhim.Enabled = false;
            lueTenPhong.Enabled = false;
            lueGhe.Enabled = false;
            chbVoucher.Enabled = false;
            chbVoucher.Checked = false;
            lueVoucher.Enabled = false;
        }

        private void dateNgay_EditValueChanged(object sender, EventArgs e)
        {
            DateTime ngay = DateTime.Parse(dateNgay.EditValue.ToString());
            LoadLichChieu(ngay);
            LichChieu_NgayNhap = ngay;
        }

        private void lueVoucher_EditValueChanged(object sender, EventArgs e)
        {
            if (lueVoucher.EditValue != null)
            {
                Voucher_MaVoucher = (int)(lueVoucher.EditValue);
                VoucherDTO vou = (VoucherDTO)lueVoucher.GetSelectedDataRow();
                Voucher_TiLe = vou.TiLe / 100;
            }
        }

        private void chbVoucher_CheckedChanged(object sender, EventArgs e)
        {
            if (lueMaTV.EditValue != null)
            {
                chbVoucher.Enabled = true;
            }
        }


    }
}
