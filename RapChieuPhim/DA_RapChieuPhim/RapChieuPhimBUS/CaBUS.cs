using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class CaBUS
    {
        public List<CaDTO> LoadCa()
        {
            CaDAO ca = new CaDAO(); 
            return ca.LoadCa();
        }
    }
}
