using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FarmPlannerClient.DefAreas
{
    public class EditarTalhaoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Identificação")]
        [MaxLength(20)]
        public string descricao { get; set; }

        [DisplayName("Área Produtiva")]
        public decimal areaProdutiva { get; set; }

        [DisplayName("Tipo de Área")]
        public int tipoArea { get; set; }

        [DisplayName("Código Externo")]
        public string? codigoExterno { get; set; }

        public int idFazenda { get; set; }
        public int idAnoAgricola { get; set; }
        public string idconta { get; set; }
        public decimal? areaDisp { get; set; }
        public string? uid { get; set; }
        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }
    }
}