namespace QuickSort
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
                tab[i] = random.Next(1, 1001);
            }

            lb_random.Text = "Wylosowana lista: " + String.Join(", ", tab);
            lb_random.Visible = true;

            lb_after.Text = "";

            bt_sort.Enabled = true;
        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            QuickS(0, 9);

            lb_after.Text = "Lista po sortowaniu: " + String.Join(", ", tab);
            lb_after.Visible = true;
        }

        private void QuickS(int x, int y)
        {
            int pivot = tab[(x + y) / 2];

            int i = x, j = y;

            while (i <= j)
            {
                while (tab[i] < pivot) i++;
                while (tab[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;

                    i++;
                    j--;
                }
            }

            if (x < j)
            {
                QuickS(x, j);
            }

            if (i < y)
            {
                QuickS(i, y);
            }
        }
    }
}
