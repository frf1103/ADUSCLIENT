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
    }
}