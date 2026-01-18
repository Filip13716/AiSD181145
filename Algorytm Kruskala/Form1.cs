using System.Windows.Forms.VisualStyles;

namespace Algorytm_Kruskala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            List<Edge> edges =new List<Edge>();

            edges.Add(new Edge(4, 6, 1));
            edges.Add(new Edge(4, 5, 2));
            edges.Add(new Edge(2, 7, 3));
            edges.Add(new Edge(0, 6, 3));
            edges.Add(new Edge(2, 4, 4));
            edges.Add(new Edge(0, 1, 5));
            edges.Add(new Edge(2, 6, 5));
            edges.Add(new Edge(1, 5, 6));
            edges.Add(new Edge(5, 6, 6));
            edges.Add(new Edge(1, 7, 7));
            edges.Add(new Edge(1, 4, 8));
            edges.Add(new Edge(3, 6, 8));
            edges.Add(new Edge(0, 3, 9));
            edges.Add(new Edge(1, 2, 9));
            edges.Add(new Edge(2, 3, 9));
            edges.Add(new Edge(6, 7, 9));

            edges = edges.OrderBy(edge => edge.weight).ToList();

            List<Edge> T = new List<Edge>();
            List<Graph> graphs = new List<Graph>();

            while (T.Count < 7 && edges.Count > 0)
            {
                Edge edge = edges.First();
                edges.RemoveAt(0);

                Graph graphA = graphs.FirstOrDefault(g => g.nodes.Contains(edge.begining));
                Graph graphB = graphs.FirstOrDefault(g => g.nodes.Contains(edge.ending));

                if (graphA == null && graphB == null)
                {
                    // Oba wierzcho³ki s¹ nowe
                    graphs.Add(new Graph(edge));
                    T.Add(edge);
                }
                else if (graphA != null && graphB == null)
                {
                    // Pocz¹tek jest w grafie A, koniec jest nowy
                    graphA.Add(edge);
                    T.Add(edge);
                }
                else if (graphA == null && graphB != null)
                {
                    // Koniec jest w grafie B, pocz¹tek jest nowy
                    graphB.Add(edge);
                    T.Add(edge);
                }
                else if (graphA != graphB)
                {
                    // Wierzcho³ki s¹ w ró¿nych grafach -> ³¹czymy je
                    graphA.Join(graphB);
                    graphA.Add(edge);
                    graphs.Remove(graphB);
                    T.Add(edge);
                }
            }

            foreach (Edge edge in T)
            {
                ListViewItem item = new ListViewItem(edge.begining.value+" - "+edge.ending.value+" : "+edge.weight);

                listView1.Items.Add(item);
            }
        }
    }
}
