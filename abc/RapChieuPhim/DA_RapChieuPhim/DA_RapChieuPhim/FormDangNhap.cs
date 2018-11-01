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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
            //Kiểm tra nhập trên Form
            if(txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập thông tin tài khoản");
            }
            else
            {
                NhanVienBUS nvBUS = new NhanVienBUS();
                NhanVienDTO nvdn = nvBUS.KiemTraDangNhap(txtTK.Text,txtMK.Text);
                if(nvdn != null)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Form1 fcha = (Form1)this.MdiParent;
                    fcha.nvDangNhap = nvdn;
                    fcha.SetDangNhapThanhCong();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
           }
        }
    }
}
