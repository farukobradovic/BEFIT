using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.Product;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Controllers
{
    public class ProductController:Controller
    {
        private readonly BEFITContext ct;
        private readonly UserManager<User> userManager;

        public ProductController(BEFITContext ct, UserManager<User> userManager)
        {
            this.ct = ct;
            this.userManager = userManager;
        }


        public IActionResult ListProducts()
        {
            List<Product> proizvodi = ct.Product.ToList();
            return View(proizvodi);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {

            return View("AddProduct",new Product());

        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (!ModelState.IsValid)
                return View("AddProduct", "Product");

            ct.Product.Add(product);
            ct.SaveChanges();


            return RedirectToAction("ListProducts","Product");
        }

        public IActionResult EditProduct(int id)
        {
            Product product = ct.Product.Where(x => x.ProductID == id).FirstOrDefault();

            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product, int id)
        {
            var p = ct.Product.Where(x => x.ProductID == id).FirstOrDefault();

            if (p == null)
                return StatusCode(418);

            p.Naziv = product.Naziv;
            p.ExpirationDate = product.ExpirationDate;
            p.Price = product.Price;


            ct.SaveChanges();
            return RedirectToAction("ListProducts");
        }
        
        [HttpPost]
        public async Task<IActionResult> ListProducts(int id)
        {

            var user = await userManager.GetUserAsync(HttpContext.User);

            var productOrder = new ProductOrder
            {
                ProductID = id,
                OrderDate = DateTime.Now,
                OrderCancellation = DateTime.Now.AddMinutes(10),
                UserID = user.Id
                
            };

            ct.ProductOrder.Add(productOrder);
            ct.SaveChanges();

            return RedirectToAction("Index", "ProductOrder");


        }

    }
}
