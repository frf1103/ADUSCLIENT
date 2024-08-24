using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.PreferUsu
{
    public class PreferUsuViewModel
    {
        public string uid { get; set; }

        [DisplayName("Escolha uma Organização")]
        public int idorganizacao { get; set; }

        [DisplayName("Escolha um Ano Agrícola")]
        public int idanoagricola { get; set; }

        public string? descorg { get; set; } = null;
        public string? descano { get; set; } = null;
        public string idconta { get; set; }
    }
}