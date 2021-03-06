﻿using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class LichChieuDAO
    {
        public List<LichChieuDTO> loadLC()
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From LichChieu where TrangThai=1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<LichChieuDTO> ls = new List<LichChieuDTO>();
            while (sdr.Read())
            {
                LichChieuDTO ketqua = new LichChieuDTO();
                ketqua.MaLich = int.Parse(sdr["MaLich"].ToString());               
                ketqua.NgayNhap = DateTime.Parse(sdr["NgayNhap"].ToString());
                ketqua.ThoiGian = DateTime.Parse(sdr["ThoiGian"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }

        public LichChieuDTO loadLC(DateTime ngay)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From LichChieu where ThoiGian = @ThoiGian AND TrangThai=1";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@ThoiGian", ngay);
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            LichChieuDTO ketqua = new LichChieuDTO();
            while (sdr.Read())
            {
                ketqua.MaLich = int.Parse(sdr["MaLich"].ToString());
                ketqua.NgayNhap = DateTime.Parse(sdr["NgayNhap"].ToString());
                ketqua.ThoiGian = DateTime.Parse(sdr["ThoiGian"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
            }
            sdr.Close();
            conn.Close();
            return ketqua;
        }
    }
}
