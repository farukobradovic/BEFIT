using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.ProductOrder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Controllers
{
    public class ProductOrderController:Controller
    {
        private readonly BEFITContext ct;

        public ProductOrderController(BEFITContext ct)
        {
            this.ct = ct;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = ct.Product.ToList();



            return View(products);
        }

        public IActionResult DeleteProductOrder(int id)
        {

            Product p = ct.Product.FirstOrDefault(x => x.ProductID == id);

            if (p == null)
                return StatusCode(418);

            ct.Product.Remove(p);
            ct.SaveChanges();
            return RedirectToAction("Index","ProductOrder");
        }
    }
}
