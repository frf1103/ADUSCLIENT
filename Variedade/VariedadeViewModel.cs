using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FarmPlannerClient.Variedade
{
    public class VariedadeViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [DisplayName("Descrição")]
        public string descricao { get; set; }

        public int idCultura { get; set; }

        [DisplayName("Ciclo")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public int ciclo { get; set; }

        [DisplayName("Código Externo")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string? codigoExterno { get; set; }

        [DisplayName("Tecnologia")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public int idTecnologia { get; set; }

        public string? desccultura { get; set; }
    }
}