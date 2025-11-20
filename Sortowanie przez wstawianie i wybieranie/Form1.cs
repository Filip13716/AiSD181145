namespace Sortowanie_przez_wstawianie_i_wybieranie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] tab = new int[10];

        private void bt_rand_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {
                tab[i] = rd.Next(1, 1000);
            }

            lb_random.Text = "Lista przed sortowaniem: " + String.Join(", ", tab);
            lb_random.Visible = true;

            lb_wst.Text = "";
            lb_wyb.Text = "";

            bt_wst.Visible = true;
            bt_wyb.Visible = true;
        }

        private void bt_wst_Click(object sender, EventArgs e)
        {
            Lista list = new Lista();

            if (tab.Length > 0)
                list.Dodaj(tab[0]);

            for (int i = 1; i < tab.Length; i++)
            {
                Element temp = list.head;
                bool ch = false;

                while (temp != null)
                {
                    if (tab[i] <= temp.value)
                    {
                        list.Dodaj(tab[i], temp);

                        ch = true;
                        break;
                    }

                    temp = temp.next;
                }

                if (!ch)
                {
                    list.Dodaj(tab[i]);
                }
            }

            lb_wst.Text = "Lista po sortowaniu: " + list.Show();
            lb_wst.Visible = true;
        }

        private void bt_wyb_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                int minInd = minIndex(i);
                int temp = tab[i];

                tab[i] = tab[minInd];
                tab[minInd] = temp;
            }

            lb_wyb.Text = "Tablica po sortowaniu pezez wybieranie: " + String.Join(", ", tab);
            lb_wyb.Visible = true;
        }

        private int minIndex(int i)
        {
            int min = i;

            for(int j = i+1; j < tab.Length; j++)
            {
                if (tab[j] < tab[min]) min = j;
            }

            return min;
        }
    }
}
