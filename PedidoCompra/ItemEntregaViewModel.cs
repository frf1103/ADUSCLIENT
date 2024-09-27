using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.PedidoCompra
{
    public class ItemEntregaViewModel
    {
        public int id { get; set; }
        public int idpedido { get; set; }
        public int idproduto { get; set; }
        public int idpedidoproduto { get; set; }
        public decimal qtd { get; set; }
        public decimal conversor { get; set; }
        public int idunidade { get; set; }
        public decimal qtdconv { get; set; }
        public string nf { get; set; }

        public DateTime datanf { get; set; }

        public decimal qtdcompra { get; set; }
        public string descproduto { get; set; }
        public decimal saldo { get; set; }

        public decimal preco { get; set; }
        public decimal total { get; set; }
        public decimal recebido { get; set; }
    }
}