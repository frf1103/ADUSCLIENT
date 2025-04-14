using System.ComponentModel.DataAnnotations;

namespace ADUSClient.Localidade
{
    public class MunicipioViewModel
    {
        public int id { get; set; }
        public string nome { get; set; }

        [MaxLength(7)]
        public string codigoIBGE { get; set; }

        public int idUF { get; set; }
    }
}