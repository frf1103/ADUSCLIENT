using System.ComponentModel;

namespace FarmPlannerClient.Operacao
{
    public class OperacaoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Tipo")]
        public int idTipoOperacao { get; set; }

        [DisplayName("Insumo?")]
        public bool insumo { get; set; }

        [DisplayName("Código Externo")]
        public string? codigoExterno { get; set; }

        [DisplayName("Rendimento Padrão")]
        public decimal? rendimento { get; set; }

        [DisplayName("Consumo Padrão")]
        public decimal? consumo { get; set; }

        public string idconta { get; set; }
    }
}