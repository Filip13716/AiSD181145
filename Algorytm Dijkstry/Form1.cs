namespace Algorytm_Dijkstry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graf g = new Graf(new List<Krawedz> {
                new Krawedz(0, 4, 3),
                new Krawedz(0, 1, 3),
                new Krawedz(4, 5, 2),
                new Krawedz(1, 2, 1),
                new Krawedz(5, 0, 6),
                new Krawedz(2, 3, 3),
                new Krawedz(2, 5, 1),
                new Krawedz(3, 1, 3),
                new Krawedz(5, 3, 1)}
            );

            Udp[] tabelka = new Udp[6];
            for (int i = 0; i < tabelka.Length; i++) tabelka[i] = new Udp(i);
            tabelka[0].d = 0;

            List<int> s = new List<int>();

            for (int i = 0; i < tabelka.Length; i++)
            {
                int a = tabelka.Where(udp => !s.Contains(udp.u)).OrderBy(e => e.d).First().u;

                foreach (Krawedz k in g.krawedzs.Where(e => !s.Contains(e.koniec)).Where(e => e.start == a))
                {
                    int waga = tabelka[a].d + k.waga;

                    if (tabelka[k.koniec].d > waga) tabelka[k.koniec].Set(waga, a);
                }

                s.Add(a);
            }

            dataGridView1.DataSource = tabelka;
            bt_start.Visible = false;
        }
    }
}
