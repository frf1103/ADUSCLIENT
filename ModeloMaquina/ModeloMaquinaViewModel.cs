using FarmPlannerClient.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.ModeloMaquina
{
    public class ModeloMaquinaViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Marca")]
        public int idMarca { get; set; }

        [DisplayName("Combustível")]
        public Combustivel combustivel { get; set; }
    }
}