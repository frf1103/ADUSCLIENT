namespace FarmPlannerClient.Maquina
{
    public class ListMaquinaParametroViewModel
    {
        public int id { get; set; }
        public int idMaquina { get; set; }
        public int idCultura { get; set; }
        public int idOperacao { get; set; }

        public decimal rendimento { get; set; }

        public decimal consumo { get; set; }

        public string descMaquina { get; set; }
        public string descCultura { get; set; }
        public string descOperacao { get; set; }
    }
}