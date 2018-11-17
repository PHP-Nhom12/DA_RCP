using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapChieuPhimDTO;
using Microsoft.Reporting.WinForms;
using RapChieuPhimBUS;
using System.Data.SqlClient;

namespace DA_RapChieuPhim
{
    public partial class formXemBaoCao : Form
    {
        List<VeDTO> lsVe;
        List<NhanVienDTO> lsNV;
        List<LuongDTO> lsLuong;
        List<PhimDTO> lsPhim;
        List<CaDTO> lsCa;
        List<LoaiNV_DTO> lsLoaiNV = new List<LoaiNV_DTO>();
        public formXemBaoCao()
        {
            InitializeComponent();
        }

        private void formXemBaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void XemVe(List<VeDTO> lsVe)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_RapChieuPhim.rptVe.rdlc";
            ReportDataSource v = new ReportDataSource("dsVe", lsVe);
            this.reportViewer1.LocalReport.DataSources.Add(v);
            this.reportViewer1.RefreshReport();
        }

        public void XemNv(List<NhanVienDTO> lsNV)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_RapChieuPhim.rptNV.rdlc";
            ReportDataSource n = new ReportDataSource("dsNV", lsNV);
            this.reportViewer1.LocalReport.DataSources.Add(n);
            this.reportViewer1.RefreshReport();
        }

        //public void XemLuong(List<LuongDTO> lsLuong)
        //{
        //    this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_RapChieuPhim.rptLuongNV.rdlc";
        //    ReportDataSource l = new ReportDataSource("dsLuongNV", lsLuong);
        //    this.reportViewer1.LocalReport.DataSources.Add(l);
        //    this.reportViewer1.RefreshReport();
        //}

        public void XemPhim(List<PhimDTO> lsPhim)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_RapChieuPhim.rptPhim.rdlc";
            ReportDataSource p = new ReportDataSource("dsPhim", lsPhim);
            this.reportViewer1.LocalReport.DataSources.Add(p);
            this.reportViewer1.RefreshReport();
        }

        //internal void XemGiaVeTheoCa (List<VeDTO> dsVe, CaDTO caChon)
        //{ 
        //    this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_RapChieuPhim.rptGiaVeTheoCa.rdlc";
        //    ReportDataSource p = new ReportDataSource("dsGiaVeTheoCa", lsCa);
        //    this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paTenCa", caChon.TenCa));
        //    this.reportViewer1.RefreshReport();
        //}

        //internal void XemLuongNV(List<LuongDTO> lsLuong, NhanVienDTO NV)
        //{
        //    this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_RapChieuPhim.rptLuongNV.rdlc";
        //    ReportDataSource l = new ReportDataSource("dsLuongNV", lsLuong);
        //    this.reportViewer1.LocalReport.DataSources.Add(l);
        //    this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paTenNV", NV.HovaTen));
        //    this.reportViewer1.RefreshReport();
        //}


       

        public void XemLuongNV()
        {
            List<NhanVienDTO> lsNv = (new NhanVienBUS()).LoadDSNVien();
            lsLuong = (new LuongBUS()).LuongNV();
            lsLoaiNV = (new LoaiNV_BUS()).LayLoaiNV();

            reportViewer1.LocalReport.ReportEmbeddedResource = "DA_RapChieuPhim.rptLuongNV.rdlc";
            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LayLuongSub);
            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LayHeSoSub);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsNhanVien", lsNv));

            NhanVienDTO maNv = new NhanVienDTO();
            double luongnv = (new LuongBUS()).TinhLuongTungNV(maNv);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paLuongTungNV", luongnv.ToString()));

            double luong = (new LuongBUS()).TongLuong() ;
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paTongLuong", luong.ToString()));
            reportViewer1.RefreshReport();
            
        }

        private void LayHeSoSub(object sender, SubreportProcessingEventArgs e)
        {
            string maLoai = e.Parameters["paLoaiNV"].Values[0].ToString();
            List<LoaiNV_DTO> lsLoai = lsLoaiNV.FindAll(o => o.MaLoaiNV == int.Parse(maLoai));
            e.DataSources.Add(new ReportDataSource("dsHeSo", lsLoai));

        }

        private void LayLuongSub(object sender, SubreportProcessingEventArgs e)
        {

            string maLoaiNV = e.Parameters["paLoaiNV"].Values[0].ToString();
            List<LuongDTO> lsLuongnv = lsLuong.FindAll(o => o.MaLoaiNV == int.Parse(maLoaiNV));
            e.DataSources.Add(new ReportDataSource("dsLuongnv", lsLuongnv));

        }
    }
}

 	
