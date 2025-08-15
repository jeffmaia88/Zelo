using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zelo.Models;
using Zelo.Entities;
using Zelo.Repositories;
using Zelo.Services;

namespace Zelo.Controllers
{
    public class MoradorController : Controller
    {
        private readonly MoradorServices _services;
        private readonly ApartamentoServices _apServices;

        public MoradorController(MoradorServices services, ApartamentoServices apServices)
        {
            _services = services;
            _apServices = apServices;
        }


        public IActionResult Morador()
        {
            return View();
        }

        public IActionResult MoradorCreate()
        {
            var apartamentos = _apServices.GetAll(); // ou GetAll(), dependendo da lógica
            ViewBag.Apartamentos = apartamentos.Select(a => new
            {
                a.Id,
                Bloco = a.Bloco,
                Numero = a.Numero,
                Descricao = $"{a.Bloco} - {a.Numero}"
            }).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult MoradorCreate(MoradorRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var Morador = _services.Create(request);
            ViewBag.Sucesso = "Morador Salvo com Sucesso";
            return View(new MoradorRequest());
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