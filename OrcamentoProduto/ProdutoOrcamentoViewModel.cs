using System.ComponentModel;

namespace FarmPlannerClient.OrcamentoProduto
{
    public class ProdutoOrcamentoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        public int idOrcamento { get; set; }

        [DisplayName("Tipo de Produto")]
        public int tipoProdutoOrc { get; set; }

        [DisplayName("Princípio Ativo")]
        public int? idPrincipioAtivo { get; set; }

        [DisplayName("Produto")]
        public int? idProduto { get; set; }

        [DisplayName("Moeda")]
        public int idMoeda { get; set; }

        [DisplayName("Preço Unitário")]
        public decimal precoUnitario { get; set; }

        public DateTime? dataPreco { get; set; }
        public string idconta { get; set; }
        public string uid { get; set; }
    }
}