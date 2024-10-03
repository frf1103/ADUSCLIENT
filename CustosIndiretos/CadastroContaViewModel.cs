using System.ComponentModel;

namespace FarmPlannerClient.CustosIndiretos
{
    public class CadastroContaViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        public int idGrupoConta { get; set; }

        [DisplayName("Código Externo")]
        public string? codigoExterno { get; set; }

        [DisplayName("Código do Cliente")]
        public string? codigoCliente { get; set; }

        public string idconta { get; set; }
        public string uid { get; set; }
    }
}