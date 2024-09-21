using System.ComponentModel;

namespace FarmPlannerClient.OrcamentoProduto
{
    public class OrcamentoProdutoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Descrição")]
        public string descricao { get; set; }
        [DisplayName("Safra")]
        public int idSafra { get; set; }
        [DisplayName("Fazenda")]
        public int idFazenda { get; set; }
        public string idconta { get; set; }

        public string uid { get; set; }
    }
}