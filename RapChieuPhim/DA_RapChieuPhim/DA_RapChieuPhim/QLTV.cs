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
        LoaiThanhVienBUS LoaiTV = new LoaiThanhVienBUS();
        public QLTV()
        {
            InitializeComponent();
           // dgvTV.AutoGenerateColumns = false;
        }

        private void QLTV_Load(object sender, EventArgs e)
        {
            LoadThanhVien();
            LoadLoaiTV();
        }

        private void LoadLoaiTV()
        {
            lookUpEdit1.Properties.DataSource = LoaiTV.LayLoaiTV();
            lookUpEdit1.Properties.DisplayMember = "TenLoai";
            lookUpEdit1.Properties.ValueMember = "MaLoai";

            LUpLoaiTV.DataSource = LoaiTV.LoadLoaiOfTV(); ;
        }

        private void LoadThanhVien()
        {
            gcThanhVien.DataSource = tv.LoadTV();
            
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTV.Text == "" && txtCMND.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông  tin!");
            }
            else
            {
                
                string TenTV = txtTenTV.Text;
                int LoaiTV = (int)lookUpEdit1.EditValue;
                int CMND = int.Parse(txtCMND.Text);
                DateTime NS = DateTime.Parse(dtNS.Text);
                int MaVoucher=1;
                List<ThanhVienDTO> kq = tv.ThemTVien(TenTV, LoaiTV, CMND, NS, MaVoucher);
                if (kq != null)
                {
                    MessageBox.Show("Thêm Thành Công");
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại");
                }
            }
        }

       

       

        
    }
}
