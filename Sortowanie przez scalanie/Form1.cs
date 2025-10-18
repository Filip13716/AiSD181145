namespace Sortowanie_przez_scalanie
{
    public partial class Form1 : Form
    {
        int[] tab = new int[10];

        void Sc(int[] tab, int a, int b)
        {
            if (a < b)
            {
                int s=(a+b)/2;
                Sc(tab, a, s);
                Sc(tab, s + 1, b);
                Scal(tab, a, s, b);
            }
        }

        private void Scal(int[] tab, int a, int s, int b)
        {
            List<int> temp1 = new List<int>();
            List<int> temp2 = new List<int>();

            for (int l = a; l < s+1; l++) temp1.Add(tab[l]);
            for (int l = s+1; l<= b;  l++) temp2.Add(tab[l]);

            int i = 0;
            int j = 0;
            int k = a;

            while (i < temp1.Count && j < temp2.Count)
            {
                if (temp1[i] <= temp2[j])
                {
                    tab[k] = temp1[i];
                    i++;
                }
                else
                {
                    tab[k] = temp2[j];
                    j++;
                }
                k++;
            }

            while (i < temp1.Count)
            {
                tab[k] = temp1[i];
                i++;
                k++;
            }

            while (j < temp2.Count)
            {
                tab[k] = temp2[j];
                j++;
                k++;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_random_Click(object sender, EventArgs e)
        {
            lb_after.Text = "";

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                tab[i] = random.Next(0, 100);
            }

            lb_nums.Text = "Lista przed posortowaniem: " + String.Join(", ", tab);
            lb_nums.Visible = true;
            bt_sort.Visible = true;
        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            Sc(tab, 0, tab.Length - 1);
            lb_after.Text = "Tablica po sortowaniu: " + String.Join(", ", tab);
            lb_after.Visible = true;
        }
    }
}
