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

            bt_wst.Visible = true;
        }

        private void bt_wst_Click(object sender, EventArgs e)
        {
            Lista list = new Lista();

            list.Dodaj(tab[0]);

            for(int i = 1; i < tab.Length; i++)
            {
                Element temp = list.tail;

                while (temp != null)
                {
                    if(temp.next.value <= tab[i] || temp.next == null)
                    {
                        list.Dodaj(tab[i], temp.next);
                    }

                    temp = temp.next;
                }
            }

            lb_wst.Text = "Lista po sortowaniu przez wstawianie: " + list.Show();
            lb_wst.Visible = true;
        }
    }
}
