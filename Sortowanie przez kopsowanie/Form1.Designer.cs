namespace Sortowanie_przez_kopsowanie
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
            lb_nums = new Label();
            lb_after = new Label();
            bt_nums = new Button();
            bt_sort = new Button();
            SuspendLayout();
            // 
            // lb_nums
            // 
            lb_nums.AutoSize = true;
            lb_nums.Location = new Point(29, 25);
            lb_nums.Name = "lb_nums";
            lb_nums.Size = new Size(50, 20);
            lb_nums.TabIndex = 0;
            lb_nums.Text = "label1";
            lb_nums.Visible = false;
            // 
            // lb_after
            // 
            lb_after.AutoSize = true;
            lb_after.Location = new Point(29, 57);
            lb_after.Name = "lb_after";
            lb_after.Size = new Size(50, 20);
            lb_after.TabIndex = 1;
            lb_after.Text = "label1";
            lb_after.Visible = false;
            // 
            // bt_nums
            // 
            bt_nums.Location = new Point(644, 329);
            bt_nums.Name = "bt_nums";
            bt_nums.Size = new Size(94, 29);
            bt_nums.TabIndex = 2;
            bt_nums.Text = "Losuj";
            bt_nums.UseVisualStyleBackColor = true;
            bt_nums.Click += bt_sort_Click;
            // 
            // bt_sort
            // 
            bt_sort.Location = new Point(644, 376);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(94, 29);
            bt_sort.TabIndex = 3;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = true;
            bt_sort.Visible = false;
            bt_sort.Click += bt_sort_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_sort);
            Controls.Add(bt_nums);
            Controls.Add(lb_after);
            Controls.Add(lb_nums);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_nums;
        private Label lb_after;
        private Button bt_nums;
        private Button bt_sort;
    }
}
