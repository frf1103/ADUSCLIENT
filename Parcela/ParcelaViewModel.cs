using ADUSClient.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace ADUSClient.Parcela
{
    public class ParcelaViewModel
    {
        [DisplayName("ID")]
        public string id { get; set; }

        [DisplayName("Assinatura")]
        public string? idassinatura { get; set; }

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

        [DisplayName("Valor")]
        [NotMapped]
        public string valorInput { get; set; }

        public decimal valor
        {
            get => ParseDecimal(valorInput);
            set => valorInput = FormatDecimal(value);
        }

        [DisplayName("Comissão")]
        [NotMapped]
        public string comissaoInput { get; set; }

        public decimal comissao
        {
            get => ParseDecimal(comissaoInput);
            set => comissaoInput = FormatDecimal(value);
        }

        [DisplayName("Desc Plataforma")]
        [NotMapped]
        public string descontoplataformaInput { get; set; }

        public decimal descontoplataforma
        {
            get => ParseDecimal(descontoplataformaInput);
            set => descontoplataformaInput = FormatDecimal(value);
        }

        [DisplayName("Desc Antecip")]
        [NotMapped]
        public string descontoantecipacaoInput { get; set; }

        public decimal descontoantecipacao
        {
            get => ParseDecimal(descontoantecipacaoInput);
            set => descontoantecipacaoInput = FormatDecimal(value);
        }

        [DisplayName("Acréscimos")]
        [NotMapped]
        public string acrescimosInput { get; set; }

        public decimal acrescimos
        {
            get => ParseDecimal(acrescimosInput);
            set => acrescimosInput = FormatDecimal(value);
        }

        [DisplayName("Descontos")]
        [NotMapped]
        public string descontosInput { get; set; }

        public decimal descontos
        {
            get => ParseDecimal(descontosInput);
            set => descontosInput = FormatDecimal(value);
        }

        [DisplayName("Valor Liquido")]
        [NotMapped]
        public string valorliquidoInput { get; set; }

        public decimal valorliquido
        {
            get => ParseDecimal(valorliquidoInput);
            set => valorliquidoInput = FormatDecimal(value);
        }

        // === Métodos auxiliares ===

        private decimal ParseDecimal(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor)) return 0;
            return decimal.TryParse(
                valor.Replace(".", "").Replace(",", "."),
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out var result
            ) ? result : 0;
        }

        private string FormatDecimal(decimal valor)
        {
            return valor.ToString("N2", new CultureInfo("pt-BR"));
        }

        //public decimal valorliquido { get; set; }

        [DisplayName("ID Checkout")]
        public string? idcheckout { get; set; }

        [DisplayName("Identificador")]
        public string? nossonumero { get; set; }

        /*
        [DisplayName("Acréscimos")]
        public decimal acrescimos { get; set; }

        [DisplayName("Descontos")]
        public decimal descontos { get; set; }
        */

        [DisplayName("Obs")]
        public string? observacao { get; set; }

        public string? idparceiro { get; set; }
        public DateTime? dataestimadapagto { get; set; }
    }
}