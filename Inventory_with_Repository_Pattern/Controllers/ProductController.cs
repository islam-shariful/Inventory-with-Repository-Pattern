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
    }
}