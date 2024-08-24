using FarmPlannerClient.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.ClasseConta
{
    public class ClasseContaViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Tipo")]
        public TipoClasseConta tipoClasseConta { get; set; }
    }
}