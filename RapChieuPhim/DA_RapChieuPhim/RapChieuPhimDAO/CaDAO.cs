using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class CaDAO
    {
        public List<CaDTO> LoadCa()
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Ca where TrangThai=1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<CaDTO> ls = new List<CaDTO>();
            while (sdr.Read())
            {
                CaDTO ketqua = new CaDTO();
                ketqua.MaCa = int.Parse(sdr["MaCa"].ToString());
                ketqua.TenCa = sdr["TenCa"].ToString();
                ketqua.HeSo = float.Parse(sdr["HeSo"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }
    }
}
