using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeepValidationRepro.Models;

namespace DeepValidationRepro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var foo = new Foo
            {
                Bar = new Bar(),
                Bars =
                {
                    new Bar()
                }
            };

            TryValidateModel(foo);

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
