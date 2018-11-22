using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class VeBUS
    {
        public List<VeDTO> LoadVe()
        {
            VeDAO ve = new VeDAO();
            return ve.LoadVe();
        }

        public List<VeDTO> TimVe ( int MaFilter, string strQuery )
        {
            VeDAO ve = new VeDAO();
            return ve.TimVe(MaFilter, strQuery);
        }

        public bool ThemVe(VeDTO venew)
        {
            VeDAO ve = new VeDAO();
            return ve.ThemVe(venew);
        }

        public bool ThemVe(List<VeDTO> lsVe)
        {
            VeDAO ve = new VeDAO();
            return ve.ThemVe(lsVe);
        }

        public bool XoaVe(int MaVe)
        {
            VeDAO ve = new VeDAO();
            return ve.XoaVe(MaVe);
        }
    }
}
