using System.ComponentModel;

namespace FarmPlannerClient.Maquina
{
    public class MaquinaViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        public string idconta { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Ano")]
        public int ano { get; set; }

        [DisplayName("Código Externo")]
        public string? codigoExterno { get; set; }

        [DisplayName("Modelo")]
        public int idModeloMaquina { get; set; }

        public int idorganizacao { get; set; }
    }
}