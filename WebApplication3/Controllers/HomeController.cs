using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        int i = 0;
        public IActionResult Index()
        {

            i = Convert.ToInt32(Convert.ToInt32(HttpContext.Session.GetInt32("MySession")));
            i++;
            HttpContext.Session.SetInt32("MySession", i);
            ViewData["MyData"] = "Test Data";
            TempData["TempData"] = "Temp Data";

            //if (HttpContext.Session.GetInt32("MySession") != null)
            //    i = (int)HttpContext.Session.GetInt32("MySession");
            //else
            //    i = 0;


            //return RedirectToAction("Index", "Customer");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
