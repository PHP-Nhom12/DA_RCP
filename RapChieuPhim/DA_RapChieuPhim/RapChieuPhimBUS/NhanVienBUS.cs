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
            return nvDAO.DangNhap(strTaiKhoan, strMatKhau.ToMD5());
        }
        public bool doiMatkhau( string matkhaumoi,string matkhaucu, string email)
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            return nvDAO.doiMatkhau( matkhaumoi.ToMD5(),matkhaucu.ToMD5(), email);
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
        public bool ThemNV(NhanVienDTO nv)
        {
            nv.Password = nv.Password.ToMD5();
            NhanVienDAO nvDao = new NhanVienDAO();
            return nvDao.ThemNhanVien(nv);
        }
        public int XoaNV(string MaNV)
        {
            NhanVienDAO nvDao = new NhanVienDAO();
            return nvDao.XoaNhanVien(MaNV);
        }
        public int CapNhatNV(NhanVienDTO nv)
        {
            NhanVienDAO nvDao = new NhanVienDAO();
            return nvDao.CapNhatNhanVien(nv);
        }

    }
}
