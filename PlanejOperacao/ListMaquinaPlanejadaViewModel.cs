namespace FarmPlannerClient.PlanejOperacao
{
    public class ListMaquinaPlanejadaViewModel
    {
        public int id { get; set; }
        public int idPlanejamento { get; set; }
        public int idModeloMaquina { get; set; }
        public int? idMaquina { get; set; }
        public decimal rendimento { get; set; }
        public decimal consumo { get; set; }
        public decimal qtdHoraEstimada { get; set; }
        public decimal qtdCombEstimado { get; set; }
        public string descModelo { get; set; }
        public string? descMaquina { get; set; }
    }
}