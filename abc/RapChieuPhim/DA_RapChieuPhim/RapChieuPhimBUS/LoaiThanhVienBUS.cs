using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class LoaiThanhVienBUS
    {
        public List<LoaiThanhVienDTO> LayLoaiTV()
        {
            LoaiThanhVienDAO tvDAO = new LoaiThanhVienDAO();
            return tvDAO.LoadLoaiTV();
        }

        public List<LoaiThanhVienDTO> LoadLoaiOfTV()
        {
            LoaiThanhVienDAO tvDAO = new LoaiThanhVienDAO();
            return tvDAO.LoadLoaiOfTvien();
        }
    }
}
