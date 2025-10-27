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
        Element head;
        Element tail;

        public void DodajPo(Element e, int n)
        {
            Element temp = e.next;
            Element nowy = new Element(n);
            e.next = nowy;
            nowy.next = temp;

            if (e == tail) tail = nowy;
            LiczbaElementow++;
        }
        public void DodajPrzed(Element e, int n)
        {
            Element temp = e.prev;
            Element nowy = new Element(n);
            e.prev = nowy;
            nowy.prev = temp;

            if(e == head) head = nowy;
            LiczbaElementow++;
        }
        public void Dodaj(int n)
        {
            if(this.head == null)
            {
                this.head = new Element(n);
                this.tail = head;
            }
            else
            {
                DodajPo(this.tail, n);
            }
            LiczbaElementow++;
        }
    }
}
