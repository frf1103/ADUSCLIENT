namespace FarmPlannerClient.ConfigArea
{
    public class ListConfigAreaViewModel
    {
        public int id { get; set; }
        public int idSafra { get; set; }
        public int idTalhao { get; set; }
        public int idVariedade { get; set; }

        public decimal area { get; set; }
        public string? desctalhao { get; set; }
        public string? descvariedade { get; set; }
        public string? descsafra { get; set; }
        public string? descfazenda { get; set; }

        public int? populacaoRecomendada { get; set; }

        public decimal? germinacao { get; set; }

        public decimal? pms { get; set; }

        public decimal? espacamento { get; set; }

        public decimal? margemSeguranca { get; set; }

        public decimal? stand { get; set; }

        public decimal? unidadeSementePrevista { get; set; }

        public decimal? qtdSementePrevista { get; set; }

        public decimal? prodEstimada { get; set; }

        public string idconta { get; set; }

        public int? idfazenda { get; set; } = null;

        public string? descconfig { get; set; }
    }
}