using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGiaoHang
{
    class Test
    {
        void main(String []agrs)
        {
            QLDonHang test = new QLDonHang();
            DonHang donHang = new DonHang();
            donHang.TienUng = 1000000;
            donHang.GhiChu = "Không có";
            test.khoiTaoDonHang(donHang);
        }
    }
}
