namespace ProjectConservatoire.vue
{
    partial class AccueilConservatoire
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
            this.listBoxProf = new System.Windows.Forms.ListBox();
            this.listBoxCours = new System.Windows.Forms.ListBox();
            this.listBoxEleve = new System.Windows.Forms.ListBox();
            this.VoirDetail = new System.Windows.Forms.Button();
            this.Ajoutez = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vueDensembleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProf
            // 
            this.listBoxProf.FormattingEnabled = true;
            this.listBoxProf.ItemHeight = 20;
            this.listBoxProf.Location = new System.Drawing.Point(12, 73);
            this.listBoxProf.Name = "listBoxProf";
            this.listBoxProf.Size = new System.Drawing.Size(653, 204);
            this.listBoxProf.TabIndex = 0;
            this.listBoxProf.SelectedIndexChanged += new System.EventHandler(this.listBoxProf_SelectedIndexChanged);
            // 
            // listBoxCours
            // 
            this.listBoxCours.FormattingEnabled = true;
            this.listBoxCours.ItemHeight = 20;
            this.listBoxCours.Location = new System.Drawing.Point(857, 73);
            this.listBoxCours.Name = "listBoxCours";
            this.listBoxCours.Size = new System.Drawing.Size(426, 104);
            this.listBoxCours.TabIndex = 1;
            this.listBoxCours.SelectedIndexChanged += new System.EventHandler(this.listBoxCours_SelectedIndexChanged);
            // 
            // listBoxEleve
            // 
            this.listBoxEleve.FormattingEnabled = true;
            this.listBoxEleve.ItemHeight = 20;
            this.listBoxEleve.Location = new System.Drawing.Point(857, 233);
            this.listBoxEleve.Name = "listBoxEleve";
            this.listBoxEleve.Size = new System.Drawing.Size(529, 84);
            this.listBoxEleve.TabIndex = 2;
            this.listBoxEleve.SelectedIndexChanged += new System.EventHandler(this.listBoxEleve_SelectedIndexChanged);
            // 
            // VoirDetail
            // 
            this.VoirDetail.Location = new System.Drawing.Point(58, 360);
            this.VoirDetail.Name = "VoirDetail";
            this.VoirDetail.Size = new System.Drawing.Size(282, 42);
            this.VoirDetail.TabIndex = 3;
            this.VoirDetail.Text = "voirDetail";
            this.VoirDetail.UseVisualStyleBackColor = true;
            this.VoirDetail.Visible = false;
            this.VoirDetail.Click += new System.EventHandler(this.VoirDetail_Click);
            // 
            // Ajoutez
            // 
            this.Ajoutez.Location = new System.Drawing.Point(432, 360);
            this.Ajoutez.Name = "Ajoutez";
            this.Ajoutez.Size = new System.Drawing.Size(233, 42);
            this.Ajoutez.TabIndex = 4;
            this.Ajoutez.Text = "Ajoutez";
            this.Ajoutez.UseVisualStyleBackColor = true;
            this.Ajoutez.Visible = false;
            this.Ajoutez.Click += new System.EventHandler(this.Ajoutez_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(759, 360);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(249, 42);
            this.Supprimer.TabIndex = 5;
            this.Supprimer.Text = "Supprimez";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Visible = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vueDensembleToolStripMenuItem,
            this.professeurToolStripMenuItem,
            this.coursToolStripMenuItem,
            this.inscriptionToolStripMenuItem,
            this.instrumentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1441, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vueDensembleToolStripMenuItem
            // 
            this.vueDensembleToolStripMenuItem.Name = "vueDensembleToolStripMenuItem";
            this.vueDensembleToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.vueDensembleToolStripMenuItem.Text = "vue d\'ensemble";
            this.vueDensembleToolStripMenuItem.Click += new System.EventHandler(this.vueDensembleToolStripMenuItem_Click);
            // 
            // professeurToolStripMenuItem
            // 
            this.professeurToolStripMenuItem.Name = "professeurToolStripMenuItem";
            this.professeurToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.professeurToolStripMenuItem.Text = "professeurs";
            this.professeurToolStripMenuItem.Click += new System.EventHandler(this.professeurToolStripMenuItem_Click);
            // 
            // coursToolStripMenuItem
            // 
            this.coursToolStripMenuItem.Name = "coursToolStripMenuItem";
            this.coursToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.coursToolStripMenuItem.Text = "cours";
            this.coursToolStripMenuItem.Click += new System.EventHandler(this.coursToolStripMenuItem_Click);
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.inscriptionToolStripMenuItem.Text = "inscriptions";
            this.inscriptionToolStripMenuItem.Click += new System.EventHandler(this.inscriptionToolStripMenuItem_Click);
            // 
            // instrumentsToolStripMenuItem
            // 
            this.instrumentsToolStripMenuItem.Name = "instrumentsToolStripMenuItem";
            this.instrumentsToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.instrumentsToolStripMenuItem.Text = "Paiement";
            this.instrumentsToolStripMenuItem.Click += new System.EventHandler(this.instrumentsToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1264, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "@";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Liste Professeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Liste Cours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Liste Eleve";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AccueilConservatoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajoutez);
            this.Controls.Add(this.VoirDetail);
            this.Controls.Add(this.listBoxEleve);
            this.Controls.Add(this.listBoxCours);
            this.Controls.Add(this.listBoxProf);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccueilConservatoire";
            this.Text = "AccueilConservatoire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccueilConservatoire_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccueilConservatoire_FormClosed);
            this.Load += new System.EventHandler(this.AccueilConservatoire_Load);
            this.Leave += new System.EventHandler(this.AccueilConservatoire_Leave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProf;
        private System.Windows.Forms.ListBox listBoxCours;
        private System.Windows.Forms.ListBox listBoxEleve;
        private System.Windows.Forms.Button VoirDetail;
        private System.Windows.Forms.Button Ajoutez;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vueDensembleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentsToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}