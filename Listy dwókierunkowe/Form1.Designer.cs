namespace Listy_dwókierunkowe
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
            lb_pokaz = new Label();
            text_input = new TextBox();
            lb_zachęta = new Label();
            lb_dodaj = new Button();
            rad_dod_aft = new RadioButton();
            rad_dod_bef = new RadioButton();
            rad_dod_norm = new RadioButton();
            combo_elem = new ComboBox();
            SuspendLayout();
            // 
            // lb_pokaz
            // 
            lb_pokaz.AutoSize = true;
            lb_pokaz.Location = new Point(268, 55);
            lb_pokaz.Name = "lb_pokaz";
            lb_pokaz.Size = new Size(38, 15);
            lb_pokaz.TabIndex = 0;
            lb_pokaz.Text = "label1";
            lb_pokaz.Visible = false;
            // 
            // text_input
            // 
            text_input.Location = new Point(275, 157);
            text_input.Name = "text_input";
            text_input.Size = new Size(217, 23);
            text_input.TabIndex = 1;
            // 
            // lb_zachęta
            // 
            lb_zachęta.AutoSize = true;
            lb_zachęta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_zachęta.Location = new Point(268, 118);
            lb_zachęta.Name = "lb_zachęta";
            lb_zachęta.Size = new Size(224, 25);
            lb_zachęta.TabIndex = 2;
            lb_zachęta.Text = "Podaj liczbę do dodania";
            // 
            // lb_dodaj
            // 
            lb_dodaj.Location = new Point(487, 186);
            lb_dodaj.Name = "lb_dodaj";
            lb_dodaj.Size = new Size(79, 46);
            lb_dodaj.TabIndex = 3;
            lb_dodaj.Text = "Dodaj";
            lb_dodaj.UseVisualStyleBackColor = true;
            lb_dodaj.Click += lb_dodaj_Click;
            // 
            // rad_dod_aft
            // 
            rad_dod_aft.AutoSize = true;
            rad_dod_aft.Location = new Point(268, 268);
            rad_dod_aft.Name = "rad_dod_aft";
            rad_dod_aft.Size = new Size(167, 19);
            rad_dod_aft.TabIndex = 6;
            rad_dod_aft.Text = "Dodaj po innym elemencie";
            rad_dod_aft.UseVisualStyleBackColor = true;
            rad_dod_aft.Visible = false;
            rad_dod_aft.CheckedChanged += rad_dod_aft_CheckedChanged;
            // 
            // rad_dod_bef
            // 
            rad_dod_bef.AutoSize = true;
            rad_dod_bef.Location = new Point(268, 293);
            rad_dod_bef.Name = "rad_dod_bef";
            rad_dod_bef.Size = new Size(188, 19);
            rad_dod_bef.TabIndex = 7;
            rad_dod_bef.Text = "Dodaj przed innym elementem";
            rad_dod_bef.UseVisualStyleBackColor = true;
            rad_dod_bef.Visible = false;
            rad_dod_bef.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rad_dod_norm
            // 
            rad_dod_norm.AutoSize = true;
            rad_dod_norm.Checked = true;
            rad_dod_norm.Location = new Point(268, 243);
            rad_dod_norm.Name = "rad_dod_norm";
            rad_dod_norm.Size = new Size(155, 19);
            rad_dod_norm.TabIndex = 8;
            rad_dod_norm.TabStop = true;
            rad_dod_norm.Text = "Standardowe dodawanie";
            rad_dod_norm.UseVisualStyleBackColor = true;
            rad_dod_norm.Visible = false;
            // 
            // combo_elem
            // 
            combo_elem.FormattingEnabled = true;
            combo_elem.Location = new Point(504, 268);
            combo_elem.Name = "combo_elem";
            combo_elem.Size = new Size(121, 23);
            combo_elem.TabIndex = 9;
            combo_elem.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(combo_elem);
            Controls.Add(rad_dod_norm);
            Controls.Add(rad_dod_bef);
            Controls.Add(rad_dod_aft);
            Controls.Add(lb_dodaj);
            Controls.Add(lb_zachęta);
            Controls.Add(text_input);
            Controls.Add(lb_pokaz);
            Name = "Form1";
            Text = "Listy dwókieronkowe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_pokaz;
        private TextBox text_input;
        private Label lb_zachęta;
        private Button lb_dodaj;
        private CheckBox ch_aft;
        private CheckBox ch_bef;
        private RadioButton rad_dod_aft;
        private RadioButton rad_dod_bef;
        private RadioButton rad_dod_norm;
        private ComboBox combo_elem;
    }
}
