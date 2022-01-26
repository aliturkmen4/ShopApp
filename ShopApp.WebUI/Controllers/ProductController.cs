using Microsoft.AspNetCore.Mvc;
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
        public string Details(int id) //action methodu
        {
            return "product/details/"+id;
        }
    }
}
