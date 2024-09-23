namespace FarmPlannerClient.OrcamentoProduto
{
    public class ListProdutoOrcamentoViewModel
    {
        public int id { get; set; }
        public int idOrcamento { get; set; }
        public int tipoProdutoOrc { get; set; }
        public int? idPrincipioAtivo { get; set; }
        public int? idProduto { get; set; }

        public decimal precoUnitario { get; set; }

        public DateTime? dataPreco { get; set; }
        public string descproduto { get; set; }
        public string descprincativo { get; set; }
        public string desctipoproduto { get; set; }
        public string descmoeda { get; set; }
    }
}