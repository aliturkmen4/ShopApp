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
        public IActionResult Index() //action methodu
        {
            int saat=DateTime.Now.Hour; //serverın saat bilgisini aldım!

            ViewBag.Greeting= saat > 12 ? "İyi Günler" : "Günaydın"; //saat 12 den büyükse iyi günler, küçükse günaydın demesini sağladım! ViewBag bilgi taşımak için kullanılabilir!

            ViewBag.UserName = "Ali";
             
            return View();
        }

        //localhost:5000/home/about
        public IActionResult About() //action methodu
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("myView"); //cshtml dosyasının adının myview olacağını söyledim!
        }
    }
}
