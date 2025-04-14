using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Banco
{
    public class BancoViewModel
    {
        public int id { get; set; }
        public string descricao { get; set; } = string.Empty;
        public string codigo { get; set; } = string.Empty;

        public ICollection<ContaCorrenteViewModel> ContasCorrentes { get; set; } = new List<ContaCorrenteViewModel>();
    }
}