using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Convite
{
    public class ConviteViewModel
    {
        public string IdConvite { get; set; }
        public string Fone { get; set; }

        [DisplayName("Email")]
        public string? Email { get; set; }

        [DisplayName("Criação")]
        public DateTime DataCriacao { get; set; }

        [DisplayName("Expiração")]
        public DateTime DataExpiracao { get; set; }

        public string IdAfiliado { get; set; }

        [DisplayName("Plataforma")]
        public int IdPlataforma { get; set; }

        public int Status { get; set; }
        public string? idassinatura { get; set; }
        public string? idformapgto { get; set; }

        [DisplayName("Nome")]
        public string? titular { get; set; }
    }
}