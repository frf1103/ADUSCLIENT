using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FarmPlannerClient.DefAreas
{
    public class FazendaViewModel
    {
        public string idconta { get; set; }

        [DisplayName("ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("UF")]
        public int idUF { get; set; }

        [DisplayName("Município")]
        public int idMunicipio { get; set; }

        [DisplayName("Tipo")]
        public int tipo { get; set; }

        [DisplayName("Tipo de Arrend.")]
        public int tipoArrenda { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        [DisplayName("Valor Arrendamento")]
        public decimal valorArrendamento { get; set; }

        [DisplayName("Código Externo")]
        public string? codigoExterno { get; set; }

        [DisplayName("Região")]
        public int idRegiao { get; set; }

        [DisplayName("Cultura")]
        public int? idCultura { get; set; }

        public int idOrganizacao { get; set; }
    }
}