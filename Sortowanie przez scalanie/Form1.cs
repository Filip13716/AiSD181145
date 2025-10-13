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
        }
    }
}
