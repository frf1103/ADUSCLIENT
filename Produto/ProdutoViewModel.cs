using System.ComponentModel;

namespace FarmPlannerClient.Produto
{
    public class ProdutoViewModel
    {
        public string idconta { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Grupo")]
        public int idGrupoProduto { get; set; }

        [DisplayName("Fabricante")]
        public int idFabricante { get; set; }

        [DisplayName("Princípio Ativo")]
        public int idPrincipioAtivo { get; set; }

        [DisplayName("UND Básica")]
        public int idunidade { get; set; }

        [DisplayName("ID")]
        public int id { get; set; }

        public string? uid { get; set; }
        public int? tipo { get; set; }
    }
}