using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.ModeloMaquina
{
    public class ListModeloMaquinaViewModel
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int idMarca { get; set; }
        public string descMarca { get; set; }
        public string descComb { get; set; }
        public int combustivel { get; set; }
    }
}