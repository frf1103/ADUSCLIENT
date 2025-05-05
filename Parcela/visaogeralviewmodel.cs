using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Parcela
{
    public class visaogeralviewmodel
    {
        public string idParceiro { get; set; }
        public string nomeParceiro { get; set; }
        public string formaPagamento { get; set; }
        public string plataForma { get; set; }
        public decimal valorLiquido { get; set; }
        public decimal valorVencidas { get; set; }
        public decimal valorAVencer { get; set; }
        public decimal comissaoPaga { get; set; }
        public decimal taxaAntecipacao { get; set; }
        public decimal taxaPlataforma { get; set; }
        public decimal valorRecebido { get; set; }
        public decimal valorPago { get; set; }
        public decimal valortotal { get; set; }
        public int arvores { get; set; }
        public decimal acompensar { get; set; }
    }
}

/*
idParceiro = g.Key.uid,
                    nomeParceiro = g.Key.RazaoSocial,
                    formaPagamento = g.Key.formaPagamento,
                    plataForma = g.Key.plataForma,
                    valorLiquido = g.Sum(p => p.valorliquido),
                    valorVencidas = g.Where(p => p.databaixa == null && p.datavencimento < hoje).Sum(p => p.valor),
                    valorAVencer = g.Where(p => p.databaixa == null && p.datavencimento >= hoje).Sum(p => p.valor),
                    comissaoPaga = g.Sum(p => p.comissao),
                    taxaAntecipacao = g.Sum(p => p.descontoantecipacao),
                    taxaPlataforma = g.Sum(p => p.descontoplataforma),
                    valorRecebido = g.Sum(p => p.valorliquido)
*/