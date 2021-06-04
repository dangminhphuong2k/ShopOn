﻿using ShopOn.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace ShopOn.Controllers
{
    public class LoaiSanPhamController : Controller
    {
        // GET: LoaiSanPham
        public ActionResult Index(String id, int page = 1, int pagesize = 7)
        {
            var ds = LoaiSanPhamBUS.ChiTiet(id).ToPagedList(page, pagesize);
            return View(ds);
        }
    }
}