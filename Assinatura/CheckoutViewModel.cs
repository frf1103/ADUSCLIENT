namespace ADUSClient.Assinatura
{
    public class CheckoutViewModel
    {
        public int QuantidadeArvores { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string EmailConfirmacao { get; set; }

        public string FormaPagamento { get; set; } // Recorrente, Parcelado, Boleto, Pix
        public int? Parcelas { get; set; }

        public string NumeroCartao { get; set; }
        public string NomeTitular { get; set; }
        public string Cvv { get; set; }
        public string Validade { get; set; }

        public string Ddi { get; set; }
        public string Telefone { get; set; }

        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        // Retornos do Asaas
        public string IdClienteAsaas { get; set; }

        public string IdCobrancaAsaas { get; set; }
        public string LinkCobranca { get; set; }
        public string TipoPagamentoEfetivado { get; set; }
        public string TokenCartao { get; set; }
        public string LinhaDigitavel { get; set; }
        public string PayloadQrCode { get; set; }
        public string cpfCnpj { get; set; }
    }
}