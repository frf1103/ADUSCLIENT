using FarmPlannerClient.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Organizacao
{
    public class OrganizacaoViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome")]
        [MaxLength(100)]
        public string nome { get; set; }

        [DisplayName("Máscara")]
        [MaxLength(15)]
        public string mascara { get; set; }

        [DisplayName("Tipo")]
        public TipodePessoa tipoPessoa { get; set; }

        [DisplayName("Registro")]
        public string registro { get; set; }

        public string idconta { get; set; }
        public List<OrganizacaoUsuarioViewModel>? usuarios { get; set; }
        public string? desctipo { get; set; }
    }
}