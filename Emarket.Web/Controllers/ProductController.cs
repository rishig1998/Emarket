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
        [HttpGet]
        public ActionResult ProductList()
        {
            var show=serviceproduct.Showproduct();
            return View(show);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            serviceproduct.Createproduct(product);
            return View();
        }

    }
}