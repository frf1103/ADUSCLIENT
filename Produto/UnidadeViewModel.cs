using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Produto
{
    public class UnidadeViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(20)]
        public string descricao { get; set; }
        [DisplayName("Conversor(KG)")]
        public decimal multiplo { get; set; }
    }
}