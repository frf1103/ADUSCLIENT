using System.ComponentModel;

namespace FarmPlannerClient.ModeloMaquina
{
    public class ModeloParametroViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Modelo da Máquina")]
        public int idModeloMaquina { get; set; }

        [DisplayName("Cultura")]
        public int idCultura { get; set; }

        [DisplayName("Operação")]
        public int idOperacao { get; set; }

        [DisplayName("Rendimento")]
        public decimal rendimento { get; set; }

        [DisplayName("Consumo")]
        public decimal consumo { get; set; }

        public string idconta { get; set; }
    }
}