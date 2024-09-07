

namespace FarmPlannerClient.PlanejOperacao
{
    public class ListProdutoPlanejadoViewModel
    {
        public int id { get; set; }
        public int idConfigArea { get; set; }
       
        public decimal tamanho { get; set; }
       
        public decimal areaPercent { get; set; }
        public int idPlanejamento { get; set; }
        public int? idPrincipioAtivo { get; set; }
        public int? idProduto { get; set; }
       
        public decimal dosagem { get; set; }
       
        public decimal totalProduto { get; set; }
        public string descproduto { get; set; }
        public string descprincativo { get; set; }
        public string? descricao { get; set; }
        public int idcodigo { get; set; }
        public string? idtipo { get; set; }
    }
}
