using Binarne_drzewo_poszukiwañ;

namespace Obracanie_drzewa
{
    public partial class Form1 : Form
    {
        Drzewo tree = new Drzewo();
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int value = int.Parse(input.Text);

            tree.Dodaj(value);

            input.Text = "";

            LoadToTreeView(treeview);
        }

        private void AddChildren(Wêze³ wêze³, TreeNode node)
        {
            if (wêze³.dzieckoLewe != null)
            {
                TreeNode leftNode = new TreeNode(wêze³.dzieckoLewe.value.ToString());
                node.Nodes.Add(leftNode);
                AddChildren(wêze³.dzieckoLewe, leftNode);
            }

            if (wêze³.dzieckoPrawe != null)
            {
                TreeNode rightNode = new TreeNode(wêze³.dzieckoPrawe.value.ToString());
                node.Nodes.Add(rightNode);
                AddChildren(wêze³.dzieckoPrawe, rightNode);
            }
        }


        public void LoadToTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();

            if (tree.root == null)
                return;

            TreeNode rootNode = new TreeNode(tree.root.value.ToString());
            treeView.Nodes.Add(rootNode);

            AddChildren(tree.root, rootNode);

            treeView.ExpandAll();
        }


        private void bt_search_Click(object sender, EventArgs e)
        {
            int value = int.Parse(input.Text);

            Wêze³ x = tree.Search(value);

            List<Wêze³> brench = x.Parentage();

            while (brench.Count > 1)
            {
                Wêze³ a = brench[brench.Count - 1];
                Wêze³ b = brench[brench.Count - 2];

                if(b == a.dzieckoLewe)
                {
                    tree.obrotPrawo(b);
                }
                if(b == a.dzieckoPrawe)
                {
                    tree.obrotLewo(b);
                }

                brench.RemoveAt(brench.Count - 1);
            }

            LoadToTreeView(treeview);
        }
    }
}
