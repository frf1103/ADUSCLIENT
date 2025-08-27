using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Assinatura
{
    public class MinhaAssinaturaViewModel
    {
        public decimal TotalAssinaturas { get; set; }
        public decimal ValorParcelasAbertas { get; set; }
        public decimal ValorParcelasACompensar { get; set; }
        public decimal ValorParcelasCompensadas { get; set; }
        public decimal ValorComissoesPendentes { get; set; }
        public decimal ValorComissoesPagas { get; set; }

        public List<ListAssinaturaViewModel> ListaAssinaturas { get; set; }
        public List<MinhaParcelaViewModel> ParcelasEmAberto { get; set; }
        public List<MinhaParcelaViewModel> ParcelasCompensadas { get; set; }
        public List<MinhaParcelaViewModel> ParcelasAcompensar { get; set; }
        public List<MinhaParcelaViewModel> ComissoesPendentesDetalhes { get; set; }
        public List<MinhaParcelaViewModel> ComissoesPagasDetalhes { get; set; }
    }
}