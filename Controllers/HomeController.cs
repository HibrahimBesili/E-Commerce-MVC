using E_Commerce_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace E_Commerce_MVC.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext(); 
        // GET: Home

        public PartialViewResult _FeaturedPartialProductList()
        {

            return PartialView(db.Products.Where(i=>i.IsApproaved&&i.IsFeatured).Take(5).ToList());
        }
        public PartialViewResult _SliderProductList()
        {

            return PartialView(db.Products.Where(i => i.Slider&&i.IsApproaved).Take(5).ToList());
        }
        public ActionResult Index()
        {
            return View(db.Products.Where(i=>i.IsHome&&i.IsApproaved).ToList());
        }
        public ActionResult ProductDetails(int id)
        {
            return View(db.Products.Where(i=>i.Id==id).FirstOrDefault());
        }
        public ActionResult Product()
        {
            return View(db.Products.ToList());
        }
        public ActionResult ProductList(int id)
        {
            return View(db.Products.Where(i=>i.CaTegoryId==id).ToList());
        }

        public ActionResult Search(string q)
        {
            var p = db.Products.Where(i => i.IsApproaved ==true);
            if (!string.IsNullOrEmpty(q))
            {
                p = p.Where(i => i.Pname.Contains(q) || i.Description.Contains(q));
            }


            return View(p.ToList());
        }
    }
}