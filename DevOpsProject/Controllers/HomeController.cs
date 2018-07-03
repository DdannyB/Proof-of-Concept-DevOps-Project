using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aanleiding()
        {
            return View();
        }

        public IActionResult Aanpak()
        {
            return View();
        }

        public IActionResult Resultaten()
        {
            return View();
        }

        public IActionResult Proces()
        {
            return View();
        }

        public IActionResult Composefile()
        {
            return View();
        }
    }
}