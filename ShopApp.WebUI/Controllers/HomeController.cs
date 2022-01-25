using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController:Controller //aspnetcore.mvc adresinden aldım controllerı
    {
        //localhost:5000/home/index
        public string Index() //action methodu
        {
            return "home/index";
        }

        //localhost:5000/home/about
        public string About() //action methodu
        {
            return "home/about";
        }
    }
}
