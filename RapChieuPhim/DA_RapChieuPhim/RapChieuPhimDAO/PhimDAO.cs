﻿using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class PhimDAO
    {
        public List<PhimDTO> LoadPhim()
        {
             SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Movie where TrangThai=1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<PhimDTO> ls = new List<PhimDTO>();
            while (sdr.Read())
            {
                PhimDTO ketqua = new PhimDTO();
                ketqua.MaPhim = int.Parse(sdr["MaPhim"].ToString());
                ketqua.TenPhim = sdr["TenPhim"].ToString();
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }


        public List<PhimDTO> LoadPhim(int MaCa)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Movie, ChiTietLichChieu where Movie.MaPhim = ChiTietLichChieu.MaPhim AND ChiTietLichChieu.MaCa = @MaCa AND ChiTietLichChieu.TrangThai=1";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaCa", MaCa);
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            List<PhimDTO> ls = new List<PhimDTO>();
            while (sdr.Read())
            {
                PhimDTO ketqua = new PhimDTO();
                ketqua.MaPhim = int.Parse(sdr["MaPhim"].ToString());
                ketqua.Mac = sdr["Mac"].ToString();
                ketqua.NDPhim = sdr["NDPhim"].ToString();
                ketqua.TenPhim = sdr["TenPhim"].ToString();
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }
    }
}
