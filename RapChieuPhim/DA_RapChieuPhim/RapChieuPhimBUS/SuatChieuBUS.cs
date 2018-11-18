using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class SuatChieuBUS
    {
        public List<SuatChieuDTO> LoadSuatChieu(int MaLich)
        {
            SuatChieuDAO sc = new SuatChieuDAO();
            return sc.LoadSuatChieu(MaLich);
        }
    }
}
