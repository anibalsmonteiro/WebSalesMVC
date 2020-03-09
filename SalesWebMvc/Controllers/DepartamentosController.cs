using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> departamentos = new List<Departamento>();

            departamentos.Add(new Departamento() { Id = 1, Nome = "Eletrônicos" });
            departamentos.Add(new Departamento() { Id = 2, Nome = "Moda" });

            return View(departamentos);
        }
    }
}