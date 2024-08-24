namespace FarmPlannerClient.ModeloMaquina
{
    public class ListModeloParametroViewModel
    {
        public int id { get; set; }
        public int idModeloMaquina { get; set; }
        public int idCultura { get; set; }
        public int idOperacao { get; set; }

        public decimal rendimento { get; set; }

        public decimal consumo { get; set; }

        public string descModelo { get; set; }
        public string descCultura { get; set; }
        public string descOperacao { get; set; }
    }
}