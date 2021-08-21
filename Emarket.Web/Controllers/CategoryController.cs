using EMarket.Entitie;
using EMarket.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emarket.Web.Controllers
{
    public class CategoryController : Controller
    {
        EMarketService serviceemarket = new EMarketService();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public  ActionResult CategoryList()
        {
            var show=serviceemarket.Showemarket();
            return PartialView(show);
        }
      
        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            serviceemarket.Createemarket(category);
            return RedirectToAction("CategoryList");
            
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var value = serviceemarket.Editemarket(ID);
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            serviceemarket.Updatemarket(category);
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var value = serviceemarket.Editemarket(ID);
            return View(value);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            serviceemarket.Deleteemarket(category.ID);
            return RedirectToAction("CategoryList");
        }
    }
}