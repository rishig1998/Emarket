using EMarket.Entitie;
using EMarket.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emarket.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductService serviceproduct = new ProductService();
        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ProductList(String search)
        {
            var show = serviceproduct.Showproduct();
            if (string.IsNullOrEmpty(search)==false)
            { 
                show = show.Where(x=> x.Name!=null && x.Name.ToLower().Contains(search.ToLower())).ToList(); 
            }
         
           
             

                return PartialView(show);
         
            
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            serviceproduct.Createproduct(product);
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var Editshow=serviceproduct.Editproduct(ID);
            return PartialView(Editshow);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            serviceproduct.Updatproduct(product);
            return RedirectToAction("ProductList");
        }
        [HttpPost]
        public ActionResult Delete(int ID)
        {
            serviceproduct.Deleteproduct(ID);
            return RedirectToAction("ProductList");
        }

    }
}