using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class PhongDAO
    {
        public List<PhongDTO> LoadDSPhong()
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From PhongChieu where TrangThai=1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<PhongDTO> ls = new List<PhongDTO>();
            while (sdr.Read())
            {
                PhongDTO ketqua = new PhongDTO();
                ketqua.MaPhong = int.Parse(sdr["MaPhong"].ToString());
                ketqua.TenPhong = sdr["TenPhong"].ToString();
                ketqua.LoaiPhong = int.Parse(sdr["LoaiPhong"].ToString());
                ketqua.SLCho = int.Parse(sdr["SLCho"].ToString());
                //ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }
        public List<PhongDTO> ThemPhong(int MaPhong, string TenPhong, int LoaiPhong, int SLCho)
        {
            string strTruyVan = "INSERT INTO PhongChieu(MaPhong,TenPhong,LoaiPhong,SLCho,TrangThai)" + " VALUES(@MaPhong,@TenPhong,@LoaiPhong,@SLCho,1)";
            SqlParameter[] par = new SqlParameter[4];
            par[0] = new SqlParameter("@MaPhong", MaPhong);
            par[1] = new SqlParameter("@TenPhong", TenPhong);
            par[2] = new SqlParameter("@LoaiPhong", LoaiPhong);
            par[3] = new SqlParameter("@SLCho", SLCho);
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            List<PhongDTO> ls = new List<PhongDTO>();
            while (sdr.Read())
            {

                PhongDTO ketqua = new PhongDTO();
                ketqua.MaPhong = int.Parse(sdr["MaPhong"].ToString());
                ketqua.TenPhong = sdr["TenPhong"].ToString();
                ketqua.LoaiPhong = int.Parse(sdr["LoaiPhong"].ToString());
                ketqua.SLCho = int.Parse(sdr["SLCho"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }
        public int XoaPhong(int MaPhong)
        {
            PhongDTO nv = new PhongDTO();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Update PhongChieu Set TrangThai=0 WHERE MaPhong = " + MaPhong;
            SqlCommand com = new SqlCommand(strTruyVan, conn);

            int kq = com.ExecuteNonQuery();

            conn.Close();
            return kq;
        }
        public int CapNhatPhong(PhongDTO phong)
        {
            string strTruyVan = "Update PhongChieu Set TenPhong=@TenPhong, LoaiPhong=@LoaiPhong,SLCho=@SLCho WHERE MaPhong = " + phong.MaPhong;
            SqlParameter[] par = new SqlParameter[3];
            //par[0] = new SqlParameter("@MaPhong", phong.MaPhong);
            par[0] = new SqlParameter("@TenPhong", phong.TenPhong);
            par[1] = new SqlParameter("@LoaiPhong", phong.LoaiPhong);
            par[2] = new SqlParameter("@SLCho", phong.SLCho);
            //par[4] = new SqlParameter("@TrangThai", phong.TrangThai);
            SqlConnection conn = DataProvider.TaoKetNoi();
            return DataProvider.CapNhatDuLieu(strTruyVan, par, conn);

        }
    }
}
