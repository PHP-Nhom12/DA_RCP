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
            //cbbLoaiTV.DataSource = LoaiTV.LayLoaiTV();
            //cbbLoaiTV.DisplayMember = "TenLoai";
            //cbbLoaiTV.ValueMember = "MaLoai";
            foreach(var a in LoaiTV.LayLoaiTV())
            {
                cbbLoaiTV.Properties.Items.Add(a);
               
            }
        }

        private void LoadThanhVien()
        {
            gcThanhVien.DataSource = tv.LoadTV();
            
            //DataGridViewComboBoxColumn dgvloaitv = (DataGridViewComboBoxColumn)dgvTV.Columns["CoLoaiTV"];
            //dgvloaitv.DataSource = LoaiTV.LoadLoaiOfTV();
            //dgvloaitv.DisplayMember = "TenLoai";
            //dgvloaitv.ValueMember = "MaLoai";

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            //if(txtTenTV.Text==""&&txtCMND.Text=="")
            //{
            //    MessageBox.Show("Bạn phải nhập đầy đủ thông  tin!");
            //}
            //else
            //{
            //    string TenTV = txtTenTV.Text;
            //    string LoaiTV = cbbLoaiTV.SelectedValue.ToString();
            //    int CMND =int.Parse(txtCMND.Text);
            //    DateTime NS = DateTime.Parse(DtNgaySinh.Text);
            //    List<ThanhVienDTO> kq = tv.ThemTVien(TenTV, LoaiTV, CMND, NS);
            //    if(kq!=null)
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
