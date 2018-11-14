using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class ThanhVienDAO
    {
        public List<ThanhVienDTO> LoadTV()
        {
            string strTruyVan = "Select * From ThanhVien Where TrangThai = 1";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<ThanhVienDTO> ls = new List<ThanhVienDTO>();
            while (sdr.Read())
            {

                ThanhVienDTO ketqua = new ThanhVienDTO();
                ketqua.MaTV = int.Parse(sdr["MaTV"].ToString());
                ketqua.TenTV = sdr["TenTV"].ToString();
                ketqua.LoaiTV = int.Parse(sdr["LoaiTV"].ToString());
                ketqua.CMND= int.Parse(sdr["CMND"].ToString());
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }
        public List<ThanhVienDTO> ThemThanhVien(string TenTV, int LoaiTV,int CMND,DateTime NgaySinh, int TrangThai)
        {
            string strTruyVan = "INSERT INTO ThanhVien(TenTV,LoaiTV,CMND,NgaySinh,TrangThai) VALUES(@TenTV,@LoaiTV,@CMND,@NgaySinh,@TrangThai)";
            SqlParameter[] par = new SqlParameter[5];
            par[0] = new SqlParameter("@TenTV", TenTV);
            par[1] = new SqlParameter("@LoaiTV", LoaiTV);
            par[2] = new SqlParameter("@CMND", CMND);
            par[3] = new SqlParameter("@NgaySinh", NgaySinh);
            par[4] = new SqlParameter("@TrangThai", TrangThai);
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan,par, conn);
            List<ThanhVienDTO> ls = new List<ThanhVienDTO>();
            while (sdr.Read())
            {

                ThanhVienDTO ketqua = new ThanhVienDTO();
                ketqua.MaTV = int.Parse(sdr["MaTV"].ToString());
                ketqua.TenTV = sdr["TenTV"].ToString();
                ketqua.LoaiTV = int.Parse(sdr["LoaiTV"].ToString());
                ketqua.CMND = int.Parse(sdr["CMND"].ToString());
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }

        public int XoaThanhVien(string MaTV)
        {
            ThanhVienDTO nv = new ThanhVienDTO();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Update ThanhVien Set TrangThai=0 WHERE MaTV = " + MaTV;
            SqlCommand com = new SqlCommand(strTruyVan, conn);

            int kq = com.ExecuteNonQuery();

            conn.Close();
            return kq;
        }

         public  int CapNhatThanhVien(ThanhVienDTO tv)
        {
            string strTruyVan = "Update ThanhVien Set TenTV=@TenTV,LoaiTV=@LoaiTV,CMND=@CMND,NgaySinh=@NgaySinh,TrangThai=@TrangThai Where MaTV = " + tv.MaTV;
            SqlParameter[] par = new SqlParameter[5];
            par[0] = new SqlParameter("@TenTV", tv.TenTV);
            par[1] = new SqlParameter("@LoaiTV", tv.LoaiTV);
            par[2] = new SqlParameter("@CMND", tv.CMND);
            par[3] = new SqlParameter("@NgaySinh", tv.NgaySinh);
            par[4] = new SqlParameter("@TrangThai", tv.TrangThai);
            SqlConnection conn = DataProvider.TaoKetNoi();
            return DataProvider.CapNhatDuLieu(strTruyVan, par, conn);
         }
    }
}
