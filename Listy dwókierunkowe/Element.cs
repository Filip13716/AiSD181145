using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy_dwókierunkowe
{
    internal class Element
    {
        public int value;
        public Element next;
        public Element prev;

        public Element(int n) {  value = n; }
    }
}
