using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Moeda
{
    public class CotacaoMoedaViewModel
    {
        public int id { get; set; }
        public int idMoeda { get; set; }

       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayName("Data da Cotação")]
        public DateTime cotacaoData { get; set; }

        [DisplayName("Valor da Cotação")]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal cotacaoValor { get; set; }

        public string? descmoeda { get; set; }
    }
}