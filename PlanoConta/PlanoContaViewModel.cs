using System.ComponentModel;

namespace ADUSClient.PlanoConta
{
    public class PlanoContaViewModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Conta Mãe")]
        public int? IdMae { get; set; }

        [DisplayName("Sinal")]
        public string Sinal { get; set; }

        // Exibição da conta mãe
    }
}