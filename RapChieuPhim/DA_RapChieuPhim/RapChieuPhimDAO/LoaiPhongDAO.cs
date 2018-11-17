using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class LoaiPhongDAO
    {
        public List<LoaiPhongDTO> LoadLoaiPhong()
        {
            string strTruyVan = "Select * From CTLoaiPhong";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<LoaiPhongDTO> ls = new List<LoaiPhongDTO>();
            while (sdr.Read())
            {

                LoaiPhongDTO ketqua = new LoaiPhongDTO();
                ketqua.MaLoai = int.Parse(sdr["Maloai"].ToString());
                ketqua.TenPhong = sdr["GiaCB"].ToString();
                ketqua.HeSo = float.Parse(sdr["GiaCB"].ToString());
                ketqua.TrangThai = int.Parse(sdr["GiaCB"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }
    }
}
