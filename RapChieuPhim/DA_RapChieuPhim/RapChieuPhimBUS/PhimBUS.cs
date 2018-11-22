using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class PhimBUS
    {
        public List<PhimDTO> LoadPhim()
        {
            PhimDAO phim = new PhimDAO();
            return phim.LoadPhim();
        }
        public List<PhimDTO> LoadPhimm()
        {
            PhimDAO phim = new PhimDAO();
            return phim.LoadPhimm();
        }
        public List<PhimDTO> LoadPhim(int MaLich)
        {
            PhimDAO phim = new PhimDAO();
            return phim.LoadPhim(MaLich);
        }
    }
}
