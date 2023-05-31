using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conservatoire.DAL;
using Conservatoire.Modele;

namespace Conservatoire.Controleur
    {
        public class Mgr
        {

            ConservatoireDAO empDAO = new ConservatoireDAO();

            List<Prof> maListeProf;
            List<Cours> maListeCours;
            List<Eleve> maListeEleve;
            List<Instrument> maListeInstrument;
            List<Jour> maListeJournee;
        List<Tranche> maListeTranche;
        List<Trim> maListeTrim;
        List<Inscription> maListeInscription;
        PaiementClasse payeClasse;


        public Mgr()
            {

                maListeProf = new List<Prof>();
                maListeCours = new List<Cours>();
                maListeEleve = new List<Eleve>();
                maListeInstrument = new List<Instrument>();
                maListeJournee = new List<Jour>();
            maListeTranche = new List<Tranche>();
            maListeTrim = new List<Trim>();
            maListeInscription = new List<Inscription> ();
             payeClasse = null;

        }



        // Récupération de la liste des profs à partir de la DAL
        public List<Prof> chargementProfBD()
            {

                maListeProf = ConservatoireDAO.getProf();

                return (maListeProf);
            }


            // Mise à jour d'un employé  dans la DAL
            public bool verifConnexion(string unLogin, string unMdp)
            {

                bool ConnexionTrueOrFalse = ConservatoireDAO.verifConnexion(unLogin, unMdp);
                return ConnexionTrueOrFalse;

            }
        public List<Cours> chargementCoursBD(int id)
        {

            maListeCours = ConservatoireDAO.getCours(id);

            return (maListeCours);
        }
        public List<Eleve> chargementEleveBD(int numSeance)
        {

            maListeEleve = ConservatoireDAO.getEleve(numSeance);

            return (maListeEleve);
        }
        public List<Instrument> chargementInstrumentBD()
        {

            maListeInstrument = ConservatoireDAO.getInstrument();

            return (maListeInstrument);
        }
        public bool modifProf(int id, string nom, string prenom, string adresse, string tel, string mail, string instrument, float salaire)
        {
           bool reussi = ConservatoireDAO.modifProf(id, nom, prenom, adresse, tel, mail, instrument, salaire);

            return reussi;
        }
        public bool creerPersonne(string nom, string prenom, string adresse, string tel, string mail)
        {

            bool reussi = ConservatoireDAO.creerPersonne(nom, prenom, adresse, tel, mail);
            return reussi;
        }

        public bool creerProf(string nom, string prenom, string adresse, string tel, string mail, string instrument, float salaire)
        {

            bool reussi = ConservatoireDAO.creerProf( nom,  prenom,  adresse, tel, mail, instrument, salaire);
            return reussi;
           

        }
        public int getIdPersonne(string nom, string prenom, string adresse, string tel, string mail)
        {

            int Id = ConservatoireDAO.getIdPersonne(nom, prenom, adresse, tel, mail);
            return Id;



        }

        public  void deleteProf(Prof p)
        {

            ConservatoireDAO.deleteProf(p);



        }

        public List<Jour> getJournée()
        {
           maListeJournee = ConservatoireDAO.getJournee();

            return (maListeJournee);


        }
        public List<Tranche> getTranche(string journee)
        {
            maListeTranche = ConservatoireDAO.getTranche(journee);

            return (maListeTranche);

        }

        public bool modifCours(int numseance, string journee, string tranche, int capacite, int niveau)
        {
               
            if(ConservatoireDAO.modifCours(numseance, journee, tranche, capacite, niveau))
            {
                return true;


            }
            return false;
        }
        public bool creerCours(int id, string journee, string tranche, int capacite, int niveau)
        {

            if (ConservatoireDAO.creerCours(id, journee, tranche, capacite, niveau))
            {
                return true;


            }
            return false;
        }

        public void deleteCours(Cours c)
        {


            ConservatoireDAO.deleteCours(c);


        }
        public List<Niveau> getNiveau()
        {
            return ConservatoireDAO.getNiveau();

        }

        public bool modifEleve(int id, string nom, string prenom, string adresse, string tel, string mail, int niveau,string dateInscription)
        {
            if (ConservatoireDAO.modifEleve(id,nom,prenom,adresse,tel,mail,niveau,dateInscription))
            {
                return true;
            }
            return false;
        }


        public bool creerEleve(int idProf,int numSeance,string dateInscription,string nom, string prenom, string adresse, string tel, string mail, int niveau)
        {

            if (ConservatoireDAO.creerEleve(idProf, numSeance, dateInscription, nom, prenom, adresse, tel, mail, niveau))
            {

                return true;
            }
            return false;

        }

        public void deleteEleve(Eleve E)
        {


            ConservatoireDAO.deleteEleve(E);


        }
        public List<Eleve> paiementEleve()
        {

            maListeEleve = ConservatoireDAO.paiementEleve();

            return (maListeEleve);


        }

        public List<Trim> getTrim()
        {

            maListeTrim= ConservatoireDAO.getTrim();
            return (maListeTrim);

        }

        public List<Inscription> chargementInscriptionBDD()
        {

            maListeInscription = ConservatoireDAO.chargementInscriptionBDD();
            return (maListeInscription);

        }

        public  bool isResultFound(Inscription i, Trim t)
        {

            if (ConservatoireDAO.isResultFound(i, t))
            {
                return true;
            }
            return false;
        }

        public void deletePaiement(Inscription c)
        {
            ConservatoireDAO.deletePaiement(c);


        }
        public void creerPaiement(Inscription inscription, string datePaiement, Trim t)
        {
            ConservatoireDAO.creerPaiement(inscription, datePaiement, t);


        }
        public void modifPaiement(Inscription incription, Trim t, string datePaiement)
        {
            ConservatoireDAO.modifPaiement(incription, t, datePaiement);


        }
        public PaiementClasse getPaie(Inscription i, Trim t)
        {
          payeClasse =  ConservatoireDAO.getPaie(i, t); 
            return payeClasse;

        }
        public bool verifPayment(Inscription i, Trim t)
        {


            return ConservatoireDAO.verifPayment(i, t);


        }
        public List<Inscription> chargementInscriptionBDDFiltrer(Trim t)
        {


            maListeInscription = ConservatoireDAO.chargementInscriptionBDDFiltrer(t);
            return maListeInscription;

        }

        public List<Trim> getTrimSelected(string annee)
        {
            maListeTrim = ConservatoireDAO.getTrimSelected(annee);
            return maListeTrim;

        }









    }
}


