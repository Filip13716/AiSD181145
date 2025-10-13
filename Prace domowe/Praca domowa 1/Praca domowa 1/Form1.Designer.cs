namespace Praca_domowa_1
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
            bt_random = new Button();
            bt_sort = new Button();
            lb_nums = new Label();
            lb_after = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 7);
            label1.Name = "label1";
            label1.Size = new Size(250, 30);
            label1.TabIndex = 0;
            label1.Text = "Sortowanie bąbelkowe";
            label1.Click += label1_Click;
            // 
            // bt_random
            // 
            bt_random.Location = new Point(562, 192);
            bt_random.Margin = new Padding(3, 2, 3, 2);
            bt_random.Name = "bt_random";
            bt_random.Size = new Size(117, 54);
            bt_random.TabIndex = 1;
            bt_random.Text = "Losuj";
            bt_random.UseVisualStyleBackColor = true;
            bt_random.Click += bt_random_Click;
            // 
            // bt_sort
            // 
            bt_sort.Location = new Point(562, 261);
            bt_sort.Margin = new Padding(3, 2, 3, 2);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(117, 58);
            bt_sort.TabIndex = 2;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = true;
            bt_sort.Visible = false;
            bt_sort.Click += button2_Click;
            // 
            // lb_nums
            // 
            lb_nums.AutoSize = true;
            lb_nums.Location = new Point(24, 68);
            lb_nums.Name = "lb_nums";
            lb_nums.Size = new Size(38, 15);
            lb_nums.TabIndex = 3;
            lb_nums.Text = "label2";
            lb_nums.Visible = false;
            // 
            // lb_after
            // 
            lb_after.AutoSize = true;
            lb_after.Location = new Point(24, 95);
            lb_after.Name = "lb_after";
            lb_after.Size = new Size(38, 15);
            lb_after.TabIndex = 4;
            lb_after.Text = "label2";
            lb_after.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lb_after);
            Controls.Add(lb_nums);
            Controls.Add(bt_sort);
            Controls.Add(bt_random);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Sortowanie bąbelkowe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bt_random;
        private Button bt_sort;
        private Label lb_nums;
        private Label lb_after;
    }
}
