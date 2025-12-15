namespace Obracanie_drzewa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeview = new TreeView();
            label1 = new Label();
            bt_add = new Button();
            bt_search = new Button();
            input = new TextBox();
            SuspendLayout();
            // 
            // treeview
            // 
            treeview.Location = new Point(33, 104);
            treeview.Name = "treeview";
            treeview.Size = new Size(333, 237);
            treeview.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 1;
            label1.Text = "Obracanie drzewa";
            // 
            // bt_add
            // 
            bt_add.Location = new Point(643, 149);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(92, 60);
            bt_add.TabIndex = 2;
            bt_add.Text = "Dodaj wartość do drzewa";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(643, 250);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(92, 33);
            bt_search.TabIndex = 3;
            bt_search.Text = "Szukaj";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // input
            // 
            input.Location = new Point(481, 215);
            input.Name = "input";
            input.Size = new Size(100, 23);
            input.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(input);
            Controls.Add(bt_search);
            Controls.Add(bt_add);
            Controls.Add(label1);
            Controls.Add(treeview);
            Name = "Form1";
            Text = "Obracanie drzewa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeview;
        private Label label1;
        private Button bt_add;
        private Button bt_search;
        private TextBox input;
    }
}
