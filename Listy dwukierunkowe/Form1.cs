namespace Listy_dwukierunkowe
{
    public partial class Form1 : Form
    {
        Lista list = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            lb_list.Text = String.Join(", ", list.ToList());

            List<Node> nodes = list.GetNodes();

            comboBox1.DataSource = nodes;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);

            list.Add(value);
            Refresh();
        }

        private void bt_before_Click(object sender, EventArgs e)
        {
            Node node = (Node)comboBox1.SelectedItem;
            int value = int.Parse(textBox1.Text);

            list.AddPrev(node, value);
            Refresh();
        }

        private void bt_after_Click(object sender, EventArgs e)
        {
            Node node = (Node)comboBox1.SelectedItem;
            int value = int.Parse(textBox1.Text);

            list.AddAfter(node, value);
            Refresh();
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            Node node = (Node)comboBox1.SelectedItem;

            list.Delete(node);
            Refresh();
        }
    }
}
