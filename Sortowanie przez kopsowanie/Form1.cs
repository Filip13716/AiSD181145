namespace Sortowanie_przez_kopsowanie
{
    public partial class Form1 : Form
    {
        int[] tab = new int[10];
        Drzewo tree = new Drzewo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                tab[i] = random.Next(1, 100);
            }

            lb_nums.Text = "Lista przed sortowaniem: " + String.Join(", ", tab);
            lb_nums.Visible = true;
            bt_sort.Visible = true;
        }

        private void bt_sort_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tree.Dodaj(tab[i]);
            }

            int[] sortedDesc = new int[tab.Length];
            tree.SortujDoTablicy(sortedDesc);

            Array.Reverse(sortedDesc);
            lb_after.Text = "Tablica po sortowaniu: " + String.Join(", ", sortedDesc);

            lb_after.Visible = true;
        }
    }
}
