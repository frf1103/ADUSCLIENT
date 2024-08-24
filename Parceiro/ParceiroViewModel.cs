using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmPlannerClient.Enum;

namespace FarmPlannerClient.Parceiro
{
    public class ParceiroViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Razão Social")]
        public string razaoSocial { get; set; }

        [DisplayName("Fantasia")]
        public string fantasia { get; set; }

        [DisplayName("Tipo")]
        public TipodePessoa tipodePessoa { get; set; }

        [DisplayName("Registro")]
        public string registro { get; set; }

        public string idconta { get; set; }
    }
}