namespace Binarne_drzewo_poszukiwań
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

            for (int i = 0; i < 10; i++) tab[i] = random.Next(0, 1000);

            lb_random.Text = "Wylosowana lista: " + String.Join(", ", tab);
            lb_random.Visible = true;

            lb_after.Text = "";

            bt_sort.Visible = true;
        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            Drzewo tree = new Drzewo();

            for(int i = 0; i < 10; i++) tree.Dodaj(tab[i]);

            for (int i = 0; i < 10; i++) tab[i] = tree.TakeElement();

            lb_after.Text = "Lista po sortowaniu: " + String.Join(", ", tab);
            lb_after.Visible = true;
        }
    }
}
