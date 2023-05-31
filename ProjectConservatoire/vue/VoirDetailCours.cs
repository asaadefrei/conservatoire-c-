using Conservatoire.Controleur;
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
    public partial class VoirDetailCours : Form
    {

        Mgr monManager;
        List<Jour> lJour = new List<Jour>();
        List<Tranche> lTranche = new List<Tranche>();


        private Prof p;
        private Cours c;
        AccueilConservatoire a;
        public VoirDetailCours(Prof p, Cours c , AccueilConservatoire ac)
        {
            this.p = p;
            this.c = c;
            this.a = ac;
            InitializeComponent();
            monManager = new Mgr();
        }

        private void VoirDetailCours_Load(object sender, EventArgs e)
        {
            capaciteBox.Text = c.Capaciter.ToString();
            niveauBox.Text = c.Niveau.ToString();
            trancheBox.Text = c.Tranche;
            nomProfLabel.Text = p.Nom;
            prenomProfLabel.Text = p.Prenom;
            lJour = monManager.getJournée();

            afficheJour();



            JourBox.Text = c.Jour;
            lTranche = monManager.getTranche(c.Jour);

            afficheTranche();


            trancheBox.Text = c.Tranche;



        }

        public void afficheJour()

        {


            try
            {


                JourBox.DataSource = null;
                JourBox.DataSource = lJour;
                JourBox.DisplayMember = "Description";


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

        private void JourBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Jour j = (Jour)JourBox.SelectedItem;

            lTranche = monManager.getTranche(j.Journee);
            afficheTranche();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(capaciteBox.Text) || string.IsNullOrWhiteSpace(niveauBox.Text) ||
       string.IsNullOrWhiteSpace(JourBox.Text) || string.IsNullOrWhiteSpace(trancheBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Arrête l'exécution du code pour empêcher la modification du cours
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



            if (monManager.modifCours(c.NumSeance, JourBox.Text, trancheBox.Text, int.Parse(capaciteBox.Text), int.Parse(niveauBox.Text))){


                MessageBox.Show("modification réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();
            AccueilConservatoire accueil = new AccueilConservatoire();
            a.Hide();
            accueil.Show();


        





        }
    }
}
