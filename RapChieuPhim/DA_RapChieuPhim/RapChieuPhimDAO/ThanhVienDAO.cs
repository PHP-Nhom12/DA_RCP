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
            string strTruyVan = "Select * From ThanhVien";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<ThanhVienDTO> ls = new List<ThanhVienDTO>();
            while (sdr.Read())
            {

                ThanhVienDTO ketqua = new ThanhVienDTO();
                ketqua.MaTV = int.Parse(sdr["MaTV"].ToString());
                ketqua.TenTV = sdr["TenTV"].ToString();
                ketqua.LoaiTV = sdr["LoaiTV"].ToString();
                ketqua.CMND= int.Parse(sdr["CMND"].ToString());
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }
        public List<ThanhVienDTO> ThemThanhVien(string TenTV, string LoaiTV,int CMND,DateTime NgaySinh)
        {
            string strTruyVan = "INSERT INTO ThanhVien(TenTV,LoaiTV,CMND,NgaySinh) VALUES(@TenTV,@LoaiTV,@CMND,@NgaySinh)";
            SqlParameter[] par = new SqlParameter[4];
            par[0] = new SqlParameter("@TenTV", TenTV);
            par[1] = new SqlParameter("@LoaiTV", LoaiTV);
            par[2] = new SqlParameter("@CMND", CMND);
            par[3] = new SqlParameter("@NgaySinh", NgaySinh);
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan,par, conn);
            List<ThanhVienDTO> ls = new List<ThanhVienDTO>();
            while (sdr.Read())
            {

                ThanhVienDTO ketqua = new ThanhVienDTO();
                ketqua.MaTV = int.Parse(sdr["MaTV"].ToString());
                ketqua.TenTV = sdr["TenTV"].ToString();
                ketqua.LoaiTV = sdr["LoaiTV"].ToString();
                ketqua.CMND = int.Parse(sdr["CMND"].ToString());
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }

    }
}
