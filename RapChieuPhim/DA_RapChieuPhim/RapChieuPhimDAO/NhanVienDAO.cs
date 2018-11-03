using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class NhanVienDAO
    {
        public NhanVienDTO DangNhap(string strTK, string strMK)
        {
            NhanVienDTO ketqua = null;
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From NhanVien,MaLoaiNV Where LoaiNV=MaLoaiNV AND Email=@Email AND Password = @Password";
            SqlParameter[] dsPars = new SqlParameter[2];
            dsPars[0] = new SqlParameter("@Email", strTK);
            dsPars[1] = new SqlParameter("@Password", strMK);
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, dsPars, conn);
            if (sdr.Read())
            {
                ketqua = new NhanVienDTO();
                ketqua.MaNV = sdr["MaNV"].ToString();
                ketqua.HovaTen = sdr["HovaTen"].ToString();
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ketqua.GioiTinh = int.Parse(sdr["GioiTinh"].ToString());
                ketqua.DiaChi = sdr["DiaChi"].ToString();
                ketqua.Email = sdr["Email"].ToString();
                ketqua.Password = sdr["Password"].ToString();
                ketqua.HinhAnh = sdr["HinhAnh"].ToString();
                ketqua.NgaySinh = DateTime.Parse(sdr["NgayVaoLam"].ToString());
                ketqua.LoaiNV = int.Parse(sdr["LoaiNV"].ToString());
                ketqua.MaLuong = int.Parse(sdr["MaLuong"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                //ketqua.MaLoaiNV = int.Parse(sdr["MaLoaiNV"].ToString());
                ketqua.TenLoai = sdr["TenLoai"].ToString();
                //ketqua.HeSo = float.Parse(sdr["HeSo"].ToString());
                // ketqua.TrangThaiLoai = int.Parse(sdr["TrangThaiLoai"].ToString());
                
            }
            sdr.Close();
            conn.Close();
            return ketqua;
          
        }
        public List<NhanVienDTO> LoadDS()
        {
            NhanVienDTO ketqua = null;
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From NhanVien,MaLoaiNV,Luong Where LoaiNV=MaLoaiNV AND NhanVien.Maluong=Luong.MaLuong";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<NhanVienDTO> ls = new List<NhanVienDTO>();
            while (sdr.Read())
            {
                ketqua = new NhanVienDTO();
                ketqua.MaNV = sdr["MaNV"].ToString();
                ketqua.HovaTen = sdr["HovaTen"].ToString();
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ketqua.GioiTinh = int.Parse(sdr["GioiTinh"].ToString());
                ketqua.DiaChi = sdr["DiaChi"].ToString();
                ketqua.Email = sdr["Email"].ToString();
                ketqua.Password = sdr["Password"].ToString();
                ketqua.HinhAnh = sdr["HinhAnh"].ToString();
                ketqua.NgaySinh = DateTime.Parse(sdr["NgayVaoLam"].ToString());
                ketqua.LoaiNV = int.Parse(sdr["LoaiNV"].ToString());
                ketqua.MaLuong = int.Parse(sdr["MaLuong"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ketqua.MaLoaiNV = int.Parse(sdr["MaLoaiNV"].ToString());
                ketqua.TenLoai = sdr["TenLoai"].ToString();
                ketqua.HeSo = float.Parse(sdr["HeSo"].ToString());
                // ketqua.TrangThaiLoai = int.Parse(sdr["TrangThaiLoai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;

        }
        public bool doiMatkhau( string matkhaumoi,string matkhaucu, string email)
        {
                    SqlConnection conn = DataProvider.TaoKetNoi();
                    string sql = "Update nhanvien Set Password = @Password where Email = @Email";
                    SqlParameter[] par2 = new SqlParameter[2];
                    par2[0] = new SqlParameter("@Password", matkhaumoi);
                    par2[1] = new SqlParameter("@Email", email);
                    int kq = DataProvider.CapNhatDuLieu(sql, par2, conn);
                    if (kq > 0)
                    {
                        return true;
                    }

                    conn.Close();
                    return false;
            
        }
        public List<NhanVienDTO> LoadDSNV()
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From NhanVien";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<NhanVienDTO> ls = new List<NhanVienDTO>();
            while (sdr.Read())
            {
                NhanVienDTO ketqua = new NhanVienDTO();
                ketqua.MaNV = sdr["MaNV"].ToString();
                ketqua.HovaTen = sdr["HovaTen"].ToString();
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ketqua.GioiTinh = int.Parse(sdr["GioiTinh"].ToString());
                ketqua.DiaChi = sdr["DiaChi"].ToString();
                ketqua.Email = sdr["Email"].ToString();
                
                //ketqua.Password = sdr["Password"].ToString();
                //ketqua.HinhAnh = sdr["HinhAnh"].ToString();
                //ketqua.NgaySinh = DateTime.Parse(sdr["NgayVaoLam"].ToString());
                ketqua.LoaiNV = int.Parse(sdr["LoaiNV"].ToString());
                ketqua.MaLuong = int.Parse(sdr["MaLuong"].ToString());
                //ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                //ketqua.MaLoaiNV = int.Parse(sdr["MaLoaiNV"].ToString());
                //ketqua.TenLoai = sdr["TenLoai"].ToString();
                //ketqua.HeSo = float.Parse(sdr["HeSo"].ToString());
               // ketqua.TrangThaiLoai = int.Parse(sdr["TrangThaiLoai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }

        public List<LoaiNV_DTO> loadLoaiNV()
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From NhanVien ,MaLoaiNV where LoaiNV=MaLoaiNV ";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<LoaiNV_DTO> ls = new List<LoaiNV_DTO>();
            while(sdr.Read())
            {
                LoaiNV_DTO loai = new LoaiNV_DTO();
                loai.MaLoaiNV = int.Parse(sdr["MaLoaiNV"].ToString());
                loai.TenLoai = sdr["TenLoai"].ToString();
                ls.Add(loai);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }

        public List<LuongDTO> loadLuong()
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From NhanVien,Luong where NhanVien.MaLuong = Luong.MaLuong";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            List<LuongDTO> ls = new List<LuongDTO>();
            while (sdr.Read())
            {
                LuongDTO luong = new LuongDTO();
                luong.MaLuong= int.Parse(sdr["MaLuong"].ToString());
                luong.LuongCB = float.Parse(sdr["LuongCB"].ToString());
                ls.Add(luong);
            }
            sdr.Close();
            conn.Close();
            return ls;
        }
        public List<NhanVienDTO> ThemNhanVien(string TenNV, DateTime NS,int GT, string DC,string Email,string Pass, string Ha,DateTime NVL,int LoaiNV,int Maluong,int TrangThai)
        {
            string strTruyVan = "INSERT INTO NhanVien(HovaTen,NgaySinh,GioiTinh,DiaChi,Email,Password,HinhAnh,NgayVaoLam,LoaiNV,MaLuong,TrangThai)" + " VALUES(@HovaTen,@NgaySinh,@GioiTinh,@DiaChi,@Email,@Password,@HinhAnh,@NgayVaoLam,@LoaiNV,@MaLuong,@TrangThai)";
            SqlParameter[] par = new SqlParameter[11];
            par[0] = new SqlParameter("@HovaTen",TenNV);
            par[1] = new SqlParameter("@NgaySinh",NS);
            par[2] = new SqlParameter("@GioiTinh",GT );
            par[3] = new SqlParameter("@DiaChi", DC);
            par[4] = new SqlParameter("@Email", Email);
            par[5] = new SqlParameter("@Password",Pass);
            par[6] = new SqlParameter("@HinhAnh",Ha);
            par[7] = new SqlParameter("@NgayVaoLam",NVL);
            par[8] = new SqlParameter("@LoaiNV", LoaiNV);
            par[9] = new SqlParameter("@MaLuong",Maluong);
            par[10] = new SqlParameter("@TrangThai",TrangThai);
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr= DataProvider.TruyVanDuLieu(strTruyVan, par, conn);
            List<NhanVienDTO> ls = new List<NhanVienDTO>();
            while (sdr.Read())
            {
                NhanVienDTO ketqua = new NhanVienDTO();
                ketqua.HovaTen = sdr["HovaTen"].ToString();
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ketqua.GioiTinh =int.Parse( sdr["GioiTinh"].ToString());
                ketqua.DiaChi =sdr["DiaChi"].ToString();
                ketqua.Email = sdr["Email"].ToString();
                ketqua.Password = sdr["Password"].ToString();
                ketqua.HinhAnh = sdr["HinhAnh"].ToString();
                ketqua.NgayVaoLam = DateTime.Parse(sdr["NgayVaoLam"].ToString());
                ketqua.LoaiNV = int.Parse(sdr["LoaiNV"].ToString());
                ketqua.MaLuong = int.Parse(sdr["MaLuong"].ToString());
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                ls.Add(ketqua);
            }
            sdr.Close();
            return ls;
        }
    }
}
