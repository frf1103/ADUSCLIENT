using System.ComponentModel.DataAnnotations;

namespace FarmPlannerClient.Comercializacao
{
    public class ListEntregaContratoViewModel
    {
        public int Id { get; set; }
        public int IdComercializacao { get; set; }
        public DateTime DataEntrega { get; set; }

        [MaxLength(100)]
        public string Documento { get; set; }

        public decimal Quantidade { get; set; }

        // public string descproduto { get; set; }
    }
}