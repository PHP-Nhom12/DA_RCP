using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class LoaiNV_DAO
    {
        public List<LoaiNV_DTO> LayLoaiNV()
        {
            string strTruyVan = "Select * From MaLoaiNV";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<LoaiNV_DTO> ls = new List<LoaiNV_DTO>();
            while (sdr.Read())
            {
                
                LoaiNV_DTO ketqua = new LoaiNV_DTO();
                ketqua.MaLoaiNV = int.Parse(sdr["MaLoaiNV"].ToString());
                ketqua.TenLoai = sdr["TenLoai"].ToString();
                ketqua.HeSo = float.Parse(sdr["HeSo"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());              
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }
    }
}
