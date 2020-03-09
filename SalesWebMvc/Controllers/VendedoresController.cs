using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {

        private readonly VendedorService _vendedorService;

        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }
        
        public IActionResult Index()
        {
            var list = _vendedorService.BuscarTodos();
            return View(list);
        }

        public IActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Incluir(Vendedor vendedor)
        {
            _vendedorService.Incluir(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}