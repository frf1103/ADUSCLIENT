namespace FarmPlannerClient.CustosIndiretos
{
    public class ListOrcamentoCustoIndiretoViewModel
    {
        public int Id { get; set; }
        public int IdSafra { get; set; }
        public DateTime Data { get; set; }
        public int idcontaCad { get; set; }

        public decimal valor { get; set; }

        public string descconta { get; set; }
        public string descsafra { get; set; }
        public string idconta { get; set; }
    }
}