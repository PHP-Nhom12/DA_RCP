using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class VoucherDAO
    {
        public List<VoucherDTO> LoadVoucher()
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Voucher where TrangThai=1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<VoucherDTO> ls = new List<VoucherDTO>();
            while (sdr.Read())
            {
                VoucherDTO ketqua = new VoucherDTO();
                ketqua.MaVoucher = int.Parse(sdr["MaVoucher"].ToString());
                ketqua.TenVoucher = sdr["TenVoucher"].ToString();
                ketqua.TiLe = float.Parse(sdr["TiLe"].ToString());
                ketqua.NgayDung = sdr["NgayDung"].ToString();
                ketqua.HanSuDung = DateTime.Parse(sdr["HanSuDung"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;

        }

        public List<VoucherDTO> LoadVoucher(int MaTV)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From Voucher_ThanhVien, Voucher where Voucher_ThanhVien.MaVoucher = Voucher.MaVoucher AND Voucher_ThanhVien.MaTV = @MaTV AND Voucher.TrangThai = 1";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaTV", MaTV);
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            List<VoucherDTO> ls = new List<VoucherDTO>();
            while (sdr.Read())
            {
                VoucherDTO ketqua = new VoucherDTO();
                ketqua.MaVoucher = int.Parse(sdr["MaVoucher"].ToString());
                ketqua.MaTV = int.Parse(sdr["MaTV"].ToString());
                ketqua.TenVoucher = sdr["TenVoucher"].ToString();
                ketqua.TiLe = float.Parse(sdr["TiLe"].ToString());
                ketqua.NgayDung = sdr["NgayDung"].ToString();
                ketqua.HanSuDung = DateTime.Parse(sdr["HanSuDung"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;

        }
    }
}
