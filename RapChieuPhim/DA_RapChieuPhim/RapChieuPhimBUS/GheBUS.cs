using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class GheBUS
    {
        public List<GheDTO> LoadGhe()
        {
            GheDAO ghe = new GheDAO();
            return ghe.LoadGhe();
        }

        public List<GheDTO> LoadGhe(int MaPhong)
        {
            GheDAO ghe = new GheDAO();
            return ghe.LoadGhe(MaPhong);
        }
    }
}
