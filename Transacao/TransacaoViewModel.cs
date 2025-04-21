using ADUSClient.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Transacao
{
    public class TransacaoViewModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Sinal { get; set; } // "D" ou "C"

        public TipoContra Contrapartida { get; set; }

        public string? desccontra { get; set; }
    }
}