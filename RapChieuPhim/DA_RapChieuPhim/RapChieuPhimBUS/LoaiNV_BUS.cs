using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class LoaiNV_BUS
    {
        public List<LoaiNV_DTO> LayLoaiNV()
        {
            LoaiNV_DAO nvDAO = new LoaiNV_DAO();
            return nvDAO.LayLoaiNV();
        }
    }
}
