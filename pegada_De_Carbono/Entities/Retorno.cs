using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pegada_De_Carbono.Entities
{
    public class Retorno
    {
        public bool status { get; set; }
        public string message { get; set; }
        public string datetime { get; set; }
        public long duration { get; set; }
        public object data { get; set; }
    }
}
