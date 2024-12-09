using Microsoft.AspNetCore.Mvc;
using productWebApplication.Models;
using productWebApplication.Repository;

namespace productWebApplication.Controllers
{
    public class ProductController : Controller
    {

        ProductRepository prepository = new ProductRepository();
        public IActionResult Index()
        {
          

            var products = prepository.GetProduct();
            return View();
        }

        public IActionResult Details(int id) { 
        
           Product product = prepository.GetById(id);

            if(product is null)
            {
                return RedirectToAction("Index", "Home");


            }


        return View(product);

        }
    }
}
