﻿using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class LuongBUS
    {
       
        public List<LuongDTO> LuongNV()
        {
            LuongDAO nvBUS = new LuongDAO();
            return nvBUS.Luong();
        }
        public List<LuongDTO> LuongOfNVien()
        {
            LuongDAO nvBUS = new LuongDAO();
            return nvBUS.LuongOfNVien();
        }
        public double TongLuong()
        {
            LuongDAO luong = new LuongDAO();
            return luong.TongLuong();
        } 
        public double TinhLuongTungNV(NhanVienDTO MaNV )
        {
            LuongDAO luongnv = new LuongDAO();
            return luongnv.TinhLuongTungNV(MaNV);
        }
    }
}
