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
                ketqua.MaVoucher = int.Parse(sdr["MaVoucher"].ToString());
                //ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        
        }

        public List<VeDTO> TimVe ( int MaFilter, string strQuery )
        {
            SqlConnection conn = DataProvider.TaoKetNoi();

            string strTruyVan = "Select * From Ve where TrangThai=1";
            SqlParameter[] par = new SqlParameter[1];

            switch (MaFilter)
            {
                // Tim theo Phong
                case 1:
                    strTruyVan = "Select * From Ve where PhongChieu LIKE %@PhongChieu% AND TrangThai=1";
                    par[0] = new SqlParameter("@PhongChieu", strQuery);
                    break;
                // Tim theo ThanhVien
                case 2:
                    strTruyVan = "Select * From Ve where MaTV LIKE %@MaTV% AND TrangThai=1";
                    par[0] = new SqlParameter("@MaTV", strQuery);
                    break;
                // Tim theo Phim
                case 3:
                    strTruyVan = "Select * From Ve where MaPhim LIKE %@MaPhim% AND TrangThai=1";
                    par[0] = new SqlParameter("@MaPhim", strQuery);
                    break;
                default:
                    break;
            }

            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
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
                //ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsVe.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return lsVe;
        }

        public bool ThemVe(VeDTO ve)
        {

            string strTruyVan = "INSERT INTO Ve(MaPhim, ViTriNgoi, PhongChieu, GiaVe, NgayTaoVe, MaVoucher, MaTV, MaLichChieu, TrangThai) VALUES (@MaPhim, @ViTriNgoi, @PhongChieu, @GiaVe, @NgayTaoVe, @MaVoucher, @MaTV, @MaLichChieu, 1)";
            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("@MaPhim", ve.MaPhim);
            pars[1] = new SqlParameter("@ViTriNgoi", ve.ViTriNgoi);
            pars[2] = new SqlParameter("@PhongChieu", ve.PhongChieu);
            pars[3] = new SqlParameter("@GiaVe", ve.GiaVe);
            pars[4] = new SqlParameter("@NgayTaoVe", ve.NgayTaoVe);
            pars[5] = new SqlParameter("@MaVoucher", ve.MaVoucher);
            pars[6] = new SqlParameter("@MaTV", ve.MaTV);
            pars[7] = new SqlParameter("@MaLichChieu", ve.MaLichChieu);
            SqlConnection conn = DataProvider.TaoKetNoi();
            return DataProvider.ThucThiCauLenh(strTruyVan, pars, conn);
        }
    }
}
