using Conservatoire.Controleur;
using Conservatoire.Modele;
using Google.Protobuf;
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
    public partial class AjoutEleve : Form
    {

        Mgr monManager;
        AccueilConservatoire a;
        List<Niveau> lNiveau = new List<Niveau>();
        private Prof P;
        private Cours C;

        List<int> lJour = new List<int>();
        List<int> lMois = new List<int>();
        List<int> lAnnee = new List<int>();






        public AjoutEleve(Prof prof, Cours cours ,AccueilConservatoire a)
        {
            monManager = new Mgr();
            this.P = prof;
            this.C = cours;
            InitializeComponent();
            this.a = a;
        }

        private void AjoutEleve_Load(object sender, EventArgs e)
        {
            lNiveau = monManager.getNiveau();
            afficheNiveau();

            for (int i = 1; i <= 30; i++)
            {
                lJour.Add(i);
            }
            afficheJour();
            for (int i = 1; i <= 12; i++)
            {
                lMois.Add(i);
            }
            afficheMois();
            for (int i = 2015; i <= 2026; i++)
            {
                lAnnee.Add(i);
            }
            afficheAnnee();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jour = jourBox1.Text;
            string mois = moisBox2.Text;
            string annee = anneeBox3.Text;

            if (jour.Count() == 1)
            {
                jour = "0" + jour;
            }
            if (mois.Count() == 1)
            {
                mois = "0" + mois;
            }
            

            string inscriptionEleve = jour +"/"+ mois +"/"+ annee;


            bool reussite = monManager.creerEleve(P.Id,C.NumSeance, inscriptionEleve,nomBox.Text, prenomBox.Text, adresseBox.Text, telBox.Text, mailBox.Text, int.Parse(niveauBox.Text));
            if (reussite)
            {
                MessageBox.Show("Eleve Inscrit!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            this.Close();
            AccueilConservatoire accueil = new AccueilConservatoire();
            a.Hide();
            accueil.Show();
        }


        public void afficheJour()

        {


            try
            {


                jourBox1.DataSource = null;
                jourBox1.DataSource = lJour;
                jourBox1.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        public void afficheMois()

        {


            try
            {


                moisBox2.DataSource = null;
                moisBox2.DataSource = lMois;
                moisBox2.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void afficheAnnee()

        {


            try
            {


                anneeBox3.DataSource = null;
                anneeBox3.DataSource = lAnnee;
                anneeBox3.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
            public void afficheNiveau()

        {


            try
            {


                niveauBox.DataSource = null;
                niveauBox.DataSource = lNiveau;
                niveauBox.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
