using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy_dwókierunkowe
{
    internal class Slownik
    {
        public Element n { get; set; }
        public int value { get; set; }

        public Slownik(Element n, int value)
        {
            this.n = n;
            this.value = value;
        }
    }
}
