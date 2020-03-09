using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public SituacaoVenda Situacao { get; set; }
        public Vendedor Vendedor { get; set; }

        public Venda() { }

        public Venda(int id, DateTime data, double valor, SituacaoVenda situacao, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Situacao = situacao;
            Vendedor = vendedor;
        }
    }
}
