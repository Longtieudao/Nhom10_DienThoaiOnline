using Ictshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Areas.Admin.Controllers
{
    public class SearchController : Controller
    {
        Qlbanhang db = new Qlbanhang();
        // GET: Admin/Search
        public ActionResult Index(String SearchString)
        {
            var list = db.Sanphams.Where(n => n.Tensp.Contains(SearchString)).ToList();
            return View(list);
        }
    }
}