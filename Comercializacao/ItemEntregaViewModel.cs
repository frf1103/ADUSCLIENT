using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Comercializacao
{
    public class ItemEntregaContratoViewModel
    {
        public int id { get; set; }
        public int idcomercializacao { get; set; }
        public decimal qtd { get; set; }
        public string nf { get; set; }

        public DateTime datanf { get; set; }
        public decimal qtdcompra { get; set; }
        public decimal saldo { get; set; }
        public decimal preco { get; set; }
        public decimal total { get; set; }
        public decimal recebido { get; set; }
    }
}