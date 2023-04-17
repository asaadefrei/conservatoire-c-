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
    public partial class VoirDetailEleve : Form
    {
        private Eleve E;
        AccueilConservatoire a;
        Mgr monManager;
        List<Niveau> lNiveau = new List<Niveau>();
        List<int> lJour = new List<int>();
        List<int> lMois = new List<int>();
        List<int> lAnnee = new List<int>();

        public VoirDetailEleve(Eleve eleve, AccueilConservatoire ac)
        {
            monManager = new Mgr();

            this.E = eleve;
            this.a = ac;
            InitializeComponent();
        }

        private void VoirDetailEleve_Load(object sender, EventArgs e)
        {

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


            string dateInscription = E.DateInscription;
            string[] parties = dateInscription.Split('/');

            string jour = parties[0];
            string mois = parties[1];
            string annee = parties[2];

            jourBox.Text = jour;
            moisBox.Text = mois;
            anneeBox.Text = annee;


            nomBox.Text = E.Nom;
            prenomBox.Text = E.Prenom;
            adresseBox.Text = E.Adresse;
            telBox.Text = E.Tel;
            mailBox.Text = E.Mail;
            lNiveau = monManager.getNiveau();
            afficheNiveau();

            niveauBox.Text = E.Niveau.ToString();

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
        public void afficheMois()

        {


            try
            {


                moisBox.DataSource = null;
                moisBox.DataSource = lMois;
                moisBox.DisplayMember = "Description";


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


                anneeBox.DataSource = null;
                anneeBox.DataSource = lAnnee;
                anneeBox.DisplayMember = "Description";


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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {

           string jourI = jourBox.Text;
            string moisI = moisBox.Text;
            string anneeI = anneeBox.Text;

            if (jourI.Count() == 1)
            {
                jourI = "0" + jourI;
            }
            if (moisI.Count() == 1)
            {
                moisI = "0" + moisI;
            }


            string dateI = jourI +"/"+ moisI +"/"+ anneeI;

            bool reussi = monManager.modifEleve(E.Id, (nomBox.Text).ToString(), prenomBox.Text, adresseBox.Text, telBox.Text, mailBox.Text,int.Parse(niveauBox.Text),dateI);
            if (reussi)
            {

                MessageBox.Show("modification réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();
            AccueilConservatoire accueil = new AccueilConservatoire();
            a.Hide();
            accueil.Show();
        }
    }
}
