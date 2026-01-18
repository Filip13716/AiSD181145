using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Kruskala
{
    internal class Graph
    {
        public List<Edge> edges;
        public List<Node> nodes;

        public Graph(Edge edge)
        {
            edges = new List<Edge>() { edge };
            nodes = new List<Node>();
        }

        public int Check(Edge edge)
        {
            int i = 2;

            if (nodes.Contains(edge.begining)) i--;
            if (nodes.Contains(edge.ending)) i--;

            return i;
        }

        public void Add(Edge edge)
        {
            edges.Add(edge);

            if(!nodes.Contains(edge.begining)) nodes.Add(edge.begining);
            if(!nodes.Contains(edge.ending)) nodes.Add(edge.ending);
        }

        public void Join(Graph graph)
        {
            foreach(Node node in graph.nodes) if(!this.nodes.Contains(node)) this.nodes.Add(node);
            foreach(Edge edge in graph.edges) this.edges.Add(edge);
        }
    }
}
