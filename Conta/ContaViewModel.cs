using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Conta
{
    public class ContaViewModel
    {
        [DisplayName("ID")]
        public string? id { get; set; }

        [DisplayName("Nome")]
        public string nome { get; set; }

        [DisplayName("Email")]
        public string email { get; set; }

        [DisplayName("CPF")]
        public string cpf { get; set; }

        public string? uid { get; set; } = null;

        [DisplayName("Fone")]
        public string telefone { get; set; }

        public string contaguid { get; set; }

        public string? representanteid { get; set; }

        [DisplayName("Ativa")]
        public bool ativa { get; set; } = true;

        public AssinaturaContaViewModel assinatura { get; set; }
    }
}