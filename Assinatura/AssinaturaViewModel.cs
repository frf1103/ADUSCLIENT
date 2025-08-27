using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADUSClient.Enum;

namespace ADUSClient.Assinatura
{
    public class AssinaturaViewModel
    {
        [DisplayName("ID")]
        public string id { get; set; }

        [DisplayName("Parceiro")]
        public string idparceiro { get; set; }

        [DisplayName("Qtd")]
        public int qtd { get; set; }

        [DisplayName("Preço")]
        public double preco { get; set; }

        [DisplayName("Valor")]
        public double valor { get; set; }

        [DisplayName("Data")]
        [DataType(DataType.Date)]
        public DateTime datavenda { get; set; }

        [DisplayName("Forma de Pagto")]
        public FormaPagto idformapagto { get; set; }

        [DisplayName("ID Plataforma")]
        public string? idplataforma { get; set; }

        [DisplayName("Status")]
        public StatusAssinatura status { get; set; }

        [DisplayName("Observação")]
        public string? observacao { get; set; }

        [DisplayName("Plataforma")]
        public string? plataforma { get; set; }

        public string? idafiliado { get; set; }
        public bool origemadus { get; set; } = true;
    }

    public class MinhaParcelaViewModel
    {
        public int numparcela { get; set; }
        public int? idcaixa { get; set; }

        public DateTime datavencimento { get; set; }
        public DateTime? databaixa { get; set; }

        public decimal valor { get; set; }

        public string? nossonumero { get; set; }

        public string nomeparceiro { get; set; }

        public DateTime? dataestimadapagto { get; set; }
        public bool ischeckout { get; set; }

        public string status { get; set; }
    }
}