using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dijkstra_v2
{
    internal class Edge
    {
        public Node begining { get; set; }
        public Node ending { get; set; }
        public int weight { get; set; }

        public Edge(int begining, int ending, int weight)
        {
            this.begining = new Node(begining);
            this.ending = new Node(ending);
            this.weight = weight;
        }
    }
}
