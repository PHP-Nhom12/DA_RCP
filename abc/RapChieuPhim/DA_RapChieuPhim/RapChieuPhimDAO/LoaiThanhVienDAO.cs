using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
   public class LoaiThanhVienDAO
    {
       public List<LoaiThanhVienDTO> LoadLoaiTV()
       {
           string strTruyVan = "Select * From LoaiTV";
           SqlConnection conn = DataProvider.TaoKetNoi();
           SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
           List<LoaiThanhVienDTO> ls = new List<LoaiThanhVienDTO>();
           while (sdr.Read())
           {

               LoaiThanhVienDTO ketqua = new LoaiThanhVienDTO();
               ketqua.ID = int.Parse(sdr["ID"].ToString());
               ketqua.MaLoai = sdr["MaLoai"].ToString();
               ketqua.TenLoai = sdr["TenLoai"].ToString();
               ls.Add(ketqua);
           }
           sdr.Close();
           return ls;
       }
       public List<LoaiThanhVienDTO> LoadLoaiOfTvien()
       {
           string strTruyVan = "Select * From ThanhVien,LoaiTV where ThanhVien.LoaiTV=LoaiTV.MaLoai";
           SqlConnection conn = DataProvider.TaoKetNoi();
           SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
           List<LoaiThanhVienDTO> ls = new List<LoaiThanhVienDTO>();
           while (sdr.Read())
           {

               LoaiThanhVienDTO ketqua = new LoaiThanhVienDTO();
               ketqua.ID = int.Parse(sdr["ID"].ToString());
               ketqua.MaLoai = sdr["MaLoai"].ToString();
               ketqua.TenLoai = sdr["TenLoai"].ToString();
               ls.Add(ketqua);
           }
           sdr.Close();
           return ls;
       }
    }
}
