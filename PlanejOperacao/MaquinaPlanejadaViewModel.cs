namespace FarmPlannerClient.PlanejOperacao
{
    public class MaquinaPlanejadaViewModel
    {
        public string idconta { get; set; }
        public int Id { get; set; }
        public int IdPlanejamento { get; set; }
        public int IdModeloMaquina { get; set; }
        public int IdMaquina { get; set; }

        public decimal Rendimento { get; set; }

        public decimal Consumo { get; set; }

        public decimal QtdHoraEstimada { get; set; }

        public decimal QtdCombEstimado { get; set; }
    }
}