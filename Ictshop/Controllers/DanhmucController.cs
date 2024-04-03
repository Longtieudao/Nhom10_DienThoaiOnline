using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Ictshop.Models;
using PagedList;
using PagedList.Mvc;
namespace Ictshop.Controllers
{
    public class DanhmucController : Controller
    {
        Qlbanhang db = new Qlbanhang();
        // GET: Danhmuc
        public ActionResult DanhmucPartial()
        {
            var danhmuc = db.Hangsanxuats.ToList();
            return PartialView(danhmuc);
        }
        public ActionResult Menu()
        {
            
            return PartialView();
        }

        public ActionResult dttheodanhmuc(int iMahang, int? page)
        {
            ViewBag.Mahang = iMahang;
            int pageSize = 4; 
            int pageNumber = (page ?? 1); 

            var sach = db.Sanphams.Where(s => s.Mahang == iMahang).OrderBy(s => s.Mahang); // Sắp xếp theo Id hoặc bất kỳ trường nào bạn muốn

            return View(sach.ToPagedList(pageNumber, pageSize)); 
        }


    }
}