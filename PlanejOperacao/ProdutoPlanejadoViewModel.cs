using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FarmPlannerClient.PlanejOperacao
{
    public class ProdutoPlanejadoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Seleciona a área configurada")]
        public int idConfigArea { get; set; }
        [DisplayName("Área")]
        public decimal tamanho { get; set; }
        [DisplayName("Percent")]
        public decimal areaPercent { get; set; }

        public int idPlanejamento { get; set; }
        [DisplayName("Princípio Ativo")]
        public int? idPrincipioAtivo { get; set; }
        [DisplayName("Produto")]
        public int? idProduto { get; set; }

        [DisplayName("Dosagem")]
        public decimal dosagem { get; set; }
        [DisplayName("Total Aplicado")]
        public decimal totalProduto { get; set; }

        public string idconta { get; set; }

        public string? uid { get; set; }
    }
}