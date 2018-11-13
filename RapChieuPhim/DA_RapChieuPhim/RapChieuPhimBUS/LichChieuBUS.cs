using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class LichChieuBUS
    {
        public List<LichChieuDTO> LoadLich()
        {
            LichChieuDAO lich = new LichChieuDAO();
            return lich.loadLC();
        }

        public List<LichChieuDTO> LoadLich(DateTime ngay)
        {
            LichChieuDAO lich = new LichChieuDAO();
            return lich.loadLC(ngay);
        }
    }
}
