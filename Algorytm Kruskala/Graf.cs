using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Kruskala
{
    internal class Graf
    {
        public List<Wezel> nodes;
        public List<Krawedz> krawedzs;

        public Graf(Krawedz k)
        {
            krawedzs = new List<Krawedz>() { k };

            nodes = new List<Wezel>(){ k.poczatek, k.koniec};
        }

        public void Add(Krawedz k)
        {
            krawedzs.Add(k);

            if(!nodes.Contains(k.poczatek)) nodes.Add(k.poczatek);
            if(!nodes.Contains(k.koniec)) nodes.Add(k.koniec);
        }

        public void Join(Graf g)
        {
            this.krawedzs.AddRange(g.krawedzs);

            foreach(Wezel w in g.nodes)
            {
                if(!this.nodes.Contains(w)) this.nodes.Add(w);
            }
        }

        public int Chceck(Krawedz k)
        {
            int v = 2;

            if (nodes.Contains(k.poczatek)) v--;
            if (nodes.Contains(k.koniec)) v--;

            return v;
        }
    }
}
