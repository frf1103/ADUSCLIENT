using ADUSClient.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Parceiro
{
    public class ListParceiroViewModel
    {
        public string id { get; set; }

        public string razaoSocial { get; set; }
        public string fantasia { get; set; }
        public TipodePessoa tipodePessoa { get; set; }
        public string registro { get; set; }

        public string cep { get; set; }

        public string logradouro { get; set; }

        public string numero { get; set; }
        public string bairro { get; set; }
        public int idUF { get; set; }
        public string complemento { get; set; }

        public int idcidade { get; set; }
        public string? profissao { get; set; }
        public int estadoCivil { get; set; }
        public string? idRepresentante { get; set; }

        public string nomecidade { get; set; }

        public string nomeuf { get; set; }

        public DateTime dtNascimento { get; set; }

        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }

        public string? fone1 { get; set; }
        public string? fone2 { get; set; }
        public string? email { get; set; }
        public string? observacao { get; set; }

        public string desctipo { get; set; }
        public string descestadocivil { get; set; }
    }
}