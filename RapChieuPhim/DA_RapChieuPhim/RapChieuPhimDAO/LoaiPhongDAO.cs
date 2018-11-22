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
            string strTruyVan = "Select * From CTLoaiPhong Where TrangThai = 1";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<LoaiPhongDTO> ls = new List<LoaiPhongDTO>();
            while (sdr.Read())
            {

                LoaiPhongDTO ketqua = new LoaiPhongDTO();
                ketqua.MaLoai = int.Parse(sdr["Maloai"].ToString());
                ketqua.TenPhong = sdr["TenPhong"].ToString();
                ketqua.HeSo = float.Parse(sdr["HeSo"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }
    }
}
