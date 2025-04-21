using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.MovimentoCaixa
{
    public class MovimentoCaixaViewModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Transação")]
        public int IdTransacao { get; set; }

        [DisplayName("Centro de Custo")]
        public int IdCentroCusto { get; set; }

        [DisplayName("Conta Corrente")]
        public string IdContaCorrente { get; set; }

        [DisplayName("Categoria")]
        public int IdCategoria { get; set; }

        [DisplayName("Sinal")]
        public string Sinal { get; set; }

        [DisplayName("Observação")]
        public string? Observacao { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [DisplayName("Data")]
        public DateTime DataMov { get; set; }

        public string? DescTransacao { get; set; }
        public string? DescCentroCusto { get; set; }
        public string? DescContaCorrente { get; set; }
        public string? DescCategoria { get; set; }
        public string idparceiro { get; set; }
        public string? nomeparceiro { get; set; }
    }
}