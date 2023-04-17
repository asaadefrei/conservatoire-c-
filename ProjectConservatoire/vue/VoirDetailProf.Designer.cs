namespace ProjectConservatoire.vue
{
    partial class VoirDetailProf
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
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modifierButton = new System.Windows.Forms.Button();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.PrenomBox = new System.Windows.Forms.TextBox();
            this.adresseBox = new System.Windows.Forms.TextBox();
            this.telBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.instrumentBox = new System.Windows.Forms.ComboBox();
            this.salaireBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professeur Descritpion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "instrument";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "tel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "salaire";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "mail";
            // 
            // modifierButton
            // 
            this.modifierButton.Location = new System.Drawing.Point(142, 536);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(367, 40);
            this.modifierButton.TabIndex = 8;
            this.modifierButton.Text = "modifier";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(231, 111);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(204, 26);
            this.nomBox.TabIndex = 9;
            // 
            // PrenomBox
            // 
            this.PrenomBox.Location = new System.Drawing.Point(231, 160);
            this.PrenomBox.Name = "PrenomBox";
            this.PrenomBox.Size = new System.Drawing.Size(204, 26);
            this.PrenomBox.TabIndex = 10;
            // 
            // adresseBox
            // 
            this.adresseBox.Location = new System.Drawing.Point(231, 212);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(204, 26);
            this.adresseBox.TabIndex = 11;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(231, 271);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(204, 26);
            this.telBox.TabIndex = 12;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(231, 334);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(204, 26);
            this.mailBox.TabIndex = 13;
            // 
            // instrumentBox
            // 
            this.instrumentBox.FormattingEnabled = true;
            this.instrumentBox.Location = new System.Drawing.Point(231, 395);
            this.instrumentBox.Name = "instrumentBox";
            this.instrumentBox.Size = new System.Drawing.Size(204, 28);
            this.instrumentBox.TabIndex = 14;
            // 
            // salaireBox
            // 
            this.salaireBox.Location = new System.Drawing.Point(231, 456);
            this.salaireBox.Name = "salaireBox";
            this.salaireBox.Size = new System.Drawing.Size(204, 26);
            this.salaireBox.TabIndex = 15;
            // 
            // VoirDetailProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 598);
            this.Controls.Add(this.salaireBox);
            this.Controls.Add(this.instrumentBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.adresseBox);
            this.Controls.Add(this.PrenomBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoirDetailProf";
            this.Text = "VoirDetailProf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VoirDetailProf_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VoirDetailProf_FormClosed);
            this.Load += new System.EventHandler(this.VoirDetailProf_Load);
            this.Click += new System.EventHandler(this.VoirDetailProf_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button modifierButton;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.TextBox PrenomBox;
        private System.Windows.Forms.TextBox adresseBox;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.ComboBox instrumentBox;
        private System.Windows.Forms.TextBox salaireBox;
    }
}