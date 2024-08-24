using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Conta
{
    public class PagamentoViewModel
    {
        public string Id { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}