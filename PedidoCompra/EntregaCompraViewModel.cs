using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.PedidoCompra
{
    public class EntregaCompraViewModel
    {
        public int id { get; set; }

        public int idprodutopedido { get; set; }

        public int idpedido { get; set; }
        public int idproduto { get; set; }

        public int idunidentrega { get; set; }

        public decimal conversor { get; set; }

        public DateTime dataentrega { get; set; }

        public string documento { get; set; }

        public decimal qtd { get; set; }

        public string idconta { get; set; }
        public string uid { get; set; }
        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }
    }
}