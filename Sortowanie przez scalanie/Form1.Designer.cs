namespace Sortowanie_przez_scalanie
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
            lb_nums = new Label();
            lb_after = new Label();
            bt_random = new Button();
            bt_sort = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 12);
            label1.Name = "label1";
            label1.Size = new Size(382, 41);
            label1.TabIndex = 0;
            label1.Text = "Sortowanie przez scalanie";
            label1.Click += label1_Click;
            // 
            // lb_nums
            // 
            lb_nums.AutoSize = true;
            lb_nums.Location = new Point(29, 84);
            lb_nums.Name = "lb_nums";
            lb_nums.Size = new Size(50, 20);
            lb_nums.TabIndex = 1;
            lb_nums.Text = "label2";
            lb_nums.Visible = false;
            // 
            // lb_after
            // 
            lb_after.AutoSize = true;
            lb_after.Location = new Point(29, 133);
            lb_after.Name = "lb_after";
            lb_after.Size = new Size(50, 20);
            lb_after.TabIndex = 2;
            lb_after.Text = "label2";
            lb_after.Visible = false;
            // 
            // bt_random
            // 
            bt_random.Location = new Point(782, 311);
            bt_random.Margin = new Padding(3, 4, 3, 4);
            bt_random.Name = "bt_random";
            bt_random.Size = new Size(90, 60);
            bt_random.TabIndex = 3;
            bt_random.Text = "Losuj";
            bt_random.UseVisualStyleBackColor = true;
            bt_random.Click += bt_random_Click;
            // 
            // bt_sort
            // 
            bt_sort.Location = new Point(782, 402);
            bt_sort.Margin = new Padding(3, 4, 3, 4);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(90, 60);
            bt_sort.TabIndex = 4;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = true;
            bt_sort.Visible = false;
            bt_sort.Click += bt_sort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 489);
            Controls.Add(bt_sort);
            Controls.Add(bt_random);
            Controls.Add(lb_after);
            Controls.Add(lb_nums);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_nums;
        private Label lb_after;
        private Button bt_random;
        private Button bt_sort;
    }
}
