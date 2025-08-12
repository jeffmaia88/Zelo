using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zelo.Services;
using Zelo.Models;
using Zelo.Entities;
using Zelo.Repositories;

namespace Zelo.Controllers
{
    public class ApartamentoController : Controller
    {
        private readonly ApartamentoServices _services;

        public ApartamentoController(ApartamentoServices services)
        {
            _services = services;
        }

        public IActionResult Apartamento()
        {
            return View();
        }

        public IActionResult ApartamentoCreate()
        {
            var model = new ApartamentoRequest();
            return View(model);
        }

        [HttpPost]
        public IActionResult ApartamentoCreate(ApartamentoRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }


            var Apartamento = _services.Create(request);
            ViewBag.Sucesso = "Apartamento salvo com sucesso!";
            return View(new ApartamentoRequest());
        }
    }
}