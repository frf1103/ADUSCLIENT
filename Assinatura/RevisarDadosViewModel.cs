using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Assinatura
{
    public class RevisarCartoesViewModel
    {
        public string IdParceiro { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public string IdAssinatura { get; set; }

        public decimal valor { get; set; }
        public string logradouro { get; set; }
        public string Email { get; set; }
        public string cpfCnpj { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string? Complemento { get; set; }

        public string? NomeTitular { get; set; }
        public string? NumeroCartao { get; set; }
        public string? Validade { get; set; }
        public string? Cvv { get; set; }

        public List<CartaoAtivoViewModel> CartoesAtivos { get; set; } = new();
        public int idcartaoativo { get; set; }
    }

    public class CartaoAtivoViewModel
    {
        public string Bandeira { get; set; }
        public string UltimosDigitos { get; set; }
        public bool ativo { get; set; }
        public int id { get; set; }
    }

    public class NovoCartaoViewModel
    {
        public string idassinatura { get; set; }
        public string NumeroCartao { get; set; }
        public string NomeTitular { get; set; }
        public string Validade { get; set; } // MM/AAAA
        public string Cvv { get; set; }
    }
}