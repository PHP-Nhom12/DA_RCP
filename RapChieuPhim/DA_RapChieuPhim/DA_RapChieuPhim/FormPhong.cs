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
        
        public FormPhong()
        {
            InitializeComponent();
        }
        PhongBUS pBUS = new PhongBUS();
        PhongDTO phongchon = null;
        private void FormPhong_Load(object sender, EventArgs e)
        {
            gcPhong.DataSource = pBUS.LoadPhong();
            lUpLoaiPhong.Properties.DataSource = pBUS.LoadPhong();
            lUpLoaiPhong.Properties.DisplayMember = "LoaiPhong";
            lUpLoaiPhong.Properties.ValueMember = "MaPhong";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int MP =int.Parse( txtMPhong.Text);
            string TP = txtTenPhong.Text;
            int LP = (int)lUpLoaiPhong.EditValue;
            int SL = int.Parse(txtSLCho.Text);
            List<PhongDTO> kq =pBUS.ThemPhongChieu(MP,TP,LP,SL);
            if(kq!=null)
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                gcPhong.DataSource = pBUS.LoadPhong();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại", "Thông Báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gvPhong.SelectedRowsCount == 0)
            {
                MessageBox.Show("Chưa chọn đối tượng để xóa", "Thông Báo");
            }
            else
            {
                DialogResult r = MessageBox.Show("Bạn có chắn chắn muốn xóa nhân viên", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == r)
                {
                    int[] i = gvPhong.GetSelectedRows();
                    foreach (int rows in i)
                    {
                        if (rows >= 0)
                        {
                            //string Email = gvNhanVien.GetRowCellValue(rows, ColMaNV).ToString();
                            int MaPhong = int.Parse(gvPhong.GetRowCellValue(rows,ColMaPhong).ToString());
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
                        gcPhong.DataSource = pBUS.LoadPhong();
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] i = gvPhong.GetSelectedRows();
            foreach (int rows in i)
            {
                if (rows >= 0)
                {
                    int MaPhong = int.Parse(gvPhong.GetRowCellValue(rows, ColMaPhong).ToString());
                    if (pBUS.CapNhat(phongchon, MaPhong) != null)
                    {
                        MessageBox.Show("Cập nhật Thành Công", "Thông Báo");
                        gcPhong.DataSource = pBUS.LoadPhong();
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
                    }
                }
            }
        }

        private void gcPhong_DoubleClick(object sender, EventArgs e)
        {
            if (gvPhong.SelectedRowsCount > 0)
            {
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
    }
}
