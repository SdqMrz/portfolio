using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using portfolio_project.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace portfolio_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
            {
             new Service{Id=1,Name="طلایی"},
             new Service{Id=1,Name="نقره ای"},
             new Service{Id=1,Name="پلاتین"},
             new Service{Id=1,Name="الماس"}
             };


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
            var model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده، صحیح نمیباشد، لطفا دوباره تلاش کنید.";
                return View(model);
            }
            ViewBag.success = "اطلاعات با موفقیت ارسال شد.";

            ModelState.Clear();

            model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            return View(model);
        }

        public IActionResult ProjectDetails(long id)
        {
            var project = Data.ProjectStore.GetProjectBy(id);

            return View(project);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
