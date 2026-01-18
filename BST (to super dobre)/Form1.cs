using BST;

namespace Kolo
{
    public partial class Form1 : Form
    {
        BST.Tree tree = new BST.Tree();
        BST.Visualization visualization;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            visualization = new BST.Visualization(tree, pictureBox1);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_input.Text);

            tree.Dodaj(value);
            pictureBox1.Refresh();
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_input.Text);

            tree.Usun(value);
            pictureBox1.Refresh();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_input.Text);

            Node x = tree.Search(value);

            List<Node> nodes = x.Parentage();

            while (nodes.Count > 0)
            {
                if (nodes.First().left == x) tree.Zig(x, x.parent);
                else tree.Zag(x, x.parent);

                nodes.RemoveAt(0);
            }

            pictureBox1.Refresh();
        }

        private void bt_pre_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            preorder(tree.root, list);

            lb_out.Text = String.Join(", ", list);
        }

        private void preorder(Node node, List<int> list)
        {
            list.Add(node.value);

            if (node.left != null) preorder(node.left, list);
            if (node.right != null) preorder(node.right, list);
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            inorder(tree.root, list);

            lb_out.Text = String.Join(", ", list);
        }

        private void inorder(Node node, List<int> list)
        {
            if (node.left != null) inorder(node.left, list);
            list.Add(node.value);
            if (node.right != null) inorder(node.right, list);
        }

        private void bt_pos_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            postorder(tree.root, list);

            lb_out.Text = String.Join(", ", list);
        }

        private void postorder(Node node, List<int> list)
        {
            if (node.left != null) postorder(node.left, list);
            if (node.right != null) postorder(node.right, list);
            list.Add(node.value);
        }

        private void bt_wid_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            Width(list);

            lb_out.Text=String.Join(", ", list);
        }

        private int GetHeight(Node node)
        {
            if (node == null) return 0;

            return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
        }

        private void PrintCurrentLevel(Node node, int level, List<int> list)
        {
            if (node == null) return;

            if (level == 1) list.Add(node.value);

            else if(level > 1)
            {
                PrintCurrentLevel(node.left, level - 1, list);
                PrintCurrentLevel(node.right, level - 1, list);
            }
        }

        private void Width(List<int> list)
        {
            int h = GetHeight(tree.root);

            for(int i = 1; i<=h; i++)
            {
                PrintCurrentLevel(tree.root, i, list);
            }
        }
    }
}
