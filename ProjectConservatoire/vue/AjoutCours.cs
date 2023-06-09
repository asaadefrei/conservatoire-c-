﻿using Conservatoire.Controleur;
using Conservatoire.DAL;
using Conservatoire.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConservatoire.vue
{
    public partial class AjoutCours : Form
    {
        Mgr monManager;
        List<Jour> lJour = new List<Jour>();
        List<Tranche> lTranche = new List<Tranche>();
        private Prof p;
        AccueilConservatoire a;
        public AjoutCours(Prof p, AccueilConservatoire ac)
        {
            this.p = p;
            this.a = ac;
            monManager = new Mgr();
            InitializeComponent();
        }

        private void AjoutCours_Load(object sender, EventArgs e)
        {
            nomLabel.Text = p.Nom;
            prenomLabel.Text = p.Prenom;
            lJour = monManager.getJournée();

            afficheJour();
        }
        public void afficheJour()

        {


            try
            {


                jourBox.DataSource = null;
                jourBox.DataSource = lJour;
                jourBox.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void afficheTranche()

        {


            try
            {


                trancheBox.DataSource = null;
                trancheBox.DataSource = lTranche;
                trancheBox.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(jourBox.Text) || string.IsNullOrWhiteSpace(trancheBox.Text) ||
     string.IsNullOrWhiteSpace(capaciteBox.Text) || string.IsNullOrWhiteSpace(niveauBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Arrête l'exécution du code pour empêcher la soumission du formulaire
            }

            if (!int.TryParse(niveauBox.Text, out int niveau))
            {
                MessageBox.Show("Le niveau doit être un nombre entier.", "Format incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Arrête l'exécution du code pour empêcher la modification du professeur
            }
            if (!int.TryParse(capaciteBox.Text, out int capacite))
            {
                MessageBox.Show("La capacite doit être un nombre entier.", "Format incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Arrête l'exécution du code pour empêcher la modification du professeur
            }

            if (ConservatoireDAO.creerCours(p.Id, jourBox.Text, trancheBox.Text, int.Parse(capaciteBox.Text), int.Parse(niveauBox.Text)))
            {

                MessageBox.Show("création réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();
            a.Hide();
            AccueilConservatoire accueil = new AccueilConservatoire();
            accueil.Show();
        }

        private void jourBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jour j = (Jour)jourBox.SelectedItem;

            lTranche = monManager.getTranche(j.Journee);
            afficheTranche();
        }
    }
}
