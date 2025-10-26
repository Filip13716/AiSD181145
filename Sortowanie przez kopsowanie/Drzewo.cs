using System;
using System.Collections.Generic;

namespace Sortowanie_przez_kopsowanie
{
    internal class Drzewo
    {
        public Wezel korzen;
        int liczbaEle;

        Wezel ZnajdzWezelPoIndeksie(int index)
        {
            if (index < 1) return null;
            List<int> bin = new List<int>();
            int i = index;
            while (i > 1)
            {
                bin.Add(i % 2);
                i /= 2;
            }
            bin.Reverse();

            Wezel temp = korzen;
            foreach (int bit in bin)
            {
                if (temp == null) return null;
                temp = (bit == 0) ? temp.dzieckoL : temp.dzieckoP;
            }
            return temp;
        }

        Wezel ZnajdzRodzicaDlaNowego()
        {
            int noweIdx = liczbaEle;
            if (noweIdx == 1) return null;
            int parentIdx = noweIdx / 2;
            return ZnajdzWezelPoIndeksie(parentIdx);
        }

        public void Dodaj(int n)
        {
            if (korzen == null)
            {
                korzen = new Wezel(n);
                liczbaEle = 1;
                return;
            }

            liczbaEle += 1;

            Wezel rodzic = ZnajdzRodzicaDlaNowego();
            Wezel dodany = rodzic.Dodaj(n);
            PrzywrocWlasnoscWgore(dodany);
        }

        void PrzywrocWlasnoscWgore(Wezel w)
        {
            while (w.rodzic != null && w.value > w.rodzic.value)
            {
                int tmp = w.rodzic.value;
                w.rodzic.value = w.value;
                w.value = tmp;
                w = w.rodzic;
            }
        }

        void PrzywrocWlasnoscWdol(Wezel w)
        {
            while (w != null)
            {
                Wezel największy = w;
                if (w.dzieckoL != null && w.dzieckoL.value > największy.value) największy = w.dzieckoL;
                if (w.dzieckoP != null && w.dzieckoP.value > największy.value) największy = w.dzieckoP;

                if (największy == w) break;

                int tmp = w.value;
                w.value = największy.value;
                największy.value = tmp;

                w = największy;
            }
        }

        public int UsunKorzen()
        {
            if (liczbaEle == 0 || korzen == null) throw new InvalidOperationException("Kopiec pusty");

            int wynik = korzen.value;

            if (liczbaEle == 1)
            {
                korzen = null;
                liczbaEle = 0;
                return wynik;
            }

            Wezel ostatni = ZnajdzWezelPoIndeksie(liczbaEle);
            if (ostatni == null) throw new InvalidOperationException("Brak ostatniego wezla (blad)");

            korzen.value = ostatni.value;

            if (ostatni.rodzic.dzieckoL == ostatni) ostatni.rodzic.dzieckoL = null;
            else if (ostatni.rodzic.dzieckoP == ostatni) ostatni.rodzic.dzieckoP = null;

            liczbaEle -= 1;

            PrzywrocWlasnoscWdol(korzen);

            return wynik;
        }

        public void SortujDoTablicy(int[] tab)
        {
            if (tab == null) throw new ArgumentNullException(nameof(tab));
            int n = tab.Length;
            for (int i = 0; i < n; i++)
            {
                tab[i] = UsunKorzen();
            }
        }
    }
}
