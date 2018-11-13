using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDTO
{
   public class ThanhVienDTO
    {
       public int MaTV{get;set;}

      public string TenTV{get;set;}

      public int LoaiTV{get;set;}

      public int CMND{get;set;}

      public DateTime NgaySinh{get;set;}

      public int MaVoucher { get; set; }

      public int TrangThai { get; set;  }
    }
}
