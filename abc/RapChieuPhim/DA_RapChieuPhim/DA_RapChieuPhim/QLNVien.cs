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
    public partial class QLNV : Form
    {
        LuongBUS nv = new LuongBUS();
        LoaiNV_BUS Loai = new LoaiNV_BUS();
        NhanVienBUS nv_bus = new NhanVienBUS();
        public QLNV()
        {
            InitializeComponent();
           //gcNhanVien.AutoGenerateColumns = false;
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            loadLoai();
            loadNV();
            loadLuong();
        }

        public void loadNV()
        {
            gcNhanVien.DataSource = nv_bus.LoadDSNVien();
        }
        public void loadLoai()
        {
            //DataGridViewComboBoxColumn dgvloainv = (DataGridViewComboBoxColumn)gcNhanVien.Columns["ColMaLoai"];
            //dgvloainv.DataSource = nv_bus.loadLoai();
            //dgvloainv.DisplayMember = "TenLoai";
            //dgvloainv.ValueMember = "MaLoaiNV";
            
            

            
        }

        private void loadLuong()
        {
            //cbbLuong.DataSource = nv.LuongNV();
            //cbbLuong.DisplayMember = "LuongCB";
            //cbbLuong.ValueMember = "MaLuong";
            //var a = nv.LuongNV();
            foreach (var i in nv.LuongNV())
            {
                cbbLuong.Properties.Items.Add(i);
            }
            
            //cbbCVu.DataSource = Loai.LayLoaiNV();
            //cbbCVu.DisplayMember = "TenLoai";
            //cbbCVu.ValueMember = "MaLoaiNV";

           
            //DataGridViewComboBoxColumn dgvLuong = (DataGridViewComboBoxColumn)dgvNhanVien.Columns["ColLuongCB"];
            //dgvLuong.DataSource = nv.LuongOfNVien();
            //dgvLuong.DisplayMember = "LuongCB";
            //dgvLuong.ValueMember = "MaLuong";
//            public void SetupLookup() {

//    lookUpEdit1.Properties.DataSource = dsStorage1.Countries;

//    lookUpEdit1.Properties.DisplayMember = "Name";

//    lookUpEdit1.Properties.ValueMember = "ID";

//    DevExpress.XtraEditors.Controls.LookUpColumnInfo col;

//    col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Country", 100);

//    col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

//    lookUpEdit1.Properties.Columns.Add(col);

//}
        }

       

       

       

        

        
    }
}
