using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.PrincipioAtivo
{
    public class PrincipioAtivoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string descricao { get; set; }

        public string idconta { get; set; }
    }
}