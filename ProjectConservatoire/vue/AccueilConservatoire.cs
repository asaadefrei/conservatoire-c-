using Conservatoire.Controleur;
using Conservatoire.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConservatoire.vue
{
    public partial class AccueilConservatoire : Form
    {
        bool modifierProf = false;
        bool modifierCours = false;
        bool modifierEleve = false;
        Mgr monManager;

        List<Prof> lProfs = new List<Prof>();
        List<Cours> lCours = new List<Cours>();
        List<Eleve> lEleves = new List<Eleve>();

        public AccueilConservatoire()
        {
            monManager = new Mgr();
            InitializeComponent();
        }


        private void AccueilConservatoire_Load(object sender, EventArgs e)
        {
            lProfs = monManager.chargementProfBD();


            afficheProf();

            afficheCours();



        }
        public void afficheProf()

        {


            try
            {


                listBoxProf.DataSource = null;


                listBoxProf.DataSource = lProfs;
                listBoxProf.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        public void afficheCours()

        {


            try
            {


                listBoxCours.DataSource = null;

                listBoxCours.DataSource = lCours;
                listBoxCours.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void afficheEleve()

        {


            try
            {


                listBoxEleve.DataSource = null;

                listBoxEleve.DataSource = lEleves;
                listBoxEleve.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void AccueilConservatoire_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "PageLogin")
                {
                    form.Close();
                }
            }

        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierCours = false;
            modifierProf = true;
            VoirDetail.Visible = true;
            Ajoutez.Visible=true;
            Supprimer.Visible=true;
            VoirDetail.Text = "Voir Détail/modifier Professeur";
            Ajoutez.Text = "Ajoutez Professeur";
            Supprimer.Text = "Supprimer professeur";
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
             


            this.Hide();
            PageLogin pageLog = new PageLogin();
            pageLog.Show();
            
        }

        private void listBoxCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEleve.DataSource = null;

            if (listBoxCours.SelectedItem is Cours cours)
            {
                int numSeance = cours.NumSeance;
                lEleves = monManager.chargementEleveBD(numSeance);
                afficheEleve();
            }
            



        }

        private void listBoxProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prof P = (Prof)listBoxProf.SelectedItem;
            int idProf = P.Id;
            
           
             lCours = monManager.chargementCoursBD(idProf);
            
             afficheCours();



        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void coursToolStripMenuItem_Click(object sender, EventArgs e) {
            modifierCours = true;
            modifierProf = false;
            modifierEleve = false;

            VoirDetail.Visible = true;
            Ajoutez.Visible = true;
            Supprimer.Visible = true;
            VoirDetail.Text = "Voir Détail/modifier cours";
            Ajoutez.Text = "Ajouter cours";
            Supprimer.Text = "Supprimer cours";
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierProf = false;
            modifierCours = false;
            modifierEleve = true;

            VoirDetail.Visible = true;
            Ajoutez.Visible = true;
            Supprimer.Visible = true;
            VoirDetail.Text = "Voir Détail/modifier inscription";
            Ajoutez.Text = "Inscrire un eleve";
            Supprimer.Text = "Supprimer une iInscription";

        }

        private void vueDensembleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierProf = false;

            VoirDetail.Visible = false;
            Ajoutez.Visible = false;
            Supprimer.Visible = false;
            modifierEleve = false;

        }

        private void VoirDetail_Click(object sender, EventArgs e)
        {
            Prof P = (Prof)listBoxProf.SelectedItem;
            Cours c = (Cours)listBoxCours.SelectedItem;
            Eleve E = (Eleve)listBoxEleve.SelectedItem;

            if (modifierProf)
            {
                

                VoirDetailProf voirDetailProf = new VoirDetailProf(P, P.Id, this);

                voirDetailProf.ShowDialog();
            }
            if (modifierCours)
            {
                VoirDetailCours voirDetailCours = new VoirDetailCours(P, c, this);
                voirDetailCours.ShowDialog();


            }
            if (modifierEleve)
            {
                VoirDetailEleve voirDetailEleve = new VoirDetailEleve(E, this);
                voirDetailEleve.ShowDialog();
            }
            



        }

        private void Ajoutez_Click(object sender, EventArgs e)
        {
            Prof P = (Prof)listBoxProf.SelectedItem;
            Cours C = (Cours)listBoxCours.SelectedItem;

            if (modifierProf == true)
            {
                AjoutProf formAjoutProf = new AjoutProf(this);
                formAjoutProf.Show();
            }
            if (modifierCours)
            {
                AjoutCours ajoutCours = new AjoutCours(P, this);
                ajoutCours.ShowDialog();


            }
            if (modifierEleve)
            {
                AjoutEleve ajoutEleve = new AjoutEleve(P, C, this);
                ajoutEleve.ShowDialog();


            }



        }

        private void instrumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierProf = false;
            modifierEleve = false;
            modifierCours = false;

            Paiement paiement = new Paiement();
            paiement.ShowDialog();


        }

        private void AccueilConservatoire_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            

        }

        private void AccueilConservatoire_Leave(object sender, EventArgs e)
        {
           
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            Prof P = (Prof)listBoxProf.SelectedItem;

            Cours c = (Cours)listBoxCours.SelectedItem;

            Eleve E = (Eleve)listBoxEleve.SelectedItem;

            if (modifierProf == true)
            {

                monManager.deleteProf(P);
                AccueilConservatoire accueil = new AccueilConservatoire();
                this.Hide();
                accueil.Show();
            }
            if (modifierCours == true)
            {

                monManager.deleteCours(c);
                AccueilConservatoire accueil = new AccueilConservatoire();
                this.Hide();
                accueil.Show();

            }
            if (modifierEleve)
            {
                monManager.deleteEleve(E);
                AccueilConservatoire accueil = new AccueilConservatoire();
                this.Hide();
                accueil.Show();
            }







        }

        private void listBoxEleve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
