using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
   public  class LuongDAO
    {
       public List<LuongDTO> Luong()
       {
           string strTruyVan = "Select * From Luong";
           SqlConnection conn = DataProvider.TaoKetNoi();           
           SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
           List<LuongDTO> ls = new List<LuongDTO>();
           while (sdr.Read())
           {
               LuongDTO ketqua = new LuongDTO();
               ketqua.MaLuong = int.Parse(sdr["MaLuong"].ToString());
              // ketqua.MaNV = sdr["MaNV"].ToString();
               ketqua.NgayLam = DateTime.Parse(sdr["NgayLam"].ToString());
               ketqua.GioVao = DateTime.Parse(sdr["GioVao"].ToString());
               ketqua.GioRa = DateTime.Parse(sdr["GioRa"].ToString());
               ketqua.LoaiCa = int.Parse(sdr["LoaiCa"].ToString());
               ketqua.MaLoaiNV =int.Parse(sdr["MaLoaiNV"].ToString());
               ketqua.LuongCB = float.Parse(sdr["LuongCB"].ToString());
               ketqua.HeSoPhatSinh = float.Parse(sdr["HeSoPhatSinh"].ToString());
               ls.Add(ketqua);
           }
           sdr.Close();
           return ls;
       }
       public List<LuongDTO> LuongOfNVien()
       {
           string strTruyVan = "Select * From NhanVien,Luong where NhanVien.MaLuong=Luong.MaLuong";
           SqlConnection conn = DataProvider.TaoKetNoi();
           SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
           List<LuongDTO> ls = new List<LuongDTO>();
           while (sdr.Read())
           {
               LuongDTO ketqua = new LuongDTO();
               ketqua.MaLuong = int.Parse(sdr["MaLuong"].ToString());
               ketqua.MaNV = sdr["MaNV"].ToString();
               ketqua.NgayLam = DateTime.Parse(sdr["NgayLam"].ToString());
               ketqua.GioVao = DateTime.Parse(sdr["GioVao"].ToString());
               ketqua.GioRa = DateTime.Parse(sdr["GioRa"].ToString());
               ketqua.LoaiCa = int.Parse(sdr["LoaiCa"].ToString());
               ketqua.MaLoaiNV = int.Parse(sdr["MaLoaiNV"].ToString());
               ketqua.LuongCB = float.Parse(sdr["LuongCB"].ToString());
               ketqua.HeSoPhatSinh = float.Parse(sdr["HeSoPhatSinh"].ToString());
               ls.Add(ketqua);
           }
           sdr.Close();
           return ls;
       }

        public double TongLuong ()
        {
            string strQuery = "select sum(L.lUONGcb * LO.heso) from NhanVien NV, Luong L, MaLoaiNV LO WHERE NV.maLuong = L.maluong AND NV.LoaiNV = LO.MaLoaiNV";
            SqlConnection con = DataProvider.TaoKetNoi();
            SqlDataReader rdr = DataProvider.TruyVanDuLieu(strQuery,con);
            double luong = 0;
            if(rdr.Read())
            {
                luong = (double)rdr[0];
            }
            rdr.Close();
            con.Close();

            return luong;
        }

       public double TinhLuongTungNV(NhanVienDTO MaNV)
        {
            string strTruyVan = "select L.lUONGcb * LO.heso from NhanVien NV, Luong L, MaLoaiNV LO WHERE NV.maLuong = L.maluong AND NV.LoaiNV = LO.MaLoaiNV";
            SqlConnection con = DataProvider.TaoKetNoi();
            SqlDataReader rdr = DataProvider.TruyVanDuLieu(strTruyVan, con);
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaNV", MaNV);
            double luong = 0;
            if (rdr.Read())
            {
                luong = (double)rdr[0];
            }
            rdr.Close();
            con.Close();

            return luong;
        }

    }
}
