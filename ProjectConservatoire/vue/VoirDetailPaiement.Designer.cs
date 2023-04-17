namespace ProjectConservatoire.vue
{
    partial class VoirDetailPaiement
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
            this.jourBox = new System.Windows.Forms.ComboBox();
            this.moisBox = new System.Windows.Forms.ComboBox();
            this.anneeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier paiement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Paiement";
            // 
            // jourBox
            // 
            this.jourBox.FormattingEnabled = true;
            this.jourBox.Location = new System.Drawing.Point(180, 134);
            this.jourBox.Name = "jourBox";
            this.jourBox.Size = new System.Drawing.Size(121, 28);
            this.jourBox.TabIndex = 2;
            // 
            // moisBox
            // 
            this.moisBox.FormattingEnabled = true;
            this.moisBox.Location = new System.Drawing.Point(338, 134);
            this.moisBox.Name = "moisBox";
            this.moisBox.Size = new System.Drawing.Size(121, 28);
            this.moisBox.TabIndex = 3;
            // 
            // anneeBox
            // 
            this.anneeBox.FormattingEnabled = true;
            this.anneeBox.Location = new System.Drawing.Point(500, 134);
            this.anneeBox.Name = "anneeBox";
            this.anneeBox.Size = new System.Drawing.Size(121, 28);
            this.anneeBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Si vous ne mettez aucune valeur cela mettra la date du jour par default";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(441, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VoirDetailPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anneeBox);
            this.Controls.Add(this.moisBox);
            this.Controls.Add(this.jourBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoirDetailPaiement";
            this.Text = "VoirDetailPaiement";
            this.Load += new System.EventHandler(this.VoirDetailPaiement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jourBox;
        private System.Windows.Forms.ComboBox moisBox;
        private System.Windows.Forms.ComboBox anneeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}