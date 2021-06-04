using ShopOnConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOn.Models.BUS
{
    public class LoaiSanPhamBUS 
    {
        public static IEnumerable<LoaiSanPham> DanhSach()
        {
            var db = new ShopOnConnectionDB();
            return db.Query<LoaiSanPham>("select * from LoaiSanPham where TinhTrang = 0");
        }
        public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new ShopOnConnectionDB();
            return db.Query<SanPham>("select * from SanPham where MaLoaiSanPham = '"+id+"' ");
        }
    }
}