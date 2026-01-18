using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Dijkstra_v2
{
    internal class Graph
    {
        public List<Edge> edges;

        public void Add(int b, int e, int w)
        {
            if (edges == null) edges = new List<Edge>() { new Edge(b, e, w) };
            else edges.Add(new Edge(b, e, w));
        }
    }
}
