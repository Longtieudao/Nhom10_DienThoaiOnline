using Ictshop.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PagedList.Mvc;
namespace Ictshop.Controllers
{
    public class TimKiemController : Controller
    {
        Qlbanhang db = new Qlbanhang();
        // GET: TimKiem
        public ActionResult Search(string searchString, int? page)
        {
            var list = db.Sanphams.Where(n => n.Tensp.Contains(searchString)).ToList();
            int pageSize = 3; 
            int pageNumber = (page ?? 1); 

            return View(list.ToPagedList(pageNumber, pageSize)); 
        }

    }
}