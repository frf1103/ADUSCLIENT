using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.ConfigArea
{
    public class PlanejPlantioViewModel
    {
        
        public int id { get; set; }

        public int? populacaoRecomendada { get; set; }

        public decimal? germinacao { get; set; }

        public decimal? pms { get; set; }

        public decimal? espacamento { get; set; }

        public decimal? margemSeguranca { get; set; }


    }
}
