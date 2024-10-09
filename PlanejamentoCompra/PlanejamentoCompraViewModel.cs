using System.ComponentModel;

namespace FarmPlannerClient.PlanejamentoCompra
{
    public class PlanejamentoCompraViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Fazenda")]
        public int idFazenda { get; set; }

        [DisplayName("Safra")]
        public int idSafra { get; set; }

        [DisplayName("Produto")]
        public int idproduto { get; set; }

        [DisplayName("Necessidade")]
        public decimal qtdNecessaria { get; set; }

        [DisplayName("Estoque")]
        public decimal qtdEstoque { get; set; }

        [DisplayName("A Comprar")]
        public decimal qtdComprar { get; set; }

        [DisplayName("Comprado")]
        public decimal qtdComprada { get; set; }

        [DisplayName("Saldo")]
        public decimal saldo { get; set; }

        public string idconta { get; set; }

        public string uid { get; set; }
    }
}