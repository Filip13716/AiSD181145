using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_przez_wstawianie_i_wybieranie
{
    internal class Lista
    {
        public Element head;
        public Element tail;
        public int LiczbaElementow;

        public String Show()
        {
            int[] tab = new int[this.LiczbaElementow];

            Element temp = this.head;

            for(int i = 0;  temp != null; temp = temp.next, i++)
            {
                tab[i] = temp.value;
            }

            return String.Join(", ", tab);
        }

        public void Dodaj(int value)
        {
            Element nowy = new Element(value);

            tail.Dodaj(nowy);

            this.tail = nowy;
        }

        public void Dodaj(int value,  Element nowy) { }
    }
}
