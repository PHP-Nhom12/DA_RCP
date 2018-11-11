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
                //ketqua.LoaiTV = int.Parse(sdr["LoaiTV"].ToString());
                ketqua.CMND= int.Parse(sdr["CMND"].ToString());
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }
        public List<ThanhVienDTO> ThemThanhVien(string TenTV, int LoaiTV,int CMND,DateTime NgaySinh,int MaVoucher)
        {
            string strTruyVan = "INSERT INTO ThanhVien(TenTV,LoaiTV,CMND,NgaySinh) VALUES(@TenTV,@LoaiTV,@CMND,@NgaySinh,@MaVoucher)";
            SqlParameter[] par = new SqlParameter[5];
            par[0] = new SqlParameter("@TenTV", TenTV);
            par[1] = new SqlParameter("@LoaiTV", LoaiTV);
            par[2] = new SqlParameter("@CMND", CMND);
            par[3] = new SqlParameter("@NgaySinh", NgaySinh);
            par[4] = new SqlParameter("@MaVoucher", MaVoucher);
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
                ketqua.MaVoucher = int.Parse(sdr["MaVoucher"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }

    }
}
