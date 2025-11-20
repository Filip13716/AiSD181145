namespace QuickSort
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
            lb_after = new Label();
            bt_random = new Button();
            bt_sort = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // lb_random
            // 
            lb_random.AutoSize = true;
            lb_random.Location = new Point(165, 107);
            lb_random.Name = "lb_random";
            lb_random.Size = new Size(50, 20);
            lb_random.TabIndex = 0;
            lb_random.Text = "label1";
            lb_random.Visible = false;
            // 
            // lb_after
            // 
            lb_after.AutoSize = true;
            lb_after.Location = new Point(165, 156);
            lb_after.Name = "lb_after";
            lb_after.Size = new Size(50, 20);
            lb_after.TabIndex = 1;
            lb_after.Text = "label2";
            lb_after.Visible = false;
            // 
            // bt_random
            // 
            bt_random.Location = new Point(510, 222);
            bt_random.Name = "bt_random";
            bt_random.Size = new Size(119, 37);
            bt_random.TabIndex = 2;
            bt_random.Text = "Losuj";
            bt_random.UseVisualStyleBackColor = true;
            bt_random.Click += bt_random_Click;
            // 
            // bt_sort
            // 
            bt_sort.Enabled = false;
            bt_sort.Location = new Point(510, 291);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(119, 41);
            bt_sort.TabIndex = 3;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = true;
            bt_sort.Click += bt_sort_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(319, 22);
            label3.Name = "label3";
            label3.Size = new Size(148, 38);
            label3.TabIndex = 4;
            label3.Text = "QuickSort";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(bt_sort);
            Controls.Add(bt_random);
            Controls.Add(lb_after);
            Controls.Add(lb_random);
            Name = "Form1";
            Text = "QuickSort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_random;
        private Label lb_after;
        private Button bt_random;
        private Button bt_sort;
        private Label label3;
    }
}
