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
    public partial class QLTV : Form
    {
        ThanhVienBUS tv = new ThanhVienBUS();
        LoaiThanhVienBUS LoaiTVien = new LoaiThanhVienBUS();
        ThanhVienDTO tvchon = new ThanhVienDTO();

        public QLTV()
        {
            InitializeComponent();
        }

        private void loadLoaiTV()
        {
            lookUpEdit1.Properties.DataSource = LoaiTVien.LayLoaiTV();
            lookUpEdit1.Properties.DisplayMember = "TenLoai";
            lookUpEdit1.Properties.ValueMember = "MaLoai";

            LUpLoaiTV.DataSource = LoaiTVien.LayLoaiTV();
        }

        private void QLTV_Load(object sender, EventArgs e)
        {
            LoadDSTV();
        }


        private void BtnThem_Click(object sender, EventArgs e)
        {


            getDataDetail();
            string TenTV = txtTenTV.Text;
            int LoaiTV = int.Parse(lookUpEdit1.EditValue.ToString());
            int CMND = int.Parse(txtCMND.Text);
            DateTime NS = DateTime.Parse(dtNS.EditValue.ToString());
            int TrangThai = 1;
            List<ThanhVienDTO> kq = tv.ThemTVien(TenTV, LoaiTV, CMND, NS, TrangThai);
            if (kq != null)
            {
                MessageBox.Show("Thêm Thành Công");
                LoadDSTV();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }
        }

        private void LoadDSTV()
        {
            gcThanhVien.DataSource = tv.LoadTV();
            loadLoaiTV();
        }

        private void getDataDetail()
        {
            if (tvchon == null)
            {
                tvchon = new ThanhVienDTO();
            }

            tvchon.TenTV = txtTenTV.Text;
            tvchon.LoaiTV = int.Parse(lookUpEdit1.EditValue.ToString());
            tvchon.CMND = int.Parse(txtCMND.Text);
            tvchon.NgaySinh = DateTime.Parse(dtNS.Text);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvThanhVien.SelectedRowsCount == 0)
            {
                MessageBox.Show("Chưa chọn đối tượng để xóa", "Thông Báo");
            }
            else
            {
                DialogResult r = MessageBox.Show("Bạn có chắn chắn muốn xóa nhân viên", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == r)
                {
                    int[] i = gvThanhVien.GetSelectedRows();
                    foreach (int rows in i)
                    {
                        if (rows >= 0)
                        {
                            //string Email = gvNhanVien.GetRowCellValue(rows, ColMaNV).ToString();
                            string MaTV = gvThanhVien.GetRowCellValue(rows, ColMaTV).ToString();
                            if (tv.XoaTV(MaTV) >= 1)
                            {
                                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);

                            }
                            else
                            {
                                MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK);
                            }
                        }
                        gcThanhVien.DataSource = tv.LoadTV();
                    }

                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int[] i = gvThanhVien.GetSelectedRows();
            foreach (int rows in i)
            {
                if (rows >= 0)
                {

                    tvchon.TenTV = txtTenTV.Text;
                    tvchon.LoaiTV = int.Parse(lookUpEdit1.EditValue.ToString());
                    tvchon.CMND = int.Parse(txtCMND.Text);
                    tvchon.NgaySinh = DateTime.Parse(dtNS.Text);
                    tvchon.TrangThai = 1;
                    if (tv.CapNhatTV(tvchon) > 0)
                    {
                        MessageBox.Show("Cập nhật Thành Công", "Thông Báo");
                        gcThanhVien.DataSource = tv.LoadTV();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
                    }
                }
            }
        }

        private void gcThanhVien_DoubleClick(object sender, EventArgs e)
        {
            if (gvThanhVien.SelectedRowsCount > 0)
            {
                int[] rows = gvThanhVien.GetSelectedRows();

                foreach (int item in rows)
                {
                    if (item >= 0)
                    {
                        tvchon = new ThanhVienDTO();
                        tvchon.MaTV = int.Parse(gvThanhVien.GetRowCellValue(item, ColMaTV).ToString().Trim());
                        tvchon.TenTV = gvThanhVien.GetRowCellValue(item, ColTenTVien).ToString().Trim();
                        tvchon.LoaiTV = int.Parse(gvThanhVien.GetRowCellValue(item, ColLoaiTv).ToString().Trim());
                        tvchon.CMND = int.Parse(gvThanhVien.GetRowCellValue(item, ColCMNDan).ToString().Trim());
                        tvchon.NgaySinh = DateTime.Parse(gvThanhVien.GetRowCellValue(item, ColNS).ToString().Trim());
                    }
                    else
                    {
                        tvchon = null;
                    }
                    txtTenTV.Text = tvchon.TenTV;
                    lookUpEdit1.EditValue = tvchon.LoaiTV.ToString();
                    txtCMND.Text = tvchon.CMND.ToString();
                    dtNS.DateTime = tvchon.NgaySinh;

                }
            }
        }
    }
}

    


