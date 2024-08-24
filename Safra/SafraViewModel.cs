using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Safra
{
    public class SafraViewModel
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

        [DisplayName("Codigo Externo")]
        public string? codigoExterno { get; set; }

        [DisplayName("Abertura?")]
        public bool abertura { get; set; }

        [DisplayName("Reforma?")]
        public bool reforma { get; set; }

        [DisplayName("Cultura")]
        public int? idCultura { get; set; }

        public int? idAnoAgricola { get; set; }
        public string? idconta { get; set; }
    }
}