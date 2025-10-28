using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy_dwókierunkowe
{
    internal class Lista
    {
        public int LiczbaElementow;
        public Element head;
        public Element tail;

        public void DodajPo(Element e, int n)
        {
            Element nowy = new Element(n);
            Element temp = e.next;

            nowy.prev = e;
            nowy.next = temp;

            if (temp != null)
                temp.prev = nowy;

            e.next = nowy;

            if (e == tail)
                tail = nowy;

            LiczbaElementow++;
        }

        public void DodajPrzed(Element e, int n)
        {
            Element nowy = new Element(n);
            Element temp = e.prev;

            nowy.next = e;
            nowy.prev = temp;

            e.prev = nowy;

            if (temp != null)
                temp.next = nowy;

            if (e == head)
                head = nowy;

            LiczbaElementow++;
        }


        public void Dodaj(int n)
        {
            if (this.head == null)
            {
                this.head = new Element(n);
                this.tail = head;
                LiczbaElementow++;
            }
            else
            {
                DodajPo(this.tail, n);
            }
        }


        public int[] ToList()
        {
            int[] tab = new int[this.LiczbaElementow];

            Element ptr = this.head;

            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = ptr.value;
                ptr = ptr.next;
            }

            return tab;
        }
    }
}
