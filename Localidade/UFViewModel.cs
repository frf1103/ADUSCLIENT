using System.ComponentModel.DataAnnotations;

namespace ADUSClient.Localidade
{
    public class UFViewModel
    {
        public int id { get; set; }

        [MaxLength(100)]
        public string nome { get; set; }

        [MaxLength(2)]
        public string sigla { get; set; }

        [MaxLength(2)]
        public string codigoIBGE { get; set; }
    }
}