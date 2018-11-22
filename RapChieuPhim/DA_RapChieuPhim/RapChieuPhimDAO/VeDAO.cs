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
                ketqua.MaVe = int.Parse(sdr["MaVe"].ToString());
                ketqua.MaPhim = int.Parse(sdr["MaPhim"].ToString());
                ketqua.ViTriNgoi = sdr["ViTriNgoi"].ToString();
                ketqua.PhongChieu = int.Parse(sdr["PhongChieu"].ToString());
                ketqua.GiaVe = int.Parse(sdr["GiaVe"].ToString());
                ketqua.MaTV = int.Parse(sdr["MaTV"].ToString());
                ketqua.MaVoucher = int.Parse(sdr["MaVoucher"].ToString());
                ketqua.TGBatDau = sdr["TGBatDau"].ToString();
                ketqua.TGKetThuc = sdr["TGKetThuc"].ToString();
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        
        }

        public List<VeDTO> TimVe ( int MaFilter, string strQuery )
        {
            SqlConnection conn = DataProvider.TaoKetNoi();

            string strTruyVan;

            switch (MaFilter)
            {
                // Tim theo Phong
                case 1:
                    strTruyVan = "Select * From Ve, PhongChieu where Ve.PhongChieu = PhongChieu.MaPhong AND Ve.TrangThai=1 AND TenPhong LIKE N'%" + strQuery + "%'";
                    break;
                // Tim theo ThanhVien
                case 2:
                    strTruyVan = "Select * From Ve, ThanhVien where Ve.MaTV = ThanhVien.MaTV AND Ve.TrangThai=1 AND TenTV LIKE N'%" + strQuery + "%'";
                    break;
                // Tim theo Phim
                case 3:
                    strTruyVan = "Select * From Ve, Movie where Ve.MaPhim = Movie.MaPhim AND Ve.TrangThai=1 AND TenPhim LIKE N'%" + strQuery + "%'";
                    break;
                default:
                    strTruyVan = "Select * From Ve, Movie, PhongChieu, ThanhVien where  Ve.TrangThai=1 AND Ve.MaPhim = Movie.MaPhim AND Ve.PhongChieu = PhongChieu.MaPhong AND Ve.MaTV = ThanhVien.MaTV AND TenPhim LIKE N'%" + strQuery + "%' OR ViTriNgoi LIKE N'%" + strQuery + "%' OR TenPhong LIKE N'%" + strQuery + "%' OR GiaVe LIKE N'%" + strQuery + "%' OR TenTV LIKE N'%" + strQuery + "%'";
                    break;
            }

            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            
            List<VeDTO> lsVe = new List<VeDTO>();
            while (sdr.Read())
            {
                VeDTO ketqua = new VeDTO();
                ketqua.MaPhim = int.Parse(sdr["MaPhim"].ToString());
                ketqua.ViTriNgoi = sdr["ViTriNgoi"].ToString();
                ketqua.PhongChieu = int.Parse(sdr["PhongChieu"].ToString());
                ketqua.GiaVe = int.Parse(sdr["GiaVe"].ToString());
                ketqua.MaTV = int.Parse(sdr["MaTV"].ToString());
                ketqua.MaVoucher = int.Parse(sdr["MaVoucher"].ToString());
                ketqua.TGBatDau = sdr["TGBatDau"].ToString();
                ketqua.TGKetThuc = sdr["TGKetThuc"].ToString();
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsVe.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return lsVe;
        }

        public bool ThemVe(VeDTO ve)
        {

            string strTruyVan = "INSERT INTO Ve(MaPhim, ViTriNgoi, PhongChieu, GiaVe, NgayTaoVe, MaVoucher, MaTV, MaLichChieu, TGBatDau, TGKetThuc, TrangThai) VALUES (@MaPhim, @ViTriNgoi, @PhongChieu, @GiaVe, @NgayTaoVe, @MaVoucher, @MaTV, @MaLichChieu, @TGBatDau, @TGKetThuc, 1)";
            SqlParameter[] pars = new SqlParameter[10];
            pars[0] = new SqlParameter("@MaPhim", ve.MaPhim);
            pars[1] = new SqlParameter("@ViTriNgoi", ve.ViTriNgoi);
            pars[2] = new SqlParameter("@PhongChieu", ve.PhongChieu);
            pars[3] = new SqlParameter("@GiaVe", ve.GiaVe);
            pars[4] = new SqlParameter("@NgayTaoVe", ve.NgayTaoVe);
            pars[5] = new SqlParameter("@MaVoucher", ve.MaVoucher);
            pars[6] = new SqlParameter("@MaTV", ve.MaTV);
            pars[7] = new SqlParameter("@MaLichChieu", ve.MaLichChieu);
            pars[8] = new SqlParameter("@TGBatDau", ve.TGBatDau);
            pars[9] = new SqlParameter("@TGKetThuc", ve.TGKetThuc);
            SqlConnection conn = DataProvider.TaoKetNoi();
            return DataProvider.ThucThiCauLenh(strTruyVan, pars, conn);
        }

        public bool ThemVe(List<VeDTO> lsVe)
        {
            foreach (VeDTO vechon in lsVe)
            {
                if (!ThemVe(vechon))
                {
                    return false;
                }
            }
            return true;
        }

        public bool XoaVe(int MaVe)
        {
            VeDTO nv = new VeDTO();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Update Ve Set TrangThai=0 WHERE MaVe = " + MaVe;

            return DataProvider.ThucThiCauLenh(strTruyVan, conn);
        }

    }
}
