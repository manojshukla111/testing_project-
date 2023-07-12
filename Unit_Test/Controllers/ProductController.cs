using Microsoft.AspNetCore.Mvc;
using Unit_Test.Controller;
using Unit_Test.models; 

namespace Unit_Test.Controller
{
    public class ProductController : Controller
    {
        public IList<Products> prod = new List<Products>();

        //prod = 
        Products products = new Products(1, "VCR");

        public IActionResult Index()
        {
            CreateProducts();
            return View(prod);
        }

        private void CreateProducts()
        {
            prod.Add(products);
            products = new Products(2, "Television");
            prod.Add(products);
            products = new Products(3, "Gaming");
            prod.Add(products);
        }

        public ActionResult Details(int id)
        {
            if (id < 1)
            {
                return RedirectToAction("Index");
            }
            CreateProducts();
            var product = prod.Where(x => x.Id == id);
            var name = product.FirstOrDefault()?.Name;
            return View("Details", name);
        }

    }
}