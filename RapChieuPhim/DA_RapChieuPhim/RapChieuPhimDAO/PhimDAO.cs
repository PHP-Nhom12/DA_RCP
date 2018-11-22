using RapChieuPhimDTO;
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

        public List<PhimDTO> LoadPhimm()
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
                ketqua.Mac = sdr["Mac"].ToString();
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }
        public List<PhimDTO> LoadPhim(int MaLich)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Movie, ChiTietLichChieu, PhongChieu, CTLoaiPhong where Movie.MaPhim = ChiTietLichChieu.MaPhim AND ChiTietLichChieu.MaPhong = PhongChieu.MaPhong AND PhongChieu.LoaiPhong = CTLoaiPhong.MaLoai AND ChiTietLichChieu.MaLich = @MaLich AND Movie.TrangThai=1";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaLich", MaLich);
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
