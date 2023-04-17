using Conservatoire.Controleur;
using Conservatoire.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConservatoire.vue
{
    public partial class VoirDetailPaiement : Form
    {
        DateTime date = DateTime.Today;

        Inscription inscr;
        Trim t;
        Mgr monManager;
        List<int> lJour = new List<int>();
        List<int> lMois = new List<int>();
        List<int> lAnnee = new List<int>();
        PaiementClasse paye;
        public VoirDetailPaiement(Inscription inscription,Trim trim)
        {
            monManager = new Mgr();

            this.inscr = inscription;
            this.t = trim;
            InitializeComponent();
        }

        private void VoirDetailPaiement_Load(object sender, EventArgs e)
        {

            paye = monManager.getPaie(inscr,t);

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

            string datePaiement = paye.DatePaiement;
            string[] parties = datePaiement.Split('/');

            string jour = parties[0];
            string mois = parties[1];
            string annee = parties[2];

            jourBox.Text = jour;
            moisBox.Text = mois;
            anneeBox.Text = annee;


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

        private void button1_Click(object sender, EventArgs e)
        {

            string dateString = " ";

            

            if (jourBox.Text.ToString() == "" || moisBox.Text.ToString() == "" || anneeBox.Text.ToString() == "")
            {
                dateString = date.ToString("dd/MM/yyyy");


            }
            else
            {

                string jourI = jourBox.Text;
                if (jourI.Count() == 1)
                {
                    jourI = "0" + jourI;
                }
                string moisI = moisBox.Text;
                if (moisI.Count() == 1)
                {
                    moisI = "0" + moisI;
                }

                string anneeI = anneeBox.Text;
                dateString = jourI + "/" + moisI + "/" + anneeI;


            }




            monManager.modifPaiement(inscr, t, dateString);
        }
    }
}
