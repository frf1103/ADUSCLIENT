using ADUSClient.Enum;
using System.ComponentModel;

namespace ADUSClient.Parcela
{
    public class ParcelaViewModel
    {
        [DisplayName("ID")]
        public string id { get; set; }

        [DisplayName("Assinatura")]
        public string idassinatura { get; set; }

        [DisplayName("Parcela")]
        public int numparcela { get; set; }

        [DisplayName("Id Caixa")]
        public int? idcaixa { get; set; }

        [DisplayName("Forma")]
        public FormaPagto idformapagto { get; set; }

        [DisplayName("Vencimento")]
        public DateTime datavencimento { get; set; }

        [DisplayName("Data da Baixa")]
        public DateTime? databaixa { get; set; }

        [DisplayName("Plataforma")]
        public string plataforma { get; set; }

        [DisplayName("COmissão")]
        public decimal comissao { get; set; }

        [DisplayName("Desconto Plat")]
        public decimal descontoplataforma { get; set; }

        [DisplayName("Valor")]
        public decimal valor { get; set; }

        [DisplayName("Desc Antecip")]
        public decimal descontoantecipacao { get; set; }

        [DisplayName("Liquido")]
        public decimal valorliquido { get; set; }

        [DisplayName("ID Checkout")]
        public string? idcheckout { get; set; }

        [DisplayName("Identificador")]
        public string? nossonumero { get; set; }

        [DisplayName("Acréscimos")]
        public decimal acrescimos { get; set; }

        [DisplayName("Descontos")]
        public decimal descontos { get; set; }

        [DisplayName("Obs")]
        public string? observacao { get; set; }

        public string? idparceiro { get; set; }
        public DateTime? dataestimadapagto { get; set; }
    }
}