﻿using Microsoft.AspNetCore.Mvc;
using portfolio_project.Models;
using System.Diagnostics;

namespace portfolio_project.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده، صحیح نمیباشد، لطفا دوباره تلاش کنید.";
                return View(model);
            }
            ViewBag.success = "اطلاعات با موفقیت ارسال شد.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
