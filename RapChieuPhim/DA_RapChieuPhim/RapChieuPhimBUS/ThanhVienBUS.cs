using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class ThanhVienBUS
    {
        public List<ThanhVienDTO> LoadTV()
        {
            ThanhVienDAO tvDAO = new ThanhVienDAO();
            return tvDAO.LoadTV();
        }
        public List<ThanhVienDTO> ThemTVien(string TenTV, string LoaiTV,int CMND,DateTime NgaySinh)
        {
            ThanhVienDAO ThemTV = new ThanhVienDAO();
            return ThemTV.ThemThanhVien(TenTV, LoaiTV, CMND, NgaySinh);
        }
    }
}
