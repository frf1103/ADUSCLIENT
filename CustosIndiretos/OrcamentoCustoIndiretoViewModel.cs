namespace FarmPlannerClient.CustosIndiretos
{
    public class OrcamentoCustoIndiretoViewModel
    {
        public int Id { get; set; }
        public int IdSafra { get; set; }
        public DateTime Data { get; set; }
        public int idcontaCad { get; set; }

        public decimal valor { get; set; }

        public string idconta { get; set; }
    }
}