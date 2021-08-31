using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTH2.Models;

namespace BaiTH2.Controllers
{
    public class GiaiPhuongTrinhController : Controller
    {
        GPTB1 giaiphuowngtrinh = new GPTB1();
        // GET: GiaiPhuongTrinh
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPhuongTrinhBac1(double Sothunhat, double Sothuhai)
        {
            double NghiemPT = giaiphuowngtrinh.GPT(Sothunhat, Sothuhai);
            ViewBag.Res = NghiemPT;
            return View();
        }
    }
}