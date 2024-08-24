using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Regiao
{
    public class RegiaoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string nome { get; set; }

        [DisplayName("Máscara")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string mascara { get; set; }
    }
}