using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class PhongBUS
    {
        public List<PhongDTO> LoadPhong()
        {
            PhongDAO phong = new PhongDAO();
            return phong.LoadDSPhong();
        }
        public List<PhongDTO> ThemPhongChieu(int MaPhong, string TenPhong, int LoaiPhong, int SLCho)
        {
            PhongDAO pDAO = new PhongDAO();
            return pDAO.ThemPhong(MaPhong,TenPhong,LoaiPhong,SLCho);
        }
        public int Xoa(int MaPhong)
        {
            PhongDAO XoaDAO = new PhongDAO();
            return XoaDAO.XoaPhong(MaPhong);
        }
        public PhongDTO CapNhat(PhongDTO phong,int MaPhong)
        {
            PhongDAO CapNhat = new PhongDAO();
            return CapNhat.CapNhatPhong(phong,MaPhong);
        }
    }
}
