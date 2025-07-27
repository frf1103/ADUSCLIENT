using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Assinatura
{
    public class AssinaturaContratoViewModel
    {
        public string comprador { get; set; }
        public string registrocomprador { get; set; }
        public string emailcomprador { get; set; }
        public string enderecocomprador { get; set; }
        public string municipiocomprador { get; set; }
        public string ufcomprador { get; set; }
        public string cepcomprador { get; set; }
        public string fonecomprador { get; set; }
        public int qtd { get; set; }
        public decimal valor { get; set; }
        public string formapagto { get; set; }
        public string estadocivil { get; set; }
        public string nomerepresentante { get; set; }
        public string cpfrepresentante { get; set; }
        public string datavenda { get; set; }
    }
}