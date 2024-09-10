using System.ComponentModel;

namespace FarmPlannerClient.PlanejOperacao
{
    public class MaquinaPlanejadaViewModel
    {
        public string idconta { get; set; }
        [DisplayName("ID")]
        public int id { get; set; }
        public int idPlanejamento { get; set; }
        [DisplayName("Modelo")]
        public int idModeloMaquina { get; set; }
        [DisplayName("Máquina")]
        public int? idMaquina { get; set; }

        [DisplayName("Rendimento")]
        public decimal rendimento { get; set; }
        [DisplayName("Consumo")]
        public decimal consumo { get; set; }
        [DisplayName("Hor Estimada")]
        public decimal qtdHoraEstimada { get; set; }
        [DisplayName("Comb Estimado")]
        public decimal qtdCombEstimado { get; set; }
        public string? uid { get; set; }
    }
}