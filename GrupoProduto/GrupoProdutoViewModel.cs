using FarmPlannerClient.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.GrupoProduto
{
    public class GrupoProdutoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Tipo")]
        public TipoGrupo tipo { get; set; }
    }
}