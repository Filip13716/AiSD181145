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

            if(tail == null)
            {
                tail = nowy;
                head = nowy;
            }

            else
            {
                tail.next = nowy;
                nowy.prev = tail;
                tail = nowy;
            }

            LiczbaElementow++;
        }

        public void Dodaj(int value, Element e)
        {
            Element nowy = new Element(value);

            nowy.prev = e.prev;
            nowy.next = e;

            if (e.prev != null)
            {
                e.prev.next = nowy;
            }
            else
            {
                this.head = nowy;
            }

            e.prev = nowy;

            LiczbaElementow++;
        }
    }
}
