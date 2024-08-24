namespace FarmPlannerClient.Variedade
{
    public class ListVariedadeViewModel
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int idCultura { get; set; }
        public int ciclo { get; set; }
        public string codigoExterno { get; set; }

        public int idTecnologia { get; set; }
        public string desctecnologia { get; set; }
        public string desccultura { get; set; }
    }
}