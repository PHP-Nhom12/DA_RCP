using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDTO
{
    public class VoucherDTO
    {
      public int MaVoucher{ get; set; }
      public string TenVoucher{ get; set; }
      public float TiLe{ get; set; }
      public string NgayDung{ get; set; }
      public DateTime HanSuDung{ get; set; }
      public int TrangThai { get; set; }
      public int MaTV { get; set; }
    }
}
