using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
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

        [NotMapped]
        public string valorInput { get; set; }

        public decimal Valor
        {
            get => ParseDecimal(valorInput);
            set => valorInput = FormatDecimal(value);
        }

        [DisplayName("Data")]
        public DateTime DataMov { get; set; }

        public string? DescTransacao { get; set; }
        public string? DescCentroCusto { get; set; }
        public string? DescContaCorrente { get; set; }
        public string? DescCategoria { get; set; }
        public string idparceiro { get; set; }
        public string? nomeparceiro { get; set; }
        public string? idmovbanco { get; set; }

        private decimal ParseDecimal(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor)) return 0;
            return decimal.TryParse(valor.Replace(".", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out var result) ? result : 0;
        }

        private string FormatDecimal(decimal valor)
        {
            return valor.ToString("N2", new CultureInfo("pt-BR"));
        }
    }
}