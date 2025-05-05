using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.MovimentoCaixa
{
    public class ExtratoConta
    {
        public DateTime datamov { get; set; }
        public string historico { get; set; }
        public string sinal { get; set; }
        public decimal? debito { get; set; }
        public decimal? credito { get; set; }
        public decimal valor { get; set; }
        public decimal? saldo { get; set; }
        public string? idmovbanco { get; set; }
        public string tipo { get; set; }
    }
}