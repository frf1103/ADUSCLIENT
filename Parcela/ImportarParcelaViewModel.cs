using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Parcela
{
    public class ImportarParcelaViewModel
    {
        public string id { get; set; }
        public string registro { get; set; }
        public string nome { get; set; }
        public DateTime data { get; set; }
        public decimal valor { get; set; }
        public DateTime? dataestimada { get; set; }
        public decimal descontoplataforma { get; set; }
        public decimal comissao { get; set; }
        public string tipo { get; set; }
    }
}