using FarmPlannerClient.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Conta
{
    public class AssinaturaContaViewModel
    {
        public int id { get; set; }
        public string idconta { get; set; }

        [DisplayName("Plano de Assinatura")]
        public PlanoAssinatura plano { get; set; }

        public DateTime dataassinatura { get; set; }
        public DateTime dataexpiracao { get; set; }
    }
}