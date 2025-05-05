using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Assinatura
{
    public class ListAssinaturaViewModel
    {
        public string id { get; set; }

        public string idparceiro { get; set; }
        public int qtd { get; set; }

        public double preco { get; set; }

        public double valor { get; set; }

        public DateTime datavenda { get; set; }
        public int idformapagto { get; set; }

        public string? idplataforma { get; set; }
        public int status { get; set; }

        public string? observacao { get; set; }

        public string nomeparceiro { get; set; }

        public string descstatus { get; set; }
        public string descforma { get; set; }

        public string? plataforma { get; set; }
    }
}