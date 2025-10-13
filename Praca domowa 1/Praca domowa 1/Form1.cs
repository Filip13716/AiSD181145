using System.Threading.Channels;

namespace Praca_domowa_1
{
    public partial class Form1 : Form
    {
        int[] tab = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool changed = true;

            while (changed)
            {
                changed = false;

                for (int j = 0; j < 9; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j + 1];
                        tab[j + 1] = tab[j];
                        tab[j] = temp;
                        changed = true;
                    }
                }
            }

            lb_after.Text = String.Join(", ", tab);
            lb_after.Visible = true;
        }

        private void bt_random_Click(object sender, EventArgs e)
        {
            lb_after.Text = "";

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                tab[i] = random.Next(0, 100);
            }

            lb_nums.Text = "Tablica przed sortowaniem: " + String.Join(", ", tab);
            lb_nums.Visible= true;

            bt_sort.Visible = true;
        }
    }
}
