using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class TheLoaiDAO
    {
        public List<TheLoaiDTO> LoadTheLoai()
        {
            string strTruyVan = "Select * From TheLoai";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<TheLoaiDTO> ls = new List<TheLoaiDTO>();
            while (sdr.Read())
            {

                TheLoaiDTO ketqua = new TheLoaiDTO();
                ketqua.MaTheLoai = sdr["MaTheLoai"].ToString();
                ketqua.TenTheLoai = sdr["TenTheLoai"].ToString();
            }
            sdr.Close();
            return ls;
        }
    }
}
