namespace FarmPlannerClient.PlanejOperacao
{
    public class PlanejamentoOperacaoViewModel
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
        public string idconta { get; set; }

        public string? uid { get; set; }
        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }
    }
}