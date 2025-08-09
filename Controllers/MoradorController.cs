using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zelo.Controllers
{
    public class MoradorController : Controller
    {
        public IActionResult Morador()
        {
            return View();
        }

        public IActionResult MoradorCreate()
        {
            return View();
        }

        public IActionResult MoradorEdit()
        {
            return View();
        }

        public IActionResult MoradorList()
        {
            return View();
        }
        public IActionResult MoradorDelete()
        {
            return View();
        }

    }

}