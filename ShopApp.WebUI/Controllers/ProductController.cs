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
            return View();
        }

        //localhost:5000/product/list
        public IActionResult List() //action methodu
        {
            return View();
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
