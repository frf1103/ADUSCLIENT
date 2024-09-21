namespace FarmPlannerClient.OrcamentoProduto
{
    public class ProdutoOrcamentoViewModel
    {
        public int id { get; set; }
        public int idOrcamento { get; set; }
        public int tipoProdutoOrc { get; set; }
        public int? idPrincipioAtivo { get; set; }
        public int? idProduto { get; set; }

        public int idMoeda { get; set; }

        public decimal precoUnitario { get; set; }

        public DateTime? dataPreco { get; set; }
        public string idconta { get; set; }
        public string uid { get; set; }
    }
}