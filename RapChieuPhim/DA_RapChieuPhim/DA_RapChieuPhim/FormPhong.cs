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
    public partial class FormPhong : Form
    {
        PhongBUS pBUS = new PhongBUS();
        LoaiPhongBUS loaiphong = new LoaiPhongBUS();
        PhongDTO phongchon = null;
        
        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;

            gcPhong.DataSource = pBUS.LoadPhong();
            lUpLoaiPhong.Properties.DataSource = loaiphong.LoadLoaiPhong();
            lUpLoaiPhong.Properties.DisplayMember = "MaLoai";
            lUpLoaiPhong.Properties.ValueMember = "MaLoai";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMPhong.Text != "" && txtTenPhong.Text != "" && lUpLoaiPhong.EditValue != null && txtSLCho.Text != "")
            {
                if (phongchon == null)
                {
                    phongchon = new PhongDTO();
                }

                phongchon.MaPhong =int.Parse( txtMPhong.Text);
                phongchon.TenPhong = txtTenPhong.Text;
                phongchon.LoaiPhong = int.Parse(lUpLoaiPhong.EditValue.ToString());
                phongchon.SLCho = int.Parse(txtSLCho.Text);

                if (pBUS.ThemPhongChieu(phongchon))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    gcPhong.DataSource = pBUS.LoadPhong();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                }
                ResetForm();
            }
            else
            {
                MessageBox.Show("Chưa nhập dữ liệu!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gvPhong.SelectedRowsCount == 0)
            {
                MessageBox.Show("Chưa chọn đối tượng để xóa!", "Thông Báo");
            }
            else
            {
                int[] i = gvPhong.GetSelectedRows();
                foreach (int rows in i)
                {
                    if (rows >= 0)
                    {
                        string TenPhong = gvPhong.GetRowCellValue(rows, ColTenPhong).ToString();
                        int MaPhong = int.Parse(gvPhong.GetRowCellValue(rows,ColMaPhong).ToString());
                        DialogResult r = MessageBox.Show("Bạn có chắn chắn muốn xóa phòng '"+TenPhong+"'?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (DialogResult.Yes == r)
                        {
                            if (pBUS.Xoa(MaPhong) >= 1)
                            {
                                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                                gcPhong.DataSource = pBUS.LoadPhong();
                            }
                            else
                            {
                                MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK);
                            }
                        }
                        ResetForm();
                        gcPhong.DataSource = pBUS.LoadPhong();
                    }

                }
            }
        }

        private void ResetForm()
        {
            txtMPhong.Text = "";
            txtTenPhong.Text = "";
            lUpLoaiPhong.EditValue = null;
            txtSLCho.Text = "";
            button2.Enabled = false;
            button3.Enabled=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] i = gvPhong.GetSelectedRows();
            foreach (int rows in i)
            {
                if (rows >= 0)
                {
                    if (phongchon == null)
                    {
                        phongchon = new PhongDTO();
                    }

                    phongchon.TenPhong = txtTenPhong.Text;
                    phongchon.LoaiPhong = int.Parse(lUpLoaiPhong.EditValue.ToString());
                    phongchon.SLCho = int.Parse(txtSLCho.Text);

                    if (pBUS.CapNhat(phongchon) > 0)
                    {
                        MessageBox.Show("Cập nhật Thành Công", "Thông Báo");
                        gcPhong.DataSource = pBUS.LoadPhong();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
                    }
                    ResetForm();
                }
            }
        }

        private void gcPhong_DoubleClick(object sender, EventArgs e)
        {
            if (phongchon != null)
            {
                phongchon = null;
                ResetForm();
                button3.Enabled = false;
                return;
            }
            if (gvPhong.SelectedRowsCount > 0)
            {
                button3.Enabled = true;
                int[] rows = gvPhong.GetSelectedRows();

                foreach (int item in rows)
                {
                    if (item >= 0)
                    {
                        phongchon = new PhongDTO();
                        phongchon.MaPhong = int.Parse(gvPhong.GetRowCellValue(item, ColMaPhong).ToString());
                        phongchon.TenPhong =gvPhong.GetRowCellValue(item, ColTenPhong).ToString().Trim();
                        phongchon.LoaiPhong = int.Parse(gvPhong.GetRowCellValue(item, ColLoaiPhong).ToString());
                        phongchon.SLCho =int.Parse( gvPhong.GetRowCellValue(item, ColSL).ToString());
                        
                    }
                    else
                    {
                        phongchon = null;
                    }
                }
            }
            txtMPhong.Text = phongchon.MaPhong.ToString();
            txtTenPhong.Text = phongchon.TenPhong;
            txtSLCho.Text = phongchon.SLCho.ToString();
            lUpLoaiPhong.EditValue = (int)phongchon.LoaiPhong;

          
        }

        private void gvPhong_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gvPhong.SelectedRowsCount > 0)
            {
                button2.Enabled = true;
            }
        }
    }
}
