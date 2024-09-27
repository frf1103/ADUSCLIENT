using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.PedidoCompra
{
    public class ProdutoCompraViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        public int idpedido { get; set; }
        public string idconta { get; set; }

        [DisplayName("Produto")]
        public int idproduto { get; set; }

        [DisplayName("Qtd Comprada")]
        public decimal qtdcompra { get; set; }

        [DisplayName("Preço")]
        public decimal preco { get; set; }

        [DisplayName("Total")]
        public decimal total { get; set; }

        [DisplayName("Recebido")]
        public decimal recebido { get; set; }

        public string? descproduto { get; set; }

        public string uid { get; set; }
        public DateTime datains { get; set; }
        public DateTime? dataup { get; set; }
    }
}