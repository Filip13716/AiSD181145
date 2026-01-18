using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Kruskala
{
    internal class Edge
    {
        public Node begining, ending;
        public int weight;

        public Edge(Node begining, Node ending, int weight)
        {
            this.begining = begining;
            this.ending = ending;
            this.weight = weight;
        }
        public Edge(Node begining, Node ending)
        {
            this.begining = begining;
            this.ending = ending;
            weight = 1;
        }

        public Edge(int begining, int ending, int weight)
        {
            this.begining = new Node(begining);
            this.ending = new Node(ending);
            this.weight = weight;
        }
    }
}
