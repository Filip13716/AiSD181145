using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarne_drzewo_poszukiwań
{
    internal class Drzewo
    {
        Węzeł root;

        public void Dodaj(int n)
        {
            if (root == null)
            {
                root = new Węzeł(n);
                return;
            }

            Węzeł temp = root;

            while (true)
            {
                if (n < temp.value)
                {
                    if (temp.dzieckoLewe == null)
                    {
                        temp.dzieckoLewe = new Węzeł(n, temp);
                        return;
                    }
                    temp = temp.dzieckoLewe;
                }
                else
                {
                    if (temp.dzieckoPrawe == null)
                    {
                        temp.dzieckoPrawe = new Węzeł(n, temp);
                        return;
                    }
                    temp = temp.dzieckoPrawe;
                }
            }
        }

        public int TakeElement()
        {
            if (root == null)
                throw new InvalidOperationException("Tree is empty");

            Węzeł temp = root;

            while (temp.dzieckoLewe != null)
                temp = temp.dzieckoLewe;

            int value = temp.value;


            if (temp.dzieckoPrawe == null)
            {
                if (temp.rodzic == null)
                {
                    root = null;
                }
                else if (temp.rodzic.dzieckoLewe == temp)
                    temp.rodzic.dzieckoLewe = null;
                else
                    temp.rodzic.dzieckoPrawe = null;
            }
            else
            {
                if (temp.rodzic == null)
                {
                    root = temp.dzieckoPrawe;
                    root.rodzic = null;
                }
                else if (temp.rodzic.dzieckoLewe == temp)
                {
                    temp.rodzic.dzieckoLewe = temp.dzieckoPrawe;
                    temp.dzieckoPrawe.rodzic = temp.rodzic;
                }
                else
                {
                    temp.rodzic.dzieckoPrawe = temp.dzieckoPrawe;
                    temp.dzieckoPrawe.rodzic = temp.rodzic;
                }
            }

            return value;
        }
    }
}
