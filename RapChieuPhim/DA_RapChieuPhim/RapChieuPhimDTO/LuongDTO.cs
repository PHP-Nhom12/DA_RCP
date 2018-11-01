using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDTO
{
    public class LuongDTO
    {
       public int MaLuong{get;set;}

      public string MaNV{get;set;}

      public DateTime NgayLam{get;set;}

      public DateTime GioVao{get;set;}

      public DateTime GioRa{get;set;}

      public int LoaiCa{get;set;}

      public int MaLoaiNV{get;set;}

      public float LuongCB { get; set; }

      public float HeSoPhatSinh{get;set;}
    }
}
