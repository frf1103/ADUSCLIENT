using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADUSClient.Enum;

namespace ADUSClient.Parceiro
{
    public class ParceiroViewModel
    {
        [DisplayName("ID")]
        public string? id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Razão Social/Nome")]
        public string razaoSocial { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Fantasia/Primeiro Nome")]
        public string fantasia { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Tipo de Pessoa")]
        public TipodePessoa tipodePessoa { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Registro")]
        public string registro { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("CEP")]
        public string cep { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Logradouro")]
        public string logradouro { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Número")]
        public string numero { get; set; }

        [DisplayName("Complemento")]
        public string? complemento { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Bairro")]
        public string bairro { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("UF")]
        public int iduf { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Cidade")]
        public int idcidade { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Profissão")]
        public string profissao { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Estado Civil")]
        public int estadoCivil { get; set; }

        [DisplayName("Representante Legal")]
        public string? idRepresentante { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayName("Dt Nascimento")]
        public DateTime dtNascimento { get; set; }

        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Fone 1")]
        public string fone1 { get; set; }

        [DisplayName("Fone 2")]
        public string? fone2 { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Email")]
        public string? email { get; set; }

        [DisplayName("Observação")]
        public string? observacao { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Sexo")]
        public TipoSexo sexo { get; set; }
    }
}