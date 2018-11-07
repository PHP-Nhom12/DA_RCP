using RapChieuPhimBUS;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_RapChieuPhim
{
    public partial class QLNV : Form
    {
        LuongBUS nv = new LuongBUS();
        List<LuongBUS> LuongNV = new List<LuongBUS>();
        LoaiNV_BUS Loai = new LoaiNV_BUS();
        NhanVienBUS nv_bus = new NhanVienBUS();
        NhanVienDTO nvchon = null;
        string pathHA = "D:/RapChieuPhim/DA_RapChieuPhim/DA_RapChieuPhim/bin/Debug/Dữ Liệu/";
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            loadNV();
            loadLuong();
        }

        public void loadNV()
        {
            gcNhanVien.DataSource = nv_bus.LoadDSNVien();
        }
       

        private void loadLuong()
        {

            lUpLuong.Properties.DataSource =nv.LuongNV();
            lUpLuong.Properties.DisplayMember = "LuongCB";
            lUpLuong.Properties.ValueMember = "MaLuong";

            lUpChucVu.Properties.DataSource = Loai.LayLoaiNV();
            lUpChucVu.Properties.DisplayMember = "TenLoai";
            lUpChucVu.Properties.ValueMember = "MaLoaiNV";


            LpChucVu.DataSource = Loai.LayLoaiNV();
            LpLuong.DataSource = nv.LuongNV();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Multiselect = false;
            ofp.Filter = "Pictures | *.png;*jpg";
            DialogResult dr= ofp.ShowDialog();
            if(dr == DialogResult.Cancel)
            {
                pictureBox1.Image = null;
            }
            else
            {
                byte[] HA = File.ReadAllBytes(ofp.FileName);
                MemoryStream ms = new MemoryStream(HA);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            getDataDetail();
            string hten = txtTenNV.Text;
            DateTime NSinh = DateTime.Parse(dtNS.Text);
            string DChi = txtDC.Text;
            string GTinh = rdoNam.Checked? "Nam": "Nữ";
            string Email = txtEmail.Text;
            string Password = txtPass.Text;
            DateTime NgayVaoLam = DateTime.Parse(dtNVL.Text);
            int MaLuong = (int)lUpLuong.EditValue;
            int LoaiNV = (int)lUpChucVu.EditValue;
            string HinhAnh = pathHA + nvchon.MaNV + ".png";
            int TrangThai =chkTrangthai.Checked ? 1 : 0;
            List<NhanVienDTO> kq = nv_bus.ThemNV(hten,NSinh,GTinh,DChi,Email,Password,HinhAnh,NgayVaoLam,LoaiNV,MaLuong,TrangThai);
            if (kq != null)
            {
                if(pictureBox1.Image!=null)
                {
                    pictureBox1.Image.Save(HinhAnh);
                }
                MessageBox.Show("Thêm Thành Công");
                loadNV();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }
           
        }

        private void getDataDetail()
        {
            if (nvchon == null)
            {
                nvchon = new NhanVienDTO();
            }
            nvchon.HovaTen = txtTenNV.Text;
            nvchon.NgaySinh = DateTime.Parse(dtNS.Text);
            nvchon.DiaChi = txtDC.Text;
            nvchon.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            nvchon.Email = txtEmail.Text;
            nvchon.Password = txtPass.Text;
            nvchon.NgayVaoLam = DateTime.Parse(dtNVL.Text);
            nvchon.MaLuong = lUpLuong.SelectionStart;
            nvchon.LoaiNV = lUpChucVu.SelectionStart;
            nvchon.HinhAnh = pathHA + nvchon.MaNV + ".png";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(gvNhanVien.SelectedRowsCount==0)
            {
                MessageBox.Show("Chưa chọn đối tượng để xóa", "Thông Báo");
            }
            else
            {
                DialogResult r = MessageBox.Show("Bạn có chắn chắn muốn xóa nhân viên", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(DialogResult.Yes==r)
                {
                    int[] i = gvNhanVien.GetSelectedRows();
                    foreach(int rows in i)
                    {
                        if(rows>=0)
                        {
                            //string Email = gvNhanVien.GetRowCellValue(rows, ColMaNV).ToString();
                            string MaNV = gvNhanVien.GetRowCellValue(rows, ColMaNV).ToString();
                            if (nv_bus.XoaNV(MaNV) >= 1)
                            {
                                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK);
                            }
                        }
                        loadNV();
                    }
                    
                }
            }
        }

        private void gcNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void gcNhanVien_DoubleClick(object sender, EventArgs e)
        {
            if (gvNhanVien.SelectedRowsCount > 0)
            {
                int[] rows = gvNhanVien.GetSelectedRows();

                foreach (int item in rows)
                {
                    if (item >= 0)
                    {
                        nvchon = new NhanVienDTO();
                        nvchon.HovaTen = gvNhanVien.GetRowCellValue(item, ColTenNV).ToString().Trim();
                        nvchon.NgaySinh = DateTime.Parse(gvNhanVien.GetRowCellValue(item, ColNgaySinh).ToString().Trim());
                        nvchon.GioiTinh = gvNhanVien.GetRowCellValue(item, ColGioiTinh).ToString().Trim();
                        nvchon.DiaChi = gvNhanVien.GetRowCellValue(item, ColDC).ToString().Trim();
                        nvchon.Email = gvNhanVien.GetRowCellValue(item, ColMail).ToString().Trim();
                        nvchon.LoaiNV = int.Parse(gvNhanVien.GetRowCellValue(item, ColChucVu).ToString().Trim());
                        nvchon.MaLuong = int.Parse(gvNhanVien.GetRowCellValue(item, ColLuong).ToString().Trim());
                        nvchon.HinhAnh = gvNhanVien.GetRowCellValue(item, ColHA).ToString().Trim();
                        nvchon.NgayVaoLam = DateTime.Parse(gvNhanVien.GetRowCellValue(item, ColNVL).ToString().Trim());
                        nvchon.Password = gvNhanVien.GetRowCellValue(item, ColPass).ToString().Trim();
                        nvchon.MaNV = gvNhanVien.GetRowCellValue(item, ColMaNV).ToString().Trim();
                        txtPass.Enabled = false;
                    }
                    else
                    {
                        nvchon = null;
                    }
                }
            }
            txtTenNV.Text = nvchon.HovaTen;
            dtNS.DateTime = nvchon.NgaySinh;
            if (nvchon.GioiTinh.ToString() == "Nam")
            {
                rdoNam.Checked= true;
                rdoNu.Checked = false;
            }
            else 
            {
                rdoNu.Checked = true;
                rdoNam.Checked = false;
            }
            txtDC.Text = nvchon.DiaChi;
            txtEmail.Text = nvchon.Email;
            dtNVL.DateTime = nvchon.NgayVaoLam;
            lUpLuong.EditValue = nvchon.MaLuong;
            lUpChucVu.EditValue = nvchon.LoaiNV;
            if(File.Exists(nvchon.HinhAnh))
            {
                byte[] byteHA = File.ReadAllBytes(nvchon.HinhAnh);
                MemoryStream ms = new MemoryStream(byteHA);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = null;
            }
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int[] i = gvNhanVien.GetSelectedRows();
            foreach (int rows in i)
            {
                if (rows >= 0)
                {
                    int MaNV = int.Parse(gvNhanVien.GetRowCellValue(rows, ColMaNV).ToString());
                    if (nv_bus.CapNhatNV(nvchon, MaNV) != null)
                    {
                        MessageBox.Show("Cập nhật Thành Công", "Thông Báo");
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
                    }
                }
            }
        }

       

       

        

        
        
    }
}
