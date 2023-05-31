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
    public partial class AjoutProf : Form
    {

        Mgr monManager;
        List<Instrument> lInstruments = new List<Instrument>();

        AccueilConservatoire a;

        public AjoutProf(AccueilConservatoire ac)
        {
            monManager = new Mgr();

            InitializeComponent();
            this.a = ac;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void AjoutProf_Load(object sender, EventArgs e)
        {
            lInstruments = monManager.chargementInstrumentBD();
            afficheInstrument();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nomBox.Text) || string.IsNullOrWhiteSpace(prenomBox.Text) ||
       string.IsNullOrWhiteSpace(adresseBox.Text) || string.IsNullOrWhiteSpace(telBoxx.Text) ||
       string.IsNullOrWhiteSpace(mailBoxx.Text) || string.IsNullOrWhiteSpace(instrumentBox.Text) ||
       string.IsNullOrWhiteSpace(salaireBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Arrête l'exécution du code pour empêcher la création du professeur
            }
            if (!int.TryParse(salaireBox.Text, out int salaire))
            {
                MessageBox.Show("Le salaire doit être un nombre entier.", "Format incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Arrête l'exécution du code pour empêcher la modification du professeur
            }

            bool reussite = monManager.creerProf(nomBox.Text, prenomBox.Text, adresseBox.Text, telBoxx.Text, mailBoxx.Text, instrumentBox.Text, float.Parse(salaireBox.Text));
            if (reussite)
            {
                MessageBox.Show("Professeur crée!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            this.Close();
            AccueilConservatoire accueil = new AccueilConservatoire();
            a.Hide();
            accueil.Show();




        }
    }
}
