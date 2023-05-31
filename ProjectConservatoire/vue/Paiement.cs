using Conservatoire.Controleur;
using Conservatoire.Modele;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectConservatoire.vue
{
    public partial class Paiement : Form
    {


        Mgr monManager;
        List<Eleve> lEleves = new List<Eleve>();
        List<Trim> lTrim = new List<Trim>();
        List<Inscription> lInscription = new List<Inscription>();
        List<int> lAnnee = new List<int>();
        public Paiement()
        {
            monManager = new Mgr();
            InitializeComponent();
        }

        private void Paiement_Load(object sender, EventArgs e)
        {

            for (int i = 2021; i <= 2025; i++)
            {
                lAnnee.Add(i);
            }

            anneeBox.DataSource = null;

            anneeBox.DataSource = lAnnee;
            anneeBox.DisplayMember = "Description";











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

        public void afficheInscription()
        {

            try
            {
                listBoxEleve.DataSource = null;

                if (lInscription.Count > 0)
                {
                    listBoxEleve.DataSource = lInscription;
                    listBoxEleve.DisplayMember = "Description";

                    listBoxEleve.DrawMode = DrawMode.OwnerDrawFixed;
                    listBoxEleve.DrawItem += new DrawItemEventHandler(ListBoxEleve_DrawItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void afficheTrim()
        {


            try
            {


                trimBox.DataSource = null;

                trimBox.DataSource = lTrim;
                trimBox.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void ListBoxEleve_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            
            Trim t = (Trim)trimBox.SelectedItem;


            Inscription insc = lInscription[e.Index];
            bool etatPaiement = monManager.isResultFound(insc, t);


            e.DrawBackground();
            Brush myBrush = Brushes.Black;

            if (etatPaiement == false)
            {
                myBrush = Brushes.Orange;
            }
            else
            {
                myBrush = Brushes.Green;
            }


            e.Graphics.DrawString(insc.Description,
            e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

        }













        private void eleveBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trimBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trim t = (Trim)trimBox.SelectedItem;
            lInscription=monManager.chargementInscriptionBDDFiltrer(t);

            afficheInscription();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inscription c = (Inscription)listBoxEleve.SelectedItem;
            Trim t = (Trim)trimBox.SelectedItem;
            if (monManager.verifPayment(c, t))
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir continuer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    monManager.deletePaiement(c);
                }
               
            }
            else
            {
                MessageBox.Show("paiement pas encore effectuer", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Inscription c = (Inscription)listBoxEleve.SelectedItem;
                Trim t = (Trim)trimBox.SelectedItem;
                if (monManager.verifPayment(c, t))
                {
                    MessageBox.Show("Paiement deja valider !", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else
                {
                    AjouterPaiement ajtP = new AjouterPaiement(c, t);
                    ajtP.ShowDialog();
                }
                
            }
           catch (Exception emp)
            {

                throw (emp);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inscription c = (Inscription)listBoxEleve.SelectedItem;
            Trim t = (Trim)trimBox.SelectedItem;
            try { 
            
            if (!monManager.verifPayment(c, t))
            {
                MessageBox.Show("paiement pas encore effectuer", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                VoirDetailPaiement vdp = new VoirDetailPaiement(c, t);
                vdp.ShowDialog();
            }

        }
           catch (Exception emp)
            {

                throw (emp);

            }
    



        }

        private void anneeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int anneeInt = (int)anneeBox.SelectedItem;
            string annee = anneeInt.ToString();

            lTrim = monManager.getTrimSelected(annee);
            afficheTrim();
        }
    }
}
