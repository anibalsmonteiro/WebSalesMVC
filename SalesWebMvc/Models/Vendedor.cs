using System;
using System.Collections.Generic;
using SalesWebMvc.Data;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        ICollection<Venda> Vendas { get; set; } = new List<Venda>();

        public Vendedor() { }

        public Vendedor(int id, string nome, string email, DateTime dataAniversario, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void IncluirVendas(Venda venda)
        {
            Vendas.Add(venda);
        }
        public void RemoverVendas(Venda venda)
        {
            Vendas.Remove(venda);
        }

        public double PegaValorTotalDasVendas(DateTime inicial, DateTime final)
        {
            return (from v in Vendas where v.Data >= inicial && v.Data <= final select v.Valor).Sum();
        }
    }
}

