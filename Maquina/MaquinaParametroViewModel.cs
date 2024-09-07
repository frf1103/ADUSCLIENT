using System.ComponentModel;

namespace FarmPlannerClient.Maquina
{
    public class MaquinaParametroViewModel
    {
        public int id { get; set; }

        [DisplayName("Máquina")]
        public int idMaquina { get; set; }

        [DisplayName("Cultura")]
        public int idCultura { get; set; }

        [DisplayName("Operação")]
        public int idOperacao { get; set; }

        [DisplayName("Rendimento(ha/h)")]
        public decimal rendimento { get; set; }

        [DisplayName("Consumo(l/h)")]
        public decimal consumo { get; set; }

        public string idconta { get; set; }
    }
}