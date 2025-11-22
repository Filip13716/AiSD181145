namespace Sortowanie_przez_zliczanie
{
    public partial class Form1 : Form
    {
        int[] tab = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_random_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                tab[i] = random.Next(-1000, 1000);
            }

            lb_random.Text = "Wylosowana lista: " + String.Join(", ", tab);
            lb_random.Visible = true;
            lb_after.Text = "";

            bt_sort.Visible = true;
        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            int min = tab.Min();

            int[] pt = new int[tab.Max() - min + 1];

            for (int i = 0; i < tab.Length; i++) pt[tab[i] - min] += 1;

            List<int> lista = new List<int>();

            for(int i = 0; i < pt.Length; i++)
            {
                if (pt[i] > 0) for (int j = pt[i]; j > 0; j--) lista.Add(i + min);
            }

            lb_after.Text = "Liczby po sortowaniu: " + String.Join(", ", lista);
            lb_after.Visible = true;
        }
    }
}
