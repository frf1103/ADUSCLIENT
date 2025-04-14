using ADUSClient.Enum;

namespace ADUSClient.Parcela
{
    public class ParcelaViewModel
    {
        public string id { get; set; }
        public string idassinatura { get; set; }
        public int numparcela { get; set; }
        public int? idcaixa { get; set; }
        public FormaPagto idformapagto { get; set; }
        public DateTime datavencimento { get; set; }
        public DateTime? databaixa { get; set; }
        public string plataforma { get; set; }

        public double comissao { get; set; }

        public double descontoplataforma { get; set; }

        public double valor { get; set; }

        public double descontoantecipacao { get; set; }

        public double valorliquido { get; set; }

        public string? idcheckout { get; set; }

        public string? nossonumero { get; set; }

        public double acrescimos { get; set; }
        public double descontos { get; set; }
        public string? observacao { get; set; }
    }
}