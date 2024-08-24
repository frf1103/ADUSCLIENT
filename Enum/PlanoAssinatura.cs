using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Enum
{
    public enum PlanoAssinatura
    {
        [Description("Degustação 30 dias")]
        DEGUSTACAO,

        [Description("Plano Anual R$ 1.678,80 em até 12 x R$ 139,90")]
        PLANOCARTAO,

        [Description("Plano Anual Pix de R$ 1.538,90")]
        PLANOPIX
    }
}