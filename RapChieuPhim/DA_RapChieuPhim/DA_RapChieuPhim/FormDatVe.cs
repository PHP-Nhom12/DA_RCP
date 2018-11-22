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
        VeDTO vechon = null;
        List<VeDTO> lsVeChon = new List<VeDTO>();

        PhimBUS phim = new PhimBUS();
        VoucherBUS voucher = new VoucherBUS();
        SuatChieuBUS suatchieu = new SuatChieuBUS();
        ThanhVienBUS tv = new ThanhVienBUS();
        LichChieuBUS lc = new LichChieuBUS();
        ChiTietLichChieuBUS ctlc = new ChiTietLichChieuBUS();

        // Khai báo các biến để lấy dữ liệu cho dễ
        LichChieuDTO lcDTO = new LichChieuDTO();
        ChiTietLichChieuDTO ctlcDTO = new ChiTietLichChieuDTO();
        List<LichChieuDTO> lsLC = new List<LichChieuDTO>();
        List<SuatChieuDTO> lsPhim = new List<SuatChieuDTO>();
        SuatChieuDTO suatchieuchon = new SuatChieuDTO();


        // khai báo các biến giữ giá trị lấy về để tính toán và cho 'vechon'
        
        float Voucher_TiLe = 1;
        int LichChieu_MaLC;
        int MaTV;
        int Voucher_MaVoucher;
        int tongthanhtoan = 0;
        int tam = 0;
        int GiaCB = 0;
        float tongtien = 0;
        float dagiam = 0;

        public FormDatVe()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            FormInit();
            ResetForm();
        }

        private void FormInit()
        {
            LoadNgay();
            // Trigger cbbNgay_SelectedIndexChanged();
            // -> LoadLichChieuTheoNgay()
            // -> lcDTO, ctlcDTO, LichChieu_MaLC

            LoadTV();
            //Voucher load ngay sau LoadTV()
            lueVoucher.Enabled = false;

            // Lấy ra ngày chiếu
            cbbNgay.SelectedValue = LichChieu_MaLC;


        }
        private void LoadNgay()
        {
            cbbNgay.DataSource = lc.LoadLich();
            cbbNgay.DisplayMember = "ThoiGian";
            cbbNgay.ValueMember = "MaLich";
        }

        private void LoadTV()
        {
            lueMaTV.Properties.DataSource = tv.LoadTV();
            lueMaTV.Properties.DisplayMember = "TenTV";
            lueMaTV.Properties.ValueMember = "MaTV";
        }

        private void cbbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lcDTO = (LichChieuDTO)cbbNgay.SelectedItem;

            if (lcDTO.ThoiGian.ToString() != "")
            {
                LoadLichChieuTheoNgay(lcDTO.ThoiGian);
                ResetForm();
            }

        }

        private void ResetForm()
        {
            lueVoucher.Enabled = false;
            lueMaTV.EditValue = null;
            lueVoucher.EditValue = null;
        }

        private void LoadLichChieuTheoNgay(DateTime NgayChieu)
        {
            string date = "";

            if (NgayChieu != null)
            {

                // Dữ liệu trả về dạng MM/dd/yyyy. VD: "11/14/2018"
                date = ((System.DateTime)(NgayChieu)).Month.ToString() + "/" + ((System.DateTime)(NgayChieu)).Day.ToString() + "/" + ((System.DateTime)(NgayChieu)).Year.ToString();

                DateTime ngay = DateTime.ParseExact(date, "MM/dd/yyyy", null);

                // Lưu data lịch chiếu ngày vừa chọn
                lcDTO = lc.LoadLich(ngay);

            }
            else
            {
                MessageBox.Show("Sai Ngày!");
                return;
            }


            // Nếu ko có lịch chiếu của ngày đó
            if (lcDTO == null)
            {
                MessageBox.Show("Ngày " + lcDTO.ThoiGian.ToShortDateString() + " chưa có lịch chiếu!");
                
                return;
            }

            // Lấy 'Chi tiết lịch chiếu' hiện tại khi 'Ca' thay đổi
            ctlcDTO = ctlc.loadCTLC(lcDTO.MaLich);

            // Lấy Mã lịch chiếu
            LichChieu_MaLC = lcDTO.MaLich;

            // Đổ dữ liệu vào ListView
            LoadPhim(LichChieu_MaLC);

        }

        private void LoadPhim(int MaLich)
        {
            lvDSPhim.Items.Clear();
            lvDSGhe.Visible = false;

            lvDSPhim.Groups.Add(new ListViewGroup("Rạp 2D", HorizontalAlignment.Left));
            lvDSPhim.Groups.Add(new ListViewGroup("Rạp 3D", HorizontalAlignment.Left));
            lvDSPhim.Groups.Add(new ListViewGroup("Rạp IMAX", HorizontalAlignment.Left));


            lsPhim = suatchieu.LoadSuatChieu(MaLich);
            int i = 0;
            foreach (SuatChieuDTO Phim in lsPhim)
            {
                ListViewItem lviPhim = new ListViewItem(Phim.Mac);
                lviPhim.SubItems.Add(Phim.TenPhim);
                lviPhim.SubItems.Add(Phim.ThoiGianBD.Trim());
                lviPhim.SubItems.Add(Phim.ThoiGianKT.Trim());
                lviPhim.SubItems.Add(Phim.SLCho.ToString());
                lvDSPhim.Items.Add(lviPhim);
                switch (Phim.Maloai)
	            {
                    case 1:
                        lvDSPhim.Items[i].Group = lvDSPhim.Groups[0];
                        break;
                    case 2:
                        lvDSPhim.Items[i].Group = lvDSPhim.Groups[1];
                        break;
		            default:
                        lvDSPhim.Items[i].Group = lvDSPhim.Groups[2];
                        break;
	            }
                i++;
            }
        }

        private void lueMaTV_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMaTV.EditValue != null)
            {
                MaTV = int.Parse(lueMaTV.EditValue.ToString());
                if (MaTV != 0)
                    LoadVoucher(MaTV);
                lueVoucher.Enabled = true;

                lbNamSX.Text = "Chưa chọn voucher";
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (Voucher_MaVoucher == 0 || MaTV == 0)
            {
                MessageBox.Show("Mời nhập thông tin Thành viên và Voucher");
                return;
            }

            if (vechon != null)
            {
                vechon.MaVoucher = Voucher_MaVoucher;
                vechon.MaTV = MaTV;
            }
            //if (CheckVeChon())
            //{
            //    ThemVeMoi();
            //}
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

        private void lueVoucher_EditValueChanged(object sender, EventArgs e)
        {
            if (tam != 0)
            {
                tongthanhtoan = tam;
                tam = 0;
            }
            else if (tongthanhtoan != 0)
            {
                tam = tongthanhtoan;
                tongthanhtoan = 0;
            }
            
            dagiam = 0;

            if (lueVoucher.EditValue != null)
            {
                Voucher_MaVoucher = (int)(lueVoucher.EditValue);
                VoucherDTO vou = (VoucherDTO)lueVoucher.GetSelectedDataRow();
                Voucher_TiLe = vou.TiLe / 100;
                if (lvDSGhe.SelectedItems.Count == 0)
                {
                    lbTheLoai.Text = "Chưa chọn Ghế";
                }

                if (lsVeChon.Count > 0)
                {
                    foreach (VeDTO ve in lsVeChon)
                    {
                        int gb = (int)(ve.GiaVe * Voucher_TiLe);
                        if (tam == 0)
                        {
                            tam += gb;
                        } else if (tongthanhtoan == 0)
                        {
                            tongthanhtoan += gb;
                        }
                        else
                        {
                            tam += gb;
                        }
                    }

                    lbTongThanhToan.Text = (tam == 0 ? tam : tongthanhtoan) + "đ";
                }
            }
        }

        private void LoadVoucher(int MaTV)
        {
            lueVoucher.Properties.DataSource = voucher.LoadVoucher(MaTV);
            lueVoucher.Properties.DisplayMember = "TenVoucher";
            lueVoucher.Properties.ValueMember = "MaVoucher";
        }

        private void lvDSPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSPhim.SelectedItems.Count == 1)
            {
                suatchieuchon = lsPhim.Find(o => o.TenPhim == lvDSPhim.SelectedItems[0].SubItems[1].Text);

                GiaCB = (int)(50000 * (new LoaiPhongBUS()).LoadLoaiPhong().Find(o=>o.MaLoai == suatchieuchon.Maloai).HeSo);

                lbNDPhim.Text = suatchieuchon.NDPhim;
                lbNamSX.Text = suatchieuchon.NamXS;
                lbNhaSX.Text = suatchieuchon.NhaXS;
                lbDaoDien.Text = suatchieuchon.DaoDien;
                lbThoiLuong.Text = suatchieuchon.ThoiLuong + " phút";
                //lbTheLoai.Text = (new TheLoaiBUS()).LoadTheLoai().Find(o => o.MaTheLoai == suatchieuchon.TheLoai.Trim()).TenTheLoai;

                lvDSGhe.Items.Clear();

                lvDSGhe.Groups.Add(new ListViewGroup("Màn Hình", HorizontalAlignment.Center));

                for (int i = 0; i < suatchieuchon.SLCho; i++)
                {
                    lvDSGhe.Items.Add("A" + (i + 1));
                    lvDSGhe.Items[i].Group = lvDSGhe.Groups[0];
                }

                lvDSGhe.Visible = true;

                ResetLabel();
            }
        }

        private void ResetLabel()
        {
            
        }

        private void lvDSGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tongthanhtoan = 0;
            tongtien = 0;

            if (lvDSGhe.SelectedItems.Count > 0)
            {
                if (vechon == null)
                {
                    vechon = new VeDTO();
                }

                float Ca_HeSo = (new CaBUS()).LoadCa().Find(o => o.MaCa == suatchieuchon.MaCa).HeSo;
                if (Voucher_TiLe == 0)
                    Voucher_TiLe = 1;
                
                lsVeChon.Clear();

                lbTheLoai.Text = "";

                foreach (ListViewItem item in lvDSGhe.SelectedItems)
                {
                    tongtien += GiaCB * Ca_HeSo;
                    vechon.GiaVe = (int)tongtien;
                    vechon.MaPhim = suatchieuchon.MaPhim;
                    vechon.ViTriNgoi = item.Text;
                    lbTheLoai.Text += item.Text + ", ";
                    vechon.PhongChieu = suatchieuchon.MaPhong;
                    vechon.TGBatDau = suatchieuchon.ThoiGianBD;
                    vechon.TGKetThuc = suatchieuchon.ThoiGianKT;
                    vechon.NgayTaoVe = DateTime.Today;
                    vechon.MaLichChieu = LichChieu_MaLC;
                    lsVeChon.Add(vechon);
                }
                tongthanhtoan = (int)tongtien;
            }

            lbNhaSX.Text = tongtien + "đ";
            lbTongThanhToan.Text = (int)tongtien + "đ";
        }

    }
}
