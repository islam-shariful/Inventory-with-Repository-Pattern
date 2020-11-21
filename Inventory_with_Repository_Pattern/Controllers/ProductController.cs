using Inventory_with_Repository_Pattern.Models;
using Inventory_with_Repository_Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_with_Repository_Pattern.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository proRepo = new ProductRepository();
        // GET: Product
        public ActionResult Index()
        {
            return View(proRepo.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            CategoryRepository catRepo = new CategoryRepository();
            ViewData["categories"] = catRepo.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product pro)
        {
            proRepo.Insert(pro);
            return Redirect("index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            CategoryRepository catRepo = new CategoryRepository();
            ViewData["categories"] = catRepo.GetAll();
            return View(proRepo.Get(id));
        }
        [HttpPost]
        public ActionResult Edit(Product pro)
        {
            proRepo.Update(pro);
            return RedirectToAction("index");
        }
    }
}