﻿namespace ProjectConservatoire.vue
{
    partial class AjouterPaiement
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valider un paiement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "datePaiement";
            // 
            // jourBox
            // 
            this.jourBox.FormattingEnabled = true;
            this.jourBox.Location = new System.Drawing.Point(197, 143);
            this.jourBox.Name = "jourBox";
            this.jourBox.Size = new System.Drawing.Size(68, 28);
            this.jourBox.TabIndex = 2;
            // 
            // moisBox
            // 
            this.moisBox.FormattingEnabled = true;
            this.moisBox.Location = new System.Drawing.Point(308, 143);
            this.moisBox.Name = "moisBox";
            this.moisBox.Size = new System.Drawing.Size(79, 28);
            this.moisBox.TabIndex = 3;
            // 
            // anneeBox
            // 
            this.anneeBox.FormattingEnabled = true;
            this.anneeBox.Location = new System.Drawing.Point(425, 143);
            this.anneeBox.Name = "anneeBox";
            this.anneeBox.Size = new System.Drawing.Size(157, 28);
            this.anneeBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Si vous ne notez aucune date cela le fera automatiquement";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AjouterPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.anneeBox);
            this.Controls.Add(this.moisBox);
            this.Controls.Add(this.jourBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjouterPaiement";
            this.Text = "AjouterPaiement";
            this.Load += new System.EventHandler(this.AjouterPaiement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jourBox;
        private System.Windows.Forms.ComboBox moisBox;
        private System.Windows.Forms.ComboBox anneeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}