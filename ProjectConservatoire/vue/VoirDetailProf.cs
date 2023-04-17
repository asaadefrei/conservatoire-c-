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
    public partial class VoirDetailProf : Form
    {
        private Prof P;
        private int id;
        AccueilConservatoire a;
        Mgr monManager;
        List<Instrument> lInstruments = new List<Instrument>();
        public VoirDetailProf(Prof prof, int unId,AccueilConservatoire unAc)
        {
            monManager = new Mgr();
            this.id = unId;
            this.P = prof;
            this.a = unAc;
            
            InitializeComponent();
        }

        private void VoirDetailProf_Load(object sender, EventArgs e)
        {
            nomBox.Text = P.Nom;
            PrenomBox.Text = P.Prenom;
            adresseBox.Text = P.Adresse;
            mailBox.Text = P.Mail;
            telBox.Text = P.Tel;
            salaireBox.Text = (P.Salaire).ToString();
            lInstruments = monManager.chargementInstrumentBD();
            afficheInstrument();
            instrumentBox.Text = P.Instrument;




        }
        public void afficheInstrument()

        {


            try
            {


                instrumentBox.DataSource = null;
                instrumentBox.DataSource = lInstruments;
                instrumentBox.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void modifierButton_Click(object sender, EventArgs e)
        {

           bool reussi=monManager.modifProf(id,(nomBox.Text).ToString(), PrenomBox.Text, adresseBox.Text, telBox.Text, mailBox.Text, instrumentBox.Text, float.Parse(salaireBox.Text));
            if (reussi)
            {

                MessageBox.Show("modification réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();
            AccueilConservatoire accueil = new AccueilConservatoire();
            a.Hide();
            accueil.Show();


        }

        private void VoirDetailProf_Click(object sender, EventArgs e)
        {
           
        }

        private void VoirDetailProf_FormClosing(object sender, FormClosingEventArgs e)
        {




        }

        private void VoirDetailProf_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
