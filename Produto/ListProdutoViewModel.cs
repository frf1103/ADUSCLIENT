using FarmPlannerClient.Enum;

namespace FarmPlannerClient.Produto
{
    public class ListProdutoViewModel
    {
        public string idconta { get; set; }
        public string descricao { get; set; }
        public int idGrupoProduto { get; set; }

        public int idFabricante { get; set; }

        public int idPrincipioAtivo { get; set; }
        public int unidadeBasica { get; set; }
        public int id { get; set; }
        public string descunidade { get; set; }
        public string descprincipio { get; set; }
        public string descfab { get; set; }
        public string descgrupo { get; set; }

        public string? tipo { get; set; }
    }
}