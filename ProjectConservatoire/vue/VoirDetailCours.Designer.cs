namespace ProjectConservatoire.vue
{
    partial class VoirDetailCours
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
            this.prenomProfLabel = new System.Windows.Forms.Label();
            this.nomProfLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.JourBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trancheBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.capaciteBox = new System.Windows.Forms.TextBox();
            this.niveauBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cours :";
            // 
            // prenomProfLabel
            // 
            this.prenomProfLabel.AutoSize = true;
            this.prenomProfLabel.Location = new System.Drawing.Point(281, 90);
            this.prenomProfLabel.Name = "prenomProfLabel";
            this.prenomProfLabel.Size = new System.Drawing.Size(51, 20);
            this.prenomProfLabel.TabIndex = 1;
            this.prenomProfLabel.Text = "label2";
            // 
            // nomProfLabel
            // 
            this.nomProfLabel.AutoSize = true;
            this.nomProfLabel.Location = new System.Drawing.Point(137, 90);
            this.nomProfLabel.Name = "nomProfLabel";
            this.nomProfLabel.Size = new System.Drawing.Size(51, 20);
            this.nomProfLabel.TabIndex = 2;
            this.nomProfLabel.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prof:";
            // 
            // JourBox
            // 
            this.JourBox.FormattingEnabled = true;
            this.JourBox.Location = new System.Drawing.Point(141, 177);
            this.JourBox.Name = "JourBox";
            this.JourBox.Size = new System.Drawing.Size(191, 28);
            this.JourBox.TabIndex = 4;
            this.JourBox.SelectedIndexChanged += new System.EventHandler(this.JourBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tranche";
            // 
            // trancheBox
            // 
            this.trancheBox.FormattingEnabled = true;
            this.trancheBox.Location = new System.Drawing.Point(505, 177);
            this.trancheBox.Name = "trancheBox";
            this.trancheBox.Size = new System.Drawing.Size(202, 28);
            this.trancheBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Capacité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Niveau";
            // 
            // capaciteBox
            // 
            this.capaciteBox.Location = new System.Drawing.Point(141, 257);
            this.capaciteBox.Name = "capaciteBox";
            this.capaciteBox.Size = new System.Drawing.Size(191, 26);
            this.capaciteBox.TabIndex = 10;
            // 
            // niveauBox
            // 
            this.niveauBox.Location = new System.Drawing.Point(505, 260);
            this.niveauBox.Name = "niveauBox";
            this.niveauBox.Size = new System.Drawing.Size(202, 26);
            this.niveauBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VoirDetailCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.niveauBox);
            this.Controls.Add(this.capaciteBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trancheBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JourBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomProfLabel);
            this.Controls.Add(this.prenomProfLabel);
            this.Controls.Add(this.label1);
            this.Name = "VoirDetailCours";
            this.Text = "VoirDetailCours";
            this.Load += new System.EventHandler(this.VoirDetailCours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prenomProfLabel;
        private System.Windows.Forms.Label nomProfLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox JourBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox trancheBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox capaciteBox;
        private System.Windows.Forms.TextBox niveauBox;
        private System.Windows.Forms.Button button1;
    }
}