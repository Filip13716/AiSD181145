using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy_dwukierunkowe
{
    internal class Node
    {
        public int value;
        public Node prev, next;

        public Node(int value)
        {
            this.value = value;
        }

        public Node(int value, Node prev)
        {
            this.value = value;
            this.prev = prev;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
