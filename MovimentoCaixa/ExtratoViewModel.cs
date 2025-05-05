using System.ComponentModel.DataAnnotations;

namespace ADUSClient.MovimentoCaixa
{
    public class ExtratoViewModel
    {
        [Required]
        public string IdTransacBanco { get; set; }

        public int IdTransacao { get; set; }

        [Required]
        [StringLength(255)]
        public string Historico { get; set; }

        public decimal Valor { get; set; }
        public DateTime datamov { get; set; }
        public string id { get; set; }
        public string? idConta { get; set; }
        public int? idCategoria { get; set; }
        public int? idCentrocusto { get; set; }
        public string idparceiro { get; set; }
        public int idbanco { get; set; }
    }
}