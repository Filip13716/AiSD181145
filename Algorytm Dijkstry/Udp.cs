using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Dijkstry
{
    internal class Udp
    {
        public int u { get; set; }
        public int d { get; set; }
        public int p { get; set; }

        public Udp(int u)
        {
            this.u = u;
            d = int.MaxValue;
            p = -1;
        }

        public void Set(int d, int p)
        {
            this.d = d;
            this.p = p;
        }
    }
}
