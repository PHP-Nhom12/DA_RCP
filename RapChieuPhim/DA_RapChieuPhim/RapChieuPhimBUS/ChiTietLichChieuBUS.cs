using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class ChiTietLichChieuBUS
    {
        public List<ChiTietLichChieuDTO> loadCTLC(int MaLich)
        {
            ChiTietLichChieuDAO ctlc = new ChiTietLichChieuDAO();
            return ctlc.loadCTLC(MaLich);
        }

        public List<ChiTietLichChieuDTO> loadCTLC_TheoMaCa(int MaCa)
        {
            ChiTietLichChieuDAO ctlc = new ChiTietLichChieuDAO();
            return ctlc.loadCTLC_TheoMaCa(MaCa);
        }
    }
}
