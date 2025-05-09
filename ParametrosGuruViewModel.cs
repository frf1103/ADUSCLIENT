﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient
{
    public class ParametrosGuruViewModel
    {
        public int id { get; set; }

        [DisplayName("Token")]
        public string token { get; set; }

        [DisplayName("Última Data")]
        public DateTime ultdata { get; set; }

        [DisplayName("URL Subscriptions")]
        public string urlsub { get; set; }

        [DisplayName("URL Transações")]
        public string urltransac { get; set; }

        [DisplayName("Transação Padrão")]
        public int? idtransacao { get; set; }

        [DisplayName("Categoria Padrão")]
        public int? idcategoria { get; set; }

        [DisplayName("Conta Padrão")]
        public string? idconta { get; set; }

        [DisplayName("Parceiro Padrão")]
        public string? idparceiro { get; set; }

        [DisplayName("Centro de Custo Padrão")]
        public int? idccusto { get; set; }

        [DisplayName("Conta Taxa Plataforma")]
        public int? idcategoriataxa { get; set; }

        [DisplayName("Conta Tx Antecipacao")]
        public int? idcategoriaant { get; set; }

        [DisplayName("Conta Comissão")]
        public int? idcategoriacomiss { get; set; }

        [DisplayName("Transação Comissão")]
        public int? idtransacaocomiss { get; set; }

        [DisplayName("Transação Taxa Plataforma")]
        public int? idtransacaotaxa { get; set; }

        [DisplayName("Transação Taxa Antecipação")]
        public int? idtransacaoant { get; set; }
    }
}