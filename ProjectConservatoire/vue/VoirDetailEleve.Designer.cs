namespace ProjectConservatoire.vue
{
    partial class VoirDetailEleve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.adresseBox = new System.Windows.Forms.TextBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.niveauBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.anneeBox = new System.Windows.Forms.ComboBox();
            this.moisBox = new System.Windows.Forms.ComboBox();
            this.jourBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "tel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "niveau";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Eleve description";
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(153, 307);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(192, 26);
            this.telBox.TabIndex = 7;
            // 
            // adresseBox
            // 
            this.adresseBox.Location = new System.Drawing.Point(153, 253);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(192, 26);
            this.adresseBox.TabIndex = 8;
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(153, 130);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(192, 26);
            this.nomBox.TabIndex = 9;
            // 
            // prenomBox
            // 
            this.prenomBox.Location = new System.Drawing.Point(153, 195);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.Size = new System.Drawing.Size(192, 26);
            this.prenomBox.TabIndex = 10;
            this.prenomBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(153, 359);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(192, 26);
            this.mailBox.TabIndex = 11;
            // 
            // niveauBox
            // 
            this.niveauBox.FormattingEnabled = true;
            this.niveauBox.Location = new System.Drawing.Point(153, 414);
            this.niveauBox.Name = "niveauBox";
            this.niveauBox.Size = new System.Drawing.Size(192, 28);
            this.niveauBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anneeBox
            // 
            this.anneeBox.FormattingEnabled = true;
            this.anneeBox.Location = new System.Drawing.Point(387, 474);
            this.anneeBox.Name = "anneeBox";
            this.anneeBox.Size = new System.Drawing.Size(79, 28);
            this.anneeBox.TabIndex = 14;
            // 
            // moisBox
            // 
            this.moisBox.FormattingEnabled = true;
            this.moisBox.Location = new System.Drawing.Point(284, 474);
            this.moisBox.Name = "moisBox";
            this.moisBox.Size = new System.Drawing.Size(71, 28);
            this.moisBox.TabIndex = 15;
            // 
            // jourBox
            // 
            this.jourBox.FormattingEnabled = true;
            this.jourBox.Location = new System.Drawing.Point(207, 474);
            this.jourBox.Name = "jourBox";
            this.jourBox.Size = new System.Drawing.Size(51, 28);
            this.jourBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date Inscription";
            // 
            // VoirDetailEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 594);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.jourBox);
            this.Controls.Add(this.moisBox);
            this.Controls.Add(this.anneeBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.niveauBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.adresseBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoirDetailEleve";
            this.Load += new System.EventHandler(this.VoirDetailEleve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.TextBox adresseBox;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.TextBox prenomBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.ComboBox niveauBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox anneeBox;
        private System.Windows.Forms.ComboBox moisBox;
        private System.Windows.Forms.ComboBox jourBox;
        private System.Windows.Forms.Label label8;
    }
}