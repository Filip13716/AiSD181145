using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Kruskala
{
    internal class Krawedz
    {
        public Wezel poczatek;
        public Wezel koniec;
        public int waga;

        public Krawedz(Wezel poczatek, Wezel koniec)
        {
            this.poczatek = poczatek;
            this.koniec = koniec;
            waga = 1;
        }

        public Krawedz(Wezel poczatek, Wezel koniec, int wartosc)
        {
            this.poczatek = poczatek;
            this.koniec = koniec;
            this.waga = wartosc;
        }
    }
}
