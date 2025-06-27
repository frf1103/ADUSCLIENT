using System.ComponentModel.DataAnnotations;

namespace ADUSClient.Assinatura
{
    public class CheckoutViewModel
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF ou CNPJ é obrigatório")]
        public string cpfCnpj { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Confirmação de e-mail é obrigatória")]
        [Compare("Email", ErrorMessage = "E-mails não coincidem")]
        public string EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "Quantidade de árvores é obrigatória")]
        public int QuantidadeArvores { get; set; }

        [Required(ErrorMessage = "DDI é obrigatório")]
        public string Ddi { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório")]
        [RegularExpression(@"\d{9,15}", ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "CEP é obrigatório")]
        [RegularExpression(@"\d{8}", ErrorMessage = "CEP inválido")]
        public string Cep { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        [Required(ErrorMessage = "Forma de pagamento é obrigatória")]
        public string FormaPagamento { get; set; }

        public int? Parcelas { get; set; }
        public DateTime? DataVencimento { get; set; }

        public string? NumeroCartao { get; set; }
        public string? NomeTitular { get; set; }

        //  [RegularExpression(@"^(0[1-9]|1[0-2])/\d{4}$", ErrorMessage = "Formato de validade deve ser MM/AAAA")]
        public string? Validade { get; set; }

        // [RegularExpression(@"\d{3,4}", ErrorMessage = "CVV inválido")]
        public string? Cvv { get; set; }

        // Dados de retorno da cobrança
        public string? IdClienteAsaas { get; set; }

        public string? IdCobrancaAsaas { get; set; }
        public string? LinkCobranca { get; set; }
        public string? TokenCartao { get; set; }
        public string? LinhaDigitavel { get; set; }
        public string? PayloadQrCode { get; set; }
        public string? TipoPagamentoEfetivado { get; set; }

        public string? idafiliado { get; set; }

        // Valor calculado no backend
        public decimal ValorTotal => QuantidadeArvores * 47;
       
    }
}