using System.ComponentModel;

namespace FarmPlannerClient.ConfigArea
{
    public class ConfigAreaViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Safra")]
        public int idSafra { get; set; }

        [DisplayName("Talhão")]
        public int idTalhao { get; set; }

        [DisplayName("Variedade")]
        public int idVariedade { get; set; }

        [DisplayName("Área")]
        public decimal area { get; set; }

        [DisplayName("População Recomendada")]
        public int? populacaoRecomendada { get; set; }

        [DisplayName("Germinação")]
        public decimal? germinacao { get; set; }

        [DisplayName("PMS")]
        public decimal? pms { get; set; }

        [DisplayName("Espaçamento")]
        public decimal? espacamento { get; set; }

        [DisplayName("Margem de Segurança")]
        public decimal? margemSeguranca { get; set; }

        [DisplayName("Stand")]
        public decimal? stand { get; set; }

        [DisplayName("Semente Prevista(UND)")]
        public decimal? unidadeSementePrevista { get; set; }

        [DisplayName("Qtd Semente(KG)")]
        public decimal? qtdSementePrevista { get; set; }

        [DisplayName("Produção Estimada")]
        public decimal? prodEstimada { get; set; }

        public string idconta { get; set; }

        [DisplayName("Fazenda")]
        public int? idfazenda { get; set; } = null;

        public string? uid { get; set; }
        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }
        public string? descconfig { get; set; }
    }
}