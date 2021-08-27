using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTH2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetInfoSV()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetInfoSV( string Ten, string Lop, string Tuoi)
        {
            ViewBag.Ten = Ten;
            ViewBag.Tuoi = Tuoi;
            ViewBag.Lop = Lop;
            return View();
        }
    }
}