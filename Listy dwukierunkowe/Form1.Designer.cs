namespace Listy_dwukierunkowe
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
            lb_list = new Label();
            textBox1 = new TextBox();
            bt_add = new Button();
            bt_before = new Button();
            comboBox1 = new ComboBox();
            bt_after = new Button();
            bt_del = new Button();
            SuspendLayout();
            // 
            // lb_list
            // 
            lb_list.AutoSize = true;
            lb_list.Location = new Point(53, 64);
            lb_list.Name = "lb_list";
            lb_list.Size = new Size(50, 20);
            lb_list.TabIndex = 0;
            lb_list.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(206, 175);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(94, 29);
            bt_add.TabIndex = 2;
            bt_add.Text = "Dodaj";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_before
            // 
            bt_before.Location = new Point(193, 223);
            bt_before.Name = "bt_before";
            bt_before.Size = new Size(116, 43);
            bt_before.TabIndex = 3;
            bt_before.Text = "Dodaj przed";
            bt_before.UseVisualStyleBackColor = true;
            bt_before.Click += bt_before_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // bt_after
            // 
            bt_after.Location = new Point(193, 272);
            bt_after.Name = "bt_after";
            bt_after.Size = new Size(116, 49);
            bt_after.TabIndex = 5;
            bt_after.Text = "Dodaj po";
            bt_after.UseVisualStyleBackColor = true;
            bt_after.Click += bt_after_Click;
            // 
            // bt_del
            // 
            bt_del.Location = new Point(206, 327);
            bt_del.Name = "bt_del";
            bt_del.Size = new Size(94, 29);
            bt_del.TabIndex = 6;
            bt_del.Text = "Usuń";
            bt_del.UseVisualStyleBackColor = true;
            bt_del.Click += bt_del_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_del);
            Controls.Add(bt_after);
            Controls.Add(comboBox1);
            Controls.Add(bt_before);
            Controls.Add(bt_add);
            Controls.Add(textBox1);
            Controls.Add(lb_list);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_list;
        private TextBox textBox1;
        private Button bt_add;
        private Button bt_before;
        private ComboBox comboBox1;
        private Button bt_after;
        private Button bt_del;
    }
}
