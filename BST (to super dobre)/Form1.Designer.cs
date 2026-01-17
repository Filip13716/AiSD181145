namespace Kolo
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
            pictureBox1 = new PictureBox();
            text_input = new TextBox();
            bt_add = new Button();
            bt_remove = new Button();
            bt_search = new Button();
            lb_out = new Label();
            bt_pre = new Button();
            bt_in = new Button();
            bt_pos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 506);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // text_input
            // 
            text_input.Location = new Point(777, 26);
            text_input.Name = "text_input";
            text_input.Size = new Size(125, 27);
            text_input.TabIndex = 1;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(794, 73);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(94, 29);
            bt_add.TabIndex = 2;
            bt_add.Text = "Dodaj";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_remove
            // 
            bt_remove.Location = new Point(794, 118);
            bt_remove.Name = "bt_remove";
            bt_remove.Size = new Size(94, 29);
            bt_remove.TabIndex = 3;
            bt_remove.Text = "Usuń";
            bt_remove.UseVisualStyleBackColor = true;
            bt_remove.Click += bt_remove_Click;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(794, 162);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(94, 29);
            bt_search.TabIndex = 4;
            bt_search.Text = "Szukaj";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // lb_out
            // 
            lb_out.AutoSize = true;
            lb_out.Location = new Point(14, 551);
            lb_out.Name = "lb_out";
            lb_out.Size = new Size(50, 20);
            lb_out.TabIndex = 5;
            lb_out.Text = "label1";
            // 
            // bt_pre
            // 
            bt_pre.Location = new Point(794, 451);
            bt_pre.Name = "bt_pre";
            bt_pre.Size = new Size(94, 29);
            bt_pre.TabIndex = 6;
            bt_pre.Text = "Pre-order";
            bt_pre.UseVisualStyleBackColor = true;
            bt_pre.Click += bt_pre_Click;
            // 
            // bt_in
            // 
            bt_in.Location = new Point(794, 486);
            bt_in.Name = "bt_in";
            bt_in.Size = new Size(94, 29);
            bt_in.TabIndex = 7;
            bt_in.Text = "In-order";
            bt_in.UseVisualStyleBackColor = true;
            bt_in.Click += bt_in_Click;
            // 
            // bt_pos
            // 
            bt_pos.Location = new Point(794, 521);
            bt_pos.Name = "bt_pos";
            bt_pos.Size = new Size(94, 29);
            bt_pos.TabIndex = 8;
            bt_pos.Text = "Post-order";
            bt_pos.UseVisualStyleBackColor = true;
            bt_pos.Click += bt_pos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(bt_pos);
            Controls.Add(bt_in);
            Controls.Add(bt_pre);
            Controls.Add(lb_out);
            Controls.Add(bt_search);
            Controls.Add(bt_remove);
            Controls.Add(bt_add);
            Controls.Add(text_input);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox text_input;
        private Button bt_add;
        private Button bt_remove;
        private Button bt_search;
        private Label lb_out;
        private Button bt_pre;
        private Button bt_in;
        private Button bt_pos;
    }
}
