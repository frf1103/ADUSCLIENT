namespace FarmPlannerClient.PlanejOperacao
{
    public class ListPlanejamentoOperacaoViewModel
    {
        public int id { get; set; }
        public int idConfigArea { get; set; }
        public DateTime dataPrevista { get; set; }
        public int idOperacao { get; set; }

        public bool plantio { get; set; }
        public int dAE { get; set; }

        //    public int IdOrcamento { get; set; }
        public decimal area { get; set; }

        public decimal qHorasEstimadas { get; set; }

        public decimal qCombustivelEstimado { get; set; }

        public int status { get; set; }

        public decimal custoOperacao { get; set; }

        public string descoperacao { get; set; }

        //     public string DescOrcamento { get; set; }
        public string desctalhao { get; set; }

        public string descvariedade { get; set; }
        public string descSafra { get; set; }
        public string? descconfig { get; set; }
    }
}