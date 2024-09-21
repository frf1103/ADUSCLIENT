using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.PlanejamentoCompra
{
    public class LinhaPlanejCompraVideModel
    {
        public int id { get; set; }

        public decimal qtdNecessaria { get; set; }

        public decimal qtdEstoque { get; set; }

        public decimal qtdComprar { get; set; }

        public decimal qtdComprada { get; set; }

        public decimal saldo { get; set; }

        public string idconta { get; set; }

        public string uid { get; set; }
    }
}