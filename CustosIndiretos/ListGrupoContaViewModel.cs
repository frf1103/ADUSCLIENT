namespace FarmPlannerClient.CustosIndiretos
{
    public class ListGrupoContaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdOrganizacao { get; set; }
        public int IdClasseConta { get; set; }
        public string? CodigoCliente { get; set; }
        public string? CodigoExterno { get; set; }
        public string DescOrganizacao { get; set; }
        public string DescClasse { get; set; }
    }
}