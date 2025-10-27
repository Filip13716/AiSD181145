namespace Listy_dwókierunkowe
{
    public partial class Form1 : Form
    {
        Lista tab = new Lista();

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lb_dodaj_Click(object sender, EventArgs e)
        {
            if (rad_dod_norm.Checked)
            {
                tab.Dodaj(int.Parse(text_input.Text));
            }
            if (rad_dod_aft.Checked)
            {
                tab.DodajPo();
            }
        }

        private void rad_dod_aft_CheckedChanged(object sender, EventArgs e)
        {
            combo_elem.Visible = true;

            combo_elem.Items.AddRange(tab);
        }
    }
}
