using ShopOnConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOn.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopOnConnectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");
        }
        public static SanPham ChiTiet(String a)
        {
            var db = new ShopOnConnectionDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0", a);
        }
    }
}