using System.ComponentModel.DataAnnotations;

namespace FarmPlannerClient.Comercializacao
{
    public class EntregaContratoViewModel
    {
        public int id { get; set; }
        public int idComercializacao { get; set; }
        public DateTime dataEntrega { get; set; }

        [MaxLength(100)]
        public string documento { get; set; }

        public decimal quantidade { get; set; }

        public string idconta { get; set; }
        public string? uid { get; set; }
    }
}