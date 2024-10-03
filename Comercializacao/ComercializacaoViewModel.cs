namespace FarmPlannerClient.Comercializacao
{
    public class ComercializacaoViewModel
    {
        public int Id { get; set; }

        public int IdSafra { get; set; }
        public int IdParceiro { get; set; }
        public int IdFazenda { get; set; }
        public decimal Quantidade { get; set; }

        public int IdMoeda { get; set; }
        public bool Trava { get; set; }

        public decimal CBOT { get; set; }

        public decimal Cambio { get; set; }

        public decimal Premio { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal ValorTotal { get; set; }

        public DateTime DataEntrega { get; set; }
        public DateTime DataPagamento { get; set; }

        public decimal Descontos { get; set; }

        public decimal ValorLiquido { get; set; }

        public string? NumeroContrato { get; set; }
        public string idconta { get; set; }
        public string? uid { get; set; }
        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }
    }
}