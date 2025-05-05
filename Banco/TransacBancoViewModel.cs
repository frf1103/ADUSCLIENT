using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Banco
{
    public class TransacBancoViewModel
    {
        public string IdTransacBanco { get; set; }

        [Required]
        public int IdBanco { get; set; }

        [Required]
        public int idTransacao { get; set; }

        public int idcategoria { get; set; }
        public int idcentrocusto { get; set; }

        // Nomes para exibição
        public string? NomeBanco { get; set; }

        public string? NomeTransacao { get; set; }
        public string? NomeCategoria { get; set; }
    }
}