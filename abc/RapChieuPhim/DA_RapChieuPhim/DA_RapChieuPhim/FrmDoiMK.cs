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
    public partial class FormDoiMK : Form
    {
        NhanVienBUS nvBUS =new NhanVienBUS();
        NhanVienDTO nv =new NhanVienDTO();
        
        public FormDoiMK()
        {
            InitializeComponent();
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(nv.Email);
            
            Form1 fr1 = new Form1();
            FormDangNhap frmDN = new FormDangNhap();
            if (txtMKC.Text != null && txtMKM.Text != null)
            {
                bool kq = nvBUS.doiMatkhau(txtMKC.Text, txtMKM.Text,nv.Email);
                if(kq)
                {
                    this.Close();
                    MessageBox.Show("Đổi Mật Khẩu Thành Công");

                    //frmDN.MdiParent = fr1;
                    
                    //frmDN.Dock = DockStyle.Fill;
                    //frmDN.Show();
                }
                else
                    
                    MessageBox.Show("Đổi mật khẩu thất bại xin thử lại sau");
            }
            else
                MessageBox.Show("Mật Khẩu Xác Nhận Không Chính Xác");
        }

        public void getNVdangnhap(NhanVienDTO nvDangNhap)
        {
            this.nv = nvDangNhap;
        }
            

        }

        
    }

