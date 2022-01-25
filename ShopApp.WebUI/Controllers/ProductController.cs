using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController:Controller
    {
        public string Index() //action methodu
        {
            return "product/index";
        }

        //localhost:5000/product/list
        public string List() //action methodu
        {
            return "product/list";
        }

        //localhost:5000/product/details
        public string Details(int id) //action methodu
        {
            return "product/details/"+id;
        }
    }
}
