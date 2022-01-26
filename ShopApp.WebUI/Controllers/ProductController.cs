using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index() //action methodu
        {
            //ViewBag(1.yöntem)
            //Model(2.yöntem)
            //ViewData(3.yöntem)
            var product = new Product { Name = "Iphone X", Price = 8000, Description = "Güzel Telefon" };

            //ViewData["Category"] = "Telefonlar";
            //ViewData["Product"] = product; //viewdata da atama bu şekilde yapılır!

            ViewBag.Category = "Telefonlar";
            //ViewBag.Product = product;

            //hem model hem viewdata beraber kullanabilirsin!
            
            return View(product);
        }

        //localhost:5000/product/list
        public IActionResult List() //action methodu
        {

            var products = new List<Product>()
            {
                new Product {Name="Iphone 8",Price=8000,Description="Eski Telefon"},
                new Product{Name="Iphone 12",Price=14000,Description="Çok iyi Telefon" }
            };

            var category = new Category {Name="Telefonlar",Description="Telefon Kategorisi" };

            var productViewModel = new ViewModels.ProductViewModel()
            {
                Category=category,
                Products=products
            };


            return View(productViewModel);
        }

        //localhost:5000/product/details
        public IActionResult Details(int id) //action methodu
        {
            //name:"samsung s6"
            //prive: 3000
            //description: "iyi telefon"

            //ViewBag.Name = "samsung s6";
            //ViewBag.Price = 3000;
            //ViewBag.Description = "İyi telefon";

            var p = new Product();

            p.Name="Samsung s6";
            p.Price = 3000;
            p.Description = "İyi telefon";

            return View(p); //p nesnesini view e gönderdim!
        }
    }
}
