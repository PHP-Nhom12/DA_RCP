using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class ChiTietLichChieuDAO
    {
        public ChiTietLichChieuDTO loadCTLC(int MaLich)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From ChiTietLichChieu where MaLich = @MaLich AND TrangThai=1";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaLich", MaLich);
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            ChiTietLichChieuDTO ketqua = new ChiTietLichChieuDTO();
            while (sdr.Read())
            {
                ketqua.MaLich = int.Parse(sdr["MaLich"].ToString());
                ketqua.MaPhim = int.Parse(sdr["MaPhim"].ToString());
                ketqua.MaPhong = int.Parse(sdr["MaPhong"].ToString());
                ketqua.MaCa = int.Parse(sdr["MaCa"].ToString());
                ketqua.ThoiGianBD = sdr["ThoiGianBD"].ToString();
                ketqua.ThoiGianKT = sdr["ThoiGianKT"].ToString();
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
            }
            sdr.Close();
            conn.Close();
            return ketqua;
        }


        public ChiTietLichChieuDTO loadCTLC_TheoMaCa(int MaCa)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From ChiTietLichChieu where MaCa = @MaCa AND TrangThai=1";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaCa", MaCa);
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            ChiTietLichChieuDTO ketqua = new ChiTietLichChieuDTO();
            while (sdr.Read())
            {
                ketqua.MaLich = int.Parse(sdr["MaLich"].ToString());
                ketqua.MaPhim = int.Parse(sdr["MaPhim"].ToString());
                ketqua.MaPhong = int.Parse(sdr["MaPhong"].ToString());
                ketqua.MaCa = int.Parse(sdr["MaCa"].ToString());
                ketqua.ThoiGianBD = sdr["ThoiGianBD"].ToString();
                ketqua.ThoiGianKT = sdr["ThoiGianKT"].ToString();
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
            }
            sdr.Close();
            conn.Close();
            return ketqua;
        }
    }
}
