using Ictshop.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Controllers
{
    public class HomeController : Controller
    {
        Qlbanhang db = new Qlbanhang();
        public ActionResult Index(int? page)
        {

            int pageSize = 8;
            int pageNumber = (page ?? 1);

            var ip = db.Sanphams.OrderBy(s => s.Masp).ToPagedList(pageNumber, pageSize);
            return PartialView(ip);

        }

        public ActionResult About()
        {         

            return View();
        }
        [HttpPost]









        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult SlidePartial()
        {
            return PartialView();

        }
    }
}