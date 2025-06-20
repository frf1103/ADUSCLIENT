using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Assinatura
{
    public class CartaoAssinaturaViewModel
    {
        public int? Id { get; set; } // Opcional para edição/atualização

        [Required(ErrorMessage = "Id da Assinatura é obrigatório.")]
        public string IdAssinatura { get; set; }

        [Required(ErrorMessage = "Token do cartão é obrigatório.")]
        [MaxLength(100, ErrorMessage = "Máximo de 100 caracteres para o IdToken.")]
        public string IdToken { get; set; }

        [Required(ErrorMessage = "Últimos dígitos do cartão são obrigatórios.")]
        [StringLength(4, ErrorMessage = "Informe exatamente os 4 últimos dígitos.")]
        public string UltimosDigitos { get; set; }

        public bool Ativo { get; set; } = true;

        [Required(ErrorMessage = "Bandeira do cartão é obrigatória.")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres para a bandeira.")]
        public string Bandeira { get; set; }
    }
}