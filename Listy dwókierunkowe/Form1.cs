namespace Listy_dwókierunkowe
{
    public partial class Form1 : Form
    {
        Lista tab = new Lista();

        void ComboReset()
        {
            Element ptr = tab.head;
            List<Slownik> list = new List<Slownik>();

            while (ptr != null)
            {
                list.Add(new Slownik(ptr, ptr.value));

                ptr = ptr.next;
            }

            combo_elem.DataSource = list;
            combo_elem.DisplayMember = "value";
            combo_elem.ValueMember = "n";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void lb_dodaj_Click(object sender, EventArgs e)
        {
            if (rad_dod_norm.Checked)
            {
                tab.Dodaj(int.Parse(text_input.Text));
            }
            if (rad_dod_aft.Checked)
            {
                Slownik wybrany = (Slownik)combo_elem.SelectedItem;

                tab.DodajPo(wybrany.n, int.Parse(text_input.Text));
                ComboReset();
            }
            if (rad_dod_bef.Checked)
            {
                Slownik wybrany = (Slownik)(combo_elem.SelectedItem);

                tab.DodajPrzed(wybrany.n, int.Parse(text_input.Text));
                ComboReset();
            }

            if(tab.LiczbaElementow == 1)
            {
                rad_dod_norm.Visible = true;
                rad_dod_bef.Visible = true;
                rad_dod_aft.Visible = true;
            }

            int[] list = tab.ToList();

            lb_pokaz.Text = "Lista : " + String.Join(", ", list);
            lb_pokaz.Visible = true;

            text_input.Text = "";
        }

        private void rad_dod_aft_CheckedChanged(object sender, EventArgs e)
        {
            combo_elem.Visible = true;

            ComboReset();
        }

        private void rad_dod_norm_CheckedChanged(object sender, EventArgs e)
        {
            combo_elem.Visible = false;
        }
    }
}
