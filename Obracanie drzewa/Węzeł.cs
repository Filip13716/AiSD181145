using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarne_drzewo_poszukiwań
{
    internal class Węzeł
    {
        public int value;
        public Węzeł rodzic, dzieckoPrawe, dzieckoLewe;

        public Węzeł(int n, Węzeł rodzic)
        {
            value = n;
            this.rodzic = rodzic;

            if (rodzic.value > n) rodzic.dzieckoLewe = this;
            else rodzic.dzieckoPrawe = this;
        }
        public Węzeł(int n)
        {
            value = n;
        }

        public override string ToString()
        {
            return "["+this.value+"]";
        }

        public List<Węzeł> Parentage()
        {
            List<Węzeł> list = new List<Węzeł>();

            Węzeł ptr = this;

            while (ptr != null)
            {
                list.Add(ptr);
                ptr = ptr.rodzic;
            }

            return list;
        }
    }
}
