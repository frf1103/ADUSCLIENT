using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.PlanejOperacao
{
    public class AssistentePlanejOperViewModel
    {
        public int idconfig { get; set; }
        public int operacao { get; set; }
        public int dae { get; set; }
        public bool plantio { get; set; }
        public decimal area { get; set; }
        public DateTime dataprevista { get; set; }

        public ICollection<ProdutosAssistenteViewModel> produtos { get; set; }
    }

    public class ProdutosAssistenteViewModel
    {
        public int idproduto { get; set; }
        public int idprincipio { get; set; }
        public decimal dosagem { get; set; }
        public decimal tamanho { get; set; }
        public decimal percent { get; set; }
    }
}