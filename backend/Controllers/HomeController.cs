using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using site.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Destinos()
        {
            return View();
        }
        public IActionResult Promocoes()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
    }
}
