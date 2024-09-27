using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.PedidoCompra
{
    public class PedidoCompraViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Safra")]
        public int idsafra { get; set; }

        [DisplayName("Fazenda")]
        public int idfazenda { get; set; }

        [DisplayName("Fornecedor")]
        public int idfornecedor { get; set; }

        [DisplayName("Moeda")]
        public int idmoeda { get; set; }

        [DisplayName("Vencimento")]
        public DateTime vencimento { get; set; }

        [DisplayName("Pedido Fornec")]
        public string? pedidofonecedor { get; set; }

        [DisplayName("Total")]
        public decimal total { get; set; }

        [DisplayName("Data")]
        public DateTime datapedido { get; set; }

        [DisplayName("Observação")]
        public string? observacao { get; set; }

        public string idconta { get; set; }
        public string uid { get; set; }
        public DateTime datains { get; set; }
        public DateTime? dataup { get; set; }

        public string? descfazenda { get; set; }
        public string? descmoeda { get; set; }
        public string? descsafra { get; set; }
        public string? descfornec { get; set; }
    }
}