namespace FarmPlannerClient.Comercializacao
{
    public class ListComercializacaoViewModel
    {
        public int id { get; set; }

        public int idSafra { get; set; }
        public int idParceiro { get; set; }
        public int idFazenda { get; set; }
        public decimal quantidade { get; set; }

        public int idMoeda { get; set; }
        public bool trava { get; set; }

        public decimal cBOT { get; set; }

        public decimal cambio { get; set; }

        public decimal premio { get; set; }

        public decimal valorUnitario { get; set; }

        public decimal valorTotal { get; set; }

        public DateTime dataEntrega { get; set; }
        public DateTime dataPagamento { get; set; }

        public decimal descontos { get; set; }

        public decimal valorLiquido { get; set; }

        public string descmoeda { get; set; }
        public string descsafra { get; set; }
        public string nomeparceiro { get; set; }
        public string descfazenda { get; set; }
        public string? numeroContrato { get; set; }
    }
}