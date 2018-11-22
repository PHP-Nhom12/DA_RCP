using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class SuatChieuDAO
    {
        public List<SuatChieuDTO> LoadSuatChieu(int MaLich)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Movie, ChiTietLichChieu, PhongChieu, CTLoaiPhong where Movie.MaPhim = ChiTietLichChieu.MaPhim AND ChiTietLichChieu.MaPhong = PhongChieu.MaPhong AND PhongChieu.LoaiPhong = CTLoaiPhong.MaLoai AND ChiTietLichChieu.MaLich = @MaLich AND Movie.TrangThai=1";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaLich", MaLich);
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            List<SuatChieuDTO> ls = new List<SuatChieuDTO>();
            while (sdr.Read())
            {
                SuatChieuDTO ketqua = new SuatChieuDTO();
                ketqua.MaPhim = int.Parse(sdr["MaPhim"].ToString());
                ketqua.TenPhim = sdr["TenPhim"].ToString();
                ketqua.TheLoai = sdr["TheLoai"].ToString();
                ketqua.ThoiLuong = int.Parse(sdr["ThoiLuong"].ToString());
                ketqua.HinhAnh = sdr["HinhAnh"].ToString();
                ketqua.DaoDien = sdr["DaoDien"].ToString();
                ketqua.NamXS = sdr["NamXS"].ToString();
                ketqua.NhaXS = sdr["NhaXS"].ToString();
                ketqua.NDPhim = sdr["NDPhim"].ToString();
                ketqua.MaPhong = int.Parse(sdr["MaPhong"].ToString());
                ketqua.TenPhong = sdr["TenPhong"].ToString();
                ketqua.Maloai = int.Parse(sdr["Maloai"].ToString());
                ketqua.TenLoaiPhong = sdr["LoaiPhong"].ToString();
                ketqua.SLCho = int.Parse(sdr["SLCho"].ToString());
                ketqua.MaCa = int.Parse(sdr["MaCa"].ToString());
                ketqua.ThoiGianBD = sdr["ThoiGianBD"].ToString();
                ketqua.ThoiGianKT = sdr["ThoiGianKT"].ToString();
                ketqua.Mac = sdr["Mac"].ToString();
                ketqua.MaCa = int.Parse(sdr["MaCa"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }
    }
}
