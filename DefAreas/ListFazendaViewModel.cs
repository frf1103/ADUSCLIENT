using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.DefAreas
{
    public class ListFazendaViewModel
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int idUF { get; set; }
        public int idMunicipio { get; set; }
        public int tipo { get; set; }
        public int tipoArrenda { get; set; }
        public decimal valorArrendamento { get; set; }
        public string? codigoExterno { get; set; }
        public int idRegiao { get; set; }
        public int? idCultura { get; set; }
        public int idOrganizacao { get; set; }
        public string desccultura { get; set; }
        public string descregiao { get; set; }
        public string desctipoprop { get; set; }
        public string desctipoarrenda { get; set; }
        public string nomeuf { get; set; }
        public string nomemunicipio { get; set; }
    }
}