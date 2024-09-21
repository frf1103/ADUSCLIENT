namespace FarmPlannerClient.PlanejamentoCompra
{
    public class ListPlanejamentoCompraViewModel
    {
        public int id { get; set; }
        public int idSafra { get; set; }

        public int idFazenda { get; set; }
        public int idPrincipio { get; set; }

        public decimal qtdNecessaria { get; set; }

        public decimal qtdEstoque { get; set; }
        public decimal qtdComprar { get; set; }
        public decimal qtdComprada { get; set; }
        public decimal saldo { get; set; }
        public string descPrincipio { get; set; }
        public string descSafra { get; set; }
        public string descFazenda { get; set; }
    }
}