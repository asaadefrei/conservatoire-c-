namespace ProjectConservatoire.vue
{
    partial class AjoutProf
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
            this.telBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mailBox = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.instrument = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.instrumentBox = new System.Windows.Forms.ComboBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.adresseBox = new System.Windows.Forms.TextBox();
            this.telBoxx = new System.Windows.Forms.TextBox();
            this.mailBoxx = new System.Windows.Forms.TextBox();
            this.salaireLabel = new System.Windows.Forms.Label();
            this.salaireBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professeur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "nom";
            // 
            // telBox
            // 
            this.telBox.AutoSize = true;
            this.telBox.Location = new System.Drawing.Point(54, 244);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(26, 20);
            this.telBox.TabIndex = 3;
            this.telBox.Text = "tel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mailBox
            // 
            this.mailBox.AutoSize = true;
            this.mailBox.Location = new System.Drawing.Point(54, 287);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(37, 20);
            this.mailBox.TabIndex = 5;
            this.mailBox.Text = "mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adresse";
            // 
            // prenomBox
            // 
            this.prenomBox.Location = new System.Drawing.Point(158, 151);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.Size = new System.Drawing.Size(218, 26);
            this.prenomBox.TabIndex = 7;
            // 
            // instrument
            // 
            this.instrument.AutoSize = true;
            this.instrument.Location = new System.Drawing.Point(54, 333);
            this.instrument.Name = "instrument";
            this.instrument.Size = new System.Drawing.Size(84, 20);
            this.instrument.TabIndex = 8;
            this.instrument.Text = "instrument";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // instrumentBox
            // 
            this.instrumentBox.FormattingEnabled = true;
            this.instrumentBox.Location = new System.Drawing.Point(158, 325);
            this.instrumentBox.Name = "instrumentBox";
            this.instrumentBox.Size = new System.Drawing.Size(218, 28);
            this.instrumentBox.TabIndex = 9;
            this.instrumentBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(158, 112);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(218, 26);
            this.nomBox.TabIndex = 10;
            // 
            // adresseBox
            // 
            this.adresseBox.Location = new System.Drawing.Point(158, 195);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(218, 26);
            this.adresseBox.TabIndex = 11;
            // 
            // telBoxx
            // 
            this.telBoxx.Location = new System.Drawing.Point(158, 244);
            this.telBoxx.Name = "telBoxx";
            this.telBoxx.Size = new System.Drawing.Size(218, 26);
            this.telBoxx.TabIndex = 12;
            // 
            // mailBoxx
            // 
            this.mailBoxx.Location = new System.Drawing.Point(158, 284);
            this.mailBoxx.Name = "mailBoxx";
            this.mailBoxx.Size = new System.Drawing.Size(218, 26);
            this.mailBoxx.TabIndex = 13;
            // 
            // salaireLabel
            // 
            this.salaireLabel.AutoSize = true;
            this.salaireLabel.Location = new System.Drawing.Point(54, 374);
            this.salaireLabel.Name = "salaireLabel";
            this.salaireLabel.Size = new System.Drawing.Size(55, 20);
            this.salaireLabel.TabIndex = 14;
            this.salaireLabel.Text = "salaire";
            // 
            // salaireBox
            // 
            this.salaireBox.Location = new System.Drawing.Point(158, 371);
            this.salaireBox.Name = "salaireBox";
            this.salaireBox.Size = new System.Drawing.Size(218, 26);
            this.salaireBox.TabIndex = 15;
            this.salaireBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ajoutez";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AjoutProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salaireBox);
            this.Controls.Add(this.salaireLabel);
            this.Controls.Add(this.mailBoxx);
            this.Controls.Add(this.telBoxx);
            this.Controls.Add(this.adresseBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.instrumentBox);
            this.Controls.Add(this.instrument);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutProf";
            this.Text = "AjoutProf";
            this.Load += new System.EventHandler(this.AjoutProf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label telBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prenomBox;
        private System.Windows.Forms.Label instrument;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox instrumentBox;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.TextBox adresseBox;
        private System.Windows.Forms.TextBox telBoxx;
        private System.Windows.Forms.TextBox mailBoxx;
        private System.Windows.Forms.Label salaireLabel;
        private System.Windows.Forms.TextBox salaireBox;
        private System.Windows.Forms.Button button1;
    }
}