using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Produto
{
    public class ProdutoPrincipioViewModel
    {
        public string idconta { get; set; }
        public int idproduto { get; set; }

        [DisplayName("Princípio Ativo")]
        public int idprincipio { get; set; }

        [DisplayName("Concentração(g/kg ou g/lt)")]
        public decimal quantidade { get; set; }

        public string? descprincipio { get; set; }

        public string? descproduto { get; set; }
        public string uid { get; set; }
    }
}