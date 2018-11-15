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
        public List<PhongDTO> LoadPhong(int MaPhim)
        {
            PhongDAO phong = new PhongDAO();
            return phong.LoadDSPhong(MaPhim);
        }
        public bool ThemPhongChieu(PhongDTO phong)
        {
            PhongDAO pDAO = new PhongDAO();
            return pDAO.ThemPhong(phong);
        }
        public int Xoa(int MaPhong)
        {
            PhongDAO XoaDAO = new PhongDAO();
            return XoaDAO.XoaPhong(MaPhong);
        }
        public int CapNhat(PhongDTO phong)
        {
            PhongDAO CapNhat = new PhongDAO();
            return CapNhat.CapNhatPhong(phong);
        }
    }
}
