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
        public QLTV()
        {
            InitializeComponent();
            loadLoaiTV();
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
            gcThanhVien.DataSource = tv.LoadTV();
        }

       
        private void BtnThem_Click(object sender, EventArgs e)
        {
            //if (txtTenTV.Text == "" && txtCMND.Text == "")
            //{
            //    MessageBox.Show("Bạn phải nhập đầy đủ thông  tin!");
            //}
            //else
            //{
                
            //    string TenTV = txtTenTV.Text;
            //    int LoaiTV = (int)lookUpEdit1.EditValue;
            //    int CMND = int.Parse(txtCMND.Text);
            //    DateTime NS = DateTime.Parse(dtNS.Text);
            //    int MaVoucher=1;
            //    List<ThanhVienDTO> kq = tv.ThemTVien(TenTV, LoaiTV, CMND, NS, MaVoucher);
            //    if (kq != null)
            //    {
            //        MessageBox.Show("Thêm Thành Công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm Thất Bại");
            //    }
            //}
        }

       

       

       

        
    }
}
