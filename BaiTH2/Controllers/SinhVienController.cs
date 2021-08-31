using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTH2.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string HoTen, string Lop)
        {
            ViewBag.hoten = HoTen;
            ViewBag.lop = Lop;
            return View();
        }
        public ActionResult LayThongTin(string HoTen, string Lop)
        {
            ViewBag.hoten = HoTen;
            ViewBag.lop = Lop;
            return View();
        }
    }
}