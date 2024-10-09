using PagSeguro.DotNet.Sdk.Common.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FarmPlannerClient.PlanejOperacao
{
    public class PlanejamentoOperacaoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Área Configurada")]
        public int idConfigArea { get; set; }

        [DisplayName("Data Prevista")]
        public DateTime dataPrevista { get; set; }

        [DisplayName("Operação")]
        public int idOperacao { get; set; }

        [DisplayName("Plantio?")]
        public bool plantio { get; set; }

        [DisplayName("DAE")]
        public int dae { get; set; }

        //    public int IdOrcamento { get; set; }

        [DisplayName("Area")]
        public decimal area { get; set; }

        [DisplayName("Qtd Horas Estimadas")]
        public decimal qHorasEstimadas { get; set; }

        [DisplayName("Combustivel Gasto(lt)")]
        public decimal qCombustivelEstimado { get; set; }

        [DisplayName("Status")]
        public int status { get; set; }

        [DisplayName("Custo da Operação")]
        public decimal custoOperacao { get; set; }

        public string idconta { get; set; }

        public string? uid { get; set; }
        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }

        [DisplayName("Percentual")]
        public decimal? percentual { get; set; }
    }
}