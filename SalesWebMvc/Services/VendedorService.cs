using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class VendedorService
    {
        private readonly SalesWebMvcContext _context;

        public VendedorService (SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> BuscarTodos()
        {
            return _context.Vendedor.ToList();
        }

    }
}
