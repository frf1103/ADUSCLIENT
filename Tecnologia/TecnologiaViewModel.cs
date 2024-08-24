using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Tecnologia
{
    public class TecnologiaViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string descricao { get; set; }
    }
}