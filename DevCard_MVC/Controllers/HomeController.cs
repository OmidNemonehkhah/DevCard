using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> _services = new List<Service>
        {
            new Service( 1 , "نقره ای"),
            new Service( 2 , "طلایی"),
            new Service( 3 , "پلاتین"),
            new Service( 4 , "الماس"),
        };

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
            if(!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید.";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "پیغام شما با موفقیت ارسال شد. با تشکر.";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
