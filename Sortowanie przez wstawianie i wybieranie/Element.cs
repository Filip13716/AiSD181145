using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_przez_wstawianie_i_wybieranie
{
    internal class Element
    {
        public int value;
        public Element next;
        public Element prev;

        public Element(int value)
        {
            this.value = value;
        }

        public void Dodaj(Element nowy)
        {
            Element next = this.next;

            this.next = nowy;

            nowy.prev = this;
            nowy.next = next;
        }
    }
}
