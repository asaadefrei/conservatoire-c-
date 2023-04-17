using Conservatoire.Controleur;
using Conservatoire.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConservatoire.vue
{
    public partial class AjouterPaiement : Form
    {
        private Inscription i;
        DateTime date = DateTime.Today;
        private Trim t;
        Mgr monManager;
        List<int> lJour = new List<int>();
        List<int> lMois = new List<int>();
        List<int> lAnnee = new List<int>();

        public AjouterPaiement(Inscription inscription, Trim trim)
        {
            monManager = new Mgr();

            this.i = inscription;
            this.t = trim;
            InitializeComponent();
            
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
                if(jourI.Count() == 1)
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

            DateTime dateFinTrim = DateTime.ParseExact(t.DateFin, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dateStringPayement = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dateInscription = DateTime.ParseExact(i.DateInscription, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (dateFinTrim > dateStringPayement)
            {

                monManager.creerPaiement(i, dateString, t);
                this.Close();

            }
            else if (dateInscription  > dateStringPayement)
            {

                MessageBox.Show("impossible de payer avant date d'inscription", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("echeance trop tard par raport à la date de fin du trimestre", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }



        }

        private void AjouterPaiement_Load(object sender, EventArgs e)
        {
            string dateString = date.ToString("dd/MM/yyyy");

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

    }
}
