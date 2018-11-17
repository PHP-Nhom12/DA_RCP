using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class GheDAO
    {
        public List<GheDTO> LoadGhe()
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Ghe where TrangThai=1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<GheDTO> ls = new List<GheDTO>();
            while (sdr.Read())
            {
                GheDTO ketqua = new GheDTO();
                ketqua.MaGhe = sdr["MaGhe"].ToString();
                ketqua.MaPhong = int.Parse(sdr["MaPhong"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;

        }
        public List<GheDTO> LoadGhe(int MaPhong)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Ghe where TrangThai=1 AND MaPhong = @MaPhong";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaPhong", MaPhong);
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            List<GheDTO> ls = new List<GheDTO>();
            while (sdr.Read())
            {
                GheDTO ketqua = new GheDTO();
                ketqua.MaGhe = sdr["MaGhe"].ToString();
                ketqua.MaPhong = int.Parse(sdr["MaPhong"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;

        }
    }
}
