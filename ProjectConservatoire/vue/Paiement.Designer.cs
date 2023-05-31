namespace ProjectConservatoire.vue
{
    partial class Paiement
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
            this.listBoxEleve = new System.Windows.Forms.ListBox();
            this.trimBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.anneeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paiement";
            // 
            // listBoxEleve
            // 
            this.listBoxEleve.FormattingEnabled = true;
            this.listBoxEleve.ItemHeight = 20;
            this.listBoxEleve.Location = new System.Drawing.Point(571, 117);
            this.listBoxEleve.Name = "listBoxEleve";
            this.listBoxEleve.Size = new System.Drawing.Size(671, 304);
            this.listBoxEleve.TabIndex = 1;
            this.listBoxEleve.SelectedIndexChanged += new System.EventHandler(this.eleveBox_SelectedIndexChanged);
            // 
            // trimBox
            // 
            this.trimBox.FormattingEnabled = true;
            this.trimBox.Location = new System.Drawing.Point(276, 117);
            this.trimBox.Name = "trimBox";
            this.trimBox.Size = new System.Drawing.Size(251, 28);
            this.trimBox.TabIndex = 2;
            this.trimBox.Text = "Trimestre";
            this.trimBox.SelectedIndexChanged += new System.EventHandler(this.trimBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "voirDetail/modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "valider un paiement";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(997, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Supprimer un paiement";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // anneeBox
            // 
            this.anneeBox.FormattingEnabled = true;
            this.anneeBox.Location = new System.Drawing.Point(93, 117);
            this.anneeBox.Name = "anneeBox";
            this.anneeBox.Size = new System.Drawing.Size(121, 28);
            this.anneeBox.TabIndex = 6;
            this.anneeBox.SelectedIndexChanged += new System.EventHandler(this.anneeBox_SelectedIndexChanged);
            // 
            // Paiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 643);
            this.Controls.Add(this.anneeBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trimBox);
            this.Controls.Add(this.listBoxEleve);
            this.Controls.Add(this.label1);
            this.Name = "Paiement";
            this.Text = "Paiement";
            this.Load += new System.EventHandler(this.Paiement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxEleve;
        private System.Windows.Forms.ComboBox trimBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox anneeBox;
    }
}