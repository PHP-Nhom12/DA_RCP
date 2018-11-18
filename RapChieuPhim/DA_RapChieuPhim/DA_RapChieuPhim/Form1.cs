using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using RapChieuPhimDTO;
using System.IO;
using RapChieuPhimBUS;

namespace DA_RapChieuPhim
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool isDangNhap;
        FormDangNhap frmDN;
        public NhanVienDTO nvDangNhap = new NhanVienDTO();
        NhanVienBUS nvBUS = new NhanVienBUS();
       // NhanVienDTO nv = new NhanVienDTO();
        public Form1()
        {
            InitializeComponent();
        }
        private void skins()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.DefaultLookAndFeel Themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            //Themes.LookAndFeel.SkinName = "McSkin";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skins();
            PnThongtin.Visible = false;
            FormDangNhap frmDN = new FormDangNhap();
            frmDN.MdiParent = this;
            frmDN.Dock = DockStyle.Fill;
            frmDN.Show();
            btnDoiMK.Enabled=false;
            btnQLNV.Enabled = false;
            btnQLTV.Enabled = false;
            btnQLPhong.Enabled = false;
            btnQLVe.Enabled = false;
            btnQLyLChieu.Enabled = false;
            btnQuanLyPhim.Enabled = false;
        }
        private void XulyDangNhapDangXuat()
        {
            if (isDangNhap)
            {
                btnDNDX.Visible = true;
                PnThongtin.Visible = true;
                btnDoiMK.Enabled = true;
                btnQLNV.Enabled = true;
                btnQLTV.Enabled = true;
                btnQLPhong.Enabled = true;
                btnQLVe.Enabled = true;
                btnQLyLChieu.Enabled = true;
                btnQuanLyPhim.Enabled = true;
                //btnDMK.Enabled = true;  
                btnDNDX.Text = "ĐĂNG XUẤT";


            }
            else
            {
                btnDNDX.Text = "ĐĂNG NHẬP";


            }
        }
        internal void SetDangNhapThanhCong()
        {
            List<LoaiNV_DTO> lsLoaiNV = nvBUS.loadLoai();

            string strLoaiNV = "";

            foreach (LoaiNV_DTO loainv in lsLoaiNV)
            {
                if (loainv.MaLoaiNV == nvDangNhap.LoaiNV)
                {
                    strLoaiNV = loainv.TenLoai.ToString();
                    break;
                }
                else
                    strLoaiNV = "";
            }
            
            isDangNhap = true;
            lblHoTen.Text = nvDangNhap.HovaTen;
            lblChucVu.Text = strLoaiNV;
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\img\avatar\", nvDangNhap.HinhAnh);
            if (File.Exists(path))
            {
                byte[] byteHA = File.ReadAllBytes(path);
                MemoryStream ms = new MemoryStream(byteHA);
                picHinhNV.Image = Image.FromStream(ms);
            }
            XulyDangNhapDangXuat();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DongTatCaForm();
            FormDoiMK frmDK = new FormDoiMK();
            frmDK.MdiParent = this;
            frmDK.Dock = DockStyle.Fill;
            frmDK.getNVdangnhap(nvDangNhap);
            frmDK.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DongTatCaForm();
            QLNV frmQLNV = new QLNV();
            frmQLNV.MdiParent = this;
            frmQLNV.Dock = DockStyle.Fill;
            frmQLNV.Show();
        }

        private void btnDNDX_Click(object sender, EventArgs e)
        {
           
            if(isDangNhap)
            {
                isDangNhap = false;
                picHinhNV.Image = null;
                lblHoTen.Text = "";
                lblChucVu.Text = "";
                btnDoiMK.Enabled = false;
                btnQLNV.Enabled = false;
                btnQLTV.Enabled = false;
                btnQLPhong.Enabled = false;
                btnQLVe.Enabled = false;
                btnQLyLChieu.Enabled = false;
                PnThongtin.Visible = false;
                btnQuanLyPhim.Enabled = false;
                frmDN = new FormDangNhap();
                frmDN.MdiParent = this;
                frmDN.Dock = DockStyle.Fill;
                frmDN.Show();
                XulyDangNhapDangXuat();
            }
            else
            {
                if(frmDN==null&& frmDN.IsDisposed)
                {
                    frmDN = new FormDangNhap();
                    frmDN.MdiParent = this;
                    frmDN.Dock = DockStyle.Fill;
                }
                frmDN.Show();
            }
        }

        

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result== DialogResult.OK)
            {
                 this.Close();
            }
            else
            {
                return;
            }
           
        }

        private void DongTatCaForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.MdiParent == this && !f.IsDisposed)
                {
                    f.Dispose();
                }
            }
        }

        private void btnQLNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DongTatCaForm();
            QLNV frmQLNV = new QLNV();
            frmQLNV.MdiParent = this;
            frmQLNV.Dock = DockStyle.Fill;
            frmQLNV.Show();
        }

        private void btnQLTV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DongTatCaForm();
            QLTV frmTV = new QLTV();
            frmTV.MdiParent = this;
            frmTV.Dock = DockStyle.Fill;
            frmTV.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DongTatCaForm();
            FormThongKe frmTK = new FormThongKe();
            frmTK.Dock = DockStyle.Fill;
            frmTK.MdiParent = this;
            frmTK.Show();
        }

        private void btnQLVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DongTatCaForm();
            QLVe frmVe = new QLVe();
            frmVe.Dock = DockStyle.Fill;
            frmVe.MdiParent = this;
            frmVe.Show();
        }

        private void btnQLyLChieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DongTatCaForm();
            FormQL_LChieu FrmLC = new FormQL_LChieu(); 
            FrmLC.Dock = DockStyle.Fill;
            FrmLC.MdiParent = this;
            FrmLC.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DongTatCaForm();
            FormDatVe FrmDV = new FormDatVe();
            FrmDV.Dock = DockStyle.Fill;
            FrmDV.MdiParent = this;
            FrmDV.Show();
        }

        private void btnQLPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DongTatCaForm();
            FormPhong FrmPhong = new FormPhong();
            FrmPhong.Dock = DockStyle.Fill;
            FrmPhong.MdiParent = this;
            FrmPhong.Show();
        }

        private void picHinhNV_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
