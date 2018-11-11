using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class VeDAO
    {
        public List<VeDTO> LoadVe()
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Ve where TrangThai=1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<VeDTO> ls = new List<VeDTO>();
            while (sdr.Read())
            {
                VeDTO ketqua = new VeDTO();
                ketqua.MaPhim = int.Parse(sdr["MaPhim"].ToString());
                ketqua.ViTriNgoi = sdr["ViTriNgoi"].ToString();
                ketqua.PhongChieu = int.Parse(sdr["PhongChieu"].ToString());
                ketqua.GiaVe = int.Parse(sdr["GiaVe"].ToString());
                ketqua.MaTV = int.Parse(sdr["MaTV"].ToString());
                //ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        
        }
    }
}
