namespace ProjectConservatoire.vue
{
    partial class AjoutCours
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
            this.trancheBox = new System.Windows.Forms.ComboBox();
            this.jourBox = new System.Windows.Forms.ComboBox();
            this.niveauBox = new System.Windows.Forms.TextBox();
            this.capaciteBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trancheBox
            // 
            this.trancheBox.FormattingEnabled = true;
            this.trancheBox.Location = new System.Drawing.Point(513, 160);
            this.trancheBox.Name = "trancheBox";
            this.trancheBox.Size = new System.Drawing.Size(182, 28);
            this.trancheBox.TabIndex = 0;
            // 
            // jourBox
            // 
            this.jourBox.FormattingEnabled = true;
            this.jourBox.Location = new System.Drawing.Point(176, 163);
            this.jourBox.Name = "jourBox";
            this.jourBox.Size = new System.Drawing.Size(182, 28);
            this.jourBox.TabIndex = 1;
            this.jourBox.SelectedIndexChanged += new System.EventHandler(this.jourBox_SelectedIndexChanged);
            // 
            // niveauBox
            // 
            this.niveauBox.Location = new System.Drawing.Point(513, 255);
            this.niveauBox.Name = "niveauBox";
            this.niveauBox.Size = new System.Drawing.Size(182, 26);
            this.niveauBox.TabIndex = 2;
            // 
            // capaciteBox
            // 
            this.capaciteBox.Location = new System.Drawing.Point(176, 252);
            this.capaciteBox.Name = "capaciteBox";
            this.capaciteBox.Size = new System.Drawing.Size(182, 26);
            this.capaciteBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(463, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ajoutez";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(49, 77);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(51, 20);
            this.nomLabel.TabIndex = 5;
            this.nomLabel.Text = "label1";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(172, 77);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(51, 20);
            this.prenomLabel.TabIndex = 6;
            this.prenomLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ajoutez un cours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tranche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Capacite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Niveau";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Jour";
            // 
            // AjoutCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.capaciteBox);
            this.Controls.Add(this.niveauBox);
            this.Controls.Add(this.jourBox);
            this.Controls.Add(this.trancheBox);
            this.Name = "AjoutCours";
            this.Text = "AjoutCours";
            this.Load += new System.EventHandler(this.AjoutCours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trancheBox;
        private System.Windows.Forms.ComboBox jourBox;
        private System.Windows.Forms.TextBox niveauBox;
        private System.Windows.Forms.TextBox capaciteBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}