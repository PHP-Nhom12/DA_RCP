using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class NhanVienBUS
    {
        public NhanVienDTO KiemTraDangNhap(string strTaiKhoan, string strMatKhau)
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            return nvDAO.DangNhap(strTaiKhoan, strMatKhau);
        }
        public bool doiMatkhau( string matkhaumoi,string matkhaucu, string email)
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            return nvDAO.doiMatkhau( matkhaumoi,matkhaucu, email);
        }
        public List<NhanVienDTO> LoadDSNVien()
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            return nvDAO.LoadDSNV();
        }

        public List<LoaiNV_DTO> loadLoai()
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            return nvDAO.loadLoaiNV();
        }
        public List<LuongDTO> loadLuong()
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            return nvDAO.loadLuong();
        }
        public List<NhanVienDTO> ThemNV(string TenNV, DateTime NS, int GT, string DC, string Email, string Pass, string Ha, DateTime NVL, int LoaiNV, int Maluong, int TrangThai)
        {
            NhanVienDAO nvDao = new NhanVienDAO();
            return nvDao.ThemNhanVien(TenNV,NS,GT,DC,Email,Pass,Ha,NVL,LoaiNV,Maluong,TrangThai);
        }
    }
}
