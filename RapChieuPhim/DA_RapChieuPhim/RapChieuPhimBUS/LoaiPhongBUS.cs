using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class LoaiPhongBUS
    {
        public List<LoaiPhongDTO> LoadLoaiPhong()
        {
            LoaiPhongDAO lp = new LoaiPhongDAO();
            return lp.LoadLoaiPhong();
        }
    }
}
