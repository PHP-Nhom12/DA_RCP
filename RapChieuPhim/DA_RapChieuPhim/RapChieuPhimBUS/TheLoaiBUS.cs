using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class TheLoaiBUS
    {
        public List<TheLoaiDTO> LoadTheLoai()
        {
            TheLoaiDAO tl = new TheLoaiDAO();
            return tl.LoadTheLoai();
        }
    }
}
