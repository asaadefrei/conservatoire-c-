using Conservatoire.Controleur;
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
    public partial class PageLogin : Form
    {


        Mgr monManager;
        bool myConnexionPageLogin = false;
        public PageLogin()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unLoginConnexion = unLogin.Text;
            string unMdpConnexion = unMdp.Text;
            try
            {
                myConnexionPageLogin = monManager.verifConnexion(unLoginConnexion, unMdpConnexion);

                if (myConnexionPageLogin)
                {
                    MessageBox.Show("Connexion réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccueilConservatoire accueil = new AccueilConservatoire();
                     accueil.Show();
                    Deconnection deconection = new Deconnection();
                   /*  this.Hide();
                   */

                }
                else
                {

                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception emp)
            {

                throw (emp);

            }
        }

        private void pageLogin_Load(object sender, EventArgs e)
        {
            monManager = new Mgr();

        }

        private void pageLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
