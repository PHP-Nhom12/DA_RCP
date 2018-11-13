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
                //ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsVe.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return lsVe;
        }

        public List<VeDTO> ThemVe(VeDTO ve)
        {
            //SqlConnection conn = DataProvider.TaoKetNoi();

            //string strTruyVan = "INSERT INTO Ve(TenTV,LoaiTV,CMND,NgaySinh) VALUES(@TenTV,@LoaiTV,@CMND,@NgaySinh,@TrangThai)";
            //SqlParameter[] par = new SqlParameter[5];
            //par[0] = new SqlParameter("@TenTV", TenTV);
            //par[1] = new SqlParameter("@LoaiTV", LoaiTV);
            //par[2] = new SqlParameter("@CMND", CMND);
            //par[3] = new SqlParameter("@NgaySinh", NgaySinh);
            //par[4] = new SqlParameter("@TrangThai", TrangThai);
            //SqlConnection conn = DataProvider.TaoKetNoi();
            //SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            List<VeDTO> ls = new List<VeDTO>();
            //while (sdr.Read())
            //{

            //    ThanhVienDTO ketqua = new ThanhVienDTO();
            //    ketqua.MaTV = int.Parse(sdr["MaTV"].ToString());
            //    ketqua.TenTV = sdr["TenTV"].ToString();
            //    ketqua.LoaiTV = int.Parse(sdr["LoaiTV"].ToString());
            //    ketqua.CMND = int.Parse(sdr["CMND"].ToString());
            //    ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
            //    ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
            //    ls.Add(ketqua);
            //}
            //sdr.Close();
            return ls;
        }
    }
}
