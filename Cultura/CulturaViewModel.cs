using FarmPlannerClient.Variedade;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FarmPlannerClient.Cultura
{
    public class CulturaViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string descricao { get; set; }

        [DisplayName("UND Produtiva")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string unidadeProdutiva { get; set; }

        [DisplayName("Nome do Produto")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string nomeProduto { get; set; }

        [DisplayName("Dias Estimados Emergência")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public int diasEstimadosEmergencia { get; set; }

        [DisplayName("Código Externo")]
        public string? codigoExterno { get; set; }

        public List<ListVariedadeViewModel>? listVariedade { get; set; }
    }
}