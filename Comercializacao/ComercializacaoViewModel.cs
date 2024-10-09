using System.ComponentModel;

namespace FarmPlannerClient.Comercializacao
{
    public class ComercializacaoViewModel
    {
        public int id { get; set; }

        [DisplayName("Safra")]
        public int idSafra { get; set; }

        [DisplayName("Parceiro")]
        public int idParceiro { get; set; }

        [DisplayName("Fazenda")]
        public int idFazenda { get; set; }

        [DisplayName("Quantidade")]
        public decimal quantidade { get; set; }

        [DisplayName("Moeda")]
        public int idMoeda { get; set; }

        [DisplayName("Trava")]
        public bool trava { get; set; }

        [DisplayName("CBOT")]
        public decimal cbot { get; set; }

        [DisplayName("Câmbio")]
        public decimal cambio { get; set; }

        [DisplayName("Prêmio")]
        public decimal premio { get; set; }

        public decimal valorUnitario { get; set; }

        [DisplayName("Valor Unitário")]
        public decimal valorTotal { get; set; }

        [DisplayName("Data Entrega")]
        public DateTime dataEntrega { get; set; }

        [DisplayName("Data Pagamento")]
        public DateTime dataPagamento { get; set; }

        [DisplayName("Descontos")]
        public decimal descontos { get; set; }

        [DisplayName("Vl Líquido")]
        public decimal valorLiquido { get; set; }

        [DisplayName("Contrato")]
        public string? numeroContrato { get; set; }

        [DisplayName("Data do Pedido")]
        public DateTime? dataPedido { get; set; }

        [DisplayName("Frete")]
        public decimal? frete { get; set; }

        public string idconta { get; set; }
        public string? uid { get; set; }
        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }
    }
}