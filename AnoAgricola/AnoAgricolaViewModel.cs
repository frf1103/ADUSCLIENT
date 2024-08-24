using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.AnoAgricola
{
    public class AnoAgricolaViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Início")]
        [DataType(DataType.Date)]
        public DateTime dataInicio { get; set; }

        [DisplayName("Fim")]
        [DataType(DataType.Date)]
        public DateTime dataFim { get; set; }

        [DisplayName("Código Externo")]
        public string? codigoExterno { get; set; }

        [DisplayName("Orgnização")]
        public int idOrganizacao { get; set; }

        public string idconta { get; set; }

        public string? descorganizacao { get; set; }
    }
}