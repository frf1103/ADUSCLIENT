using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient
{
    public class ParametrosGuruViewModel
    {
        public int id { get; set; }
        public string token { get; set; }
        public DateTime ultdata { get; set; }
        public string urlsub { get; set; }
        public string urltransac { get; set; }
    }
}