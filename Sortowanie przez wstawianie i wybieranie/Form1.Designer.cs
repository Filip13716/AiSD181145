namespace Sortowanie_przez_wstawianie_i_wybieranie
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
            lb_random = new Label();
            lb_wst = new Label();
            lb_wyb = new Label();
            bt_rand = new Button();
            bt_wst = new Button();
            bt_wyb = new Button();
            SuspendLayout();
            // 
            // lb_random
            // 
            lb_random.AutoSize = true;
            lb_random.Location = new Point(157, 99);
            lb_random.Name = "lb_random";
            lb_random.Size = new Size(50, 20);
            lb_random.TabIndex = 0;
            lb_random.Text = "label1";
            lb_random.Visible = false;
            // 
            // lb_wst
            // 
            lb_wst.AutoSize = true;
            lb_wst.Location = new Point(157, 140);
            lb_wst.Name = "lb_wst";
            lb_wst.Size = new Size(50, 20);
            lb_wst.TabIndex = 1;
            lb_wst.Text = "label2";
            lb_wst.Visible = false;
            // 
            // lb_wyb
            // 
            lb_wyb.AutoSize = true;
            lb_wyb.Location = new Point(157, 188);
            lb_wyb.Name = "lb_wyb";
            lb_wyb.Size = new Size(50, 20);
            lb_wyb.TabIndex = 2;
            lb_wyb.Text = "label3";
            lb_wyb.Visible = false;
            // 
            // bt_rand
            // 
            bt_rand.Location = new Point(695, 289);
            bt_rand.Margin = new Padding(3, 4, 3, 4);
            bt_rand.Name = "bt_rand";
            bt_rand.Size = new Size(163, 52);
            bt_rand.TabIndex = 3;
            bt_rand.Text = "Losuj listę";
            bt_rand.UseVisualStyleBackColor = true;
            bt_rand.Click += bt_rand_Click;
            // 
            // bt_wst
            // 
            bt_wst.Location = new Point(695, 365);
            bt_wst.Margin = new Padding(3, 4, 3, 4);
            bt_wst.Name = "bt_wst";
            bt_wst.Size = new Size(163, 59);
            bt_wst.TabIndex = 4;
            bt_wst.Text = "Sortowanie przez wstawianie";
            bt_wst.UseVisualStyleBackColor = true;
            bt_wst.Visible = false;
            bt_wst.Click += bt_wst_Click;
            // 
            // bt_wyb
            // 
            bt_wyb.Location = new Point(695, 445);
            bt_wyb.Margin = new Padding(3, 4, 3, 4);
            bt_wyb.Name = "bt_wyb";
            bt_wyb.Size = new Size(163, 59);
            bt_wyb.TabIndex = 5;
            bt_wyb.Text = "Sortowanie przez wybieranie";
            bt_wyb.UseVisualStyleBackColor = true;
            bt_wyb.Visible = false;
            bt_wyb.Click += bt_wyb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(bt_wyb);
            Controls.Add(bt_wst);
            Controls.Add(bt_rand);
            Controls.Add(lb_wyb);
            Controls.Add(lb_wst);
            Controls.Add(lb_random);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_random;
        private Label lb_wst;
        private Label lb_wyb;
        private Button bt_rand;
        private Button bt_wst;
        private Button bt_wyb;
    }
}
