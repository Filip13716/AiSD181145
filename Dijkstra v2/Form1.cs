using Dikstra_v2;

namespace Dijkstra_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            Graph g = new Graph();

            g.Add(0, 1, 3);
            g.Add(1, 2, 1);
            g.Add(3, 1, 3);
            g.Add(2, 3, 3);
            g.Add(2, 5, 1);
            g.Add(5, 3, 1);
            g.Add(5, 0, 6);
            g.Add(0, 4, 3);
            g.Add(4, 5, 2);

            UDP[] tabelka = new UDP[6];

            for (int i = 0; i < tabelka.Length; i++)
            {
                tabelka[i] = new UDP(i);
            }

            List<int> S = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                int a = tabelka.Where(udp => !S.Contains(udp.u)).OrderBy(e => e.d).First().u;

                foreach (Edge edge in g.edges.Where(e => !S.Contains(e.ending.value)).Where(e => e.begining.value == a))
                {
                    float waga = tabelka[a].d + edge.weight;

                    if(waga < tabelka[edge.ending.value].d)
                    {
                        tabelka[edge.ending.value].d = waga;
                        tabelka[edge.ending.value].p = a;
                    }
                }

                S.Add(a);
            }

            dataGridView1.DataSource = tabelka;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
