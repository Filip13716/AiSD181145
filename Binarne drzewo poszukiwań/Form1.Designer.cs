namespace Binarne_drzewo_poszukiwań
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
            label1 = new Label();
            lb_random = new Label();
            lb_after = new Label();
            bt_random = new Button();
            bt_sort = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(238, 18);
            label1.Name = "label1";
            label1.Size = new Size(280, 30);
            label1.TabIndex = 0;
            label1.Text = "Binarne drzewo poszukiwań";
            // 
            // lb_random
            // 
            lb_random.AutoSize = true;
            lb_random.Location = new Point(32, 85);
            lb_random.Name = "lb_random";
            lb_random.Size = new Size(38, 15);
            lb_random.TabIndex = 1;
            lb_random.Text = "label2";
            lb_random.Visible = false;
            // 
            // lb_after
            // 
            lb_after.AutoSize = true;
            lb_after.Location = new Point(32, 121);
            lb_after.Name = "lb_after";
            lb_after.Size = new Size(38, 15);
            lb_after.TabIndex = 2;
            lb_after.Text = "label3";
            lb_after.Visible = false;
            // 
            // bt_random
            // 
            bt_random.Location = new Point(649, 298);
            bt_random.Name = "bt_random";
            bt_random.Size = new Size(107, 52);
            bt_random.TabIndex = 3;
            bt_random.Text = "Losuj";
            bt_random.UseVisualStyleBackColor = true;
            bt_random.Click += bt_random_Click;
            // 
            // bt_sort
            // 
            bt_sort.Location = new Point(649, 362);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(107, 52);
            bt_sort.TabIndex = 4;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = true;
            bt_sort.Visible = false;
            bt_sort.Click += bt_sort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_sort);
            Controls.Add(bt_random);
            Controls.Add(lb_after);
            Controls.Add(lb_random);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Binarne drzewo poszukiwań";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_random;
        private Label lb_after;
        private Button bt_random;
        private Button bt_sort;
    }
}
