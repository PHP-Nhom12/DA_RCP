using RapChieuPhimDAO;
using RapChieuPhimDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimBUS
{
    public class VoucherBUS
    {
        public List<VoucherDTO> LoadVoucher()
        {
            VoucherDAO voucher = new VoucherDAO();
            return voucher.LoadVoucher();
        }

        public List<VoucherDTO> LoadVoucher(int MaTV)
        {
            VoucherDAO voucher = new VoucherDAO();
            return voucher.LoadVoucher(MaTV);
        }
    }
}
