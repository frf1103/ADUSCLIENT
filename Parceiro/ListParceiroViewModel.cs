using FarmPlannerClient.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Parceiro
{
    public class ListParceiroViewModel
    {
        public int id { get; set; }
        public string razaoSocial { get; set; }
        public string fantasia { get; set; }
        public TipodePessoa tipodePessoa { get; set; }
        public string registro { get; set; }
        public string desctipo { get; set; }
        public string idconta { get; set; }
    }
}