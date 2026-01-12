using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Dijkstry
{
    internal class Krawedz
    {
        public int start;
        public int koniec;
        public int waga;

        public Krawedz(int start, int koniec, int waga)
        {
            this.start = start;
            this.koniec = koniec;
            this.waga = waga;
        }
    }
}
