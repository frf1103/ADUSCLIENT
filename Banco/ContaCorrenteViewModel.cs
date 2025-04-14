using System.ComponentModel;

namespace ADUSClient.Banco
{
    public class ContaCorrenteViewModel
    {
        [DisplayName("ID")]
        public string id { get; set; } = string.Empty;

        [DisplayName("Descrição")]
        public string descricao { get; set; } = string.Empty;

        [DisplayName("Agência")]
        public string agencia { get; set; } = string.Empty;

        [DisplayName("Conta no Banco")]
        public string contaBanco { get; set; } = string.Empty;

        [DisplayName("Titular")]
        public string titular { get; set; } = string.Empty;

        public int bancoId { get; set; }
    }
}