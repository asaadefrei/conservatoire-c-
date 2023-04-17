using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Conservatoire.Modele;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Conservatoire.DAL
{
    public class ConservatoireDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoireefrei";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;
        private static MySqlCommand Ocom2;
        private static MySqlCommand Ocom3;
        private static MySqlCommand Ocom4;
        private static MySqlCommand Ocom5;



        // Mise à jour d'un employé




        // Récupération de la liste des employés
        public static List<Prof> getProf()
        {

            List<Prof> lc = new List<Prof>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT id,nom,prenom,adresse,tel,mail,Ref,salaire FROM prof JOIN personne ON prof.IDPROF = personne.id");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Prof p;




                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string adresse = (string)reader.GetValue(3);
                    string tel = (string)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);
                   
                    string instrument = (string)reader.GetValue(6);

                    float salaire = (float)reader.GetValue(7);
                    //Instanciation d'un EmplyeS

                    p = new Prof(id, nom, prenom,adresse, tel,mail, instrument,salaire);

                    // Ajout de cet employe à la liste 
                    lc.Add(p);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }




        public static List<Trim> getTrim()
        {

            List<Trim> lt = new List<Trim>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT libelle,datefin from trim");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Trim t;




                while (reader.Read())
                {

                    string libelle = (string)reader.GetValue(0);
                    string datefin = (string)reader.GetValue(1);
                   
                    //Instanciation d'un EmplyeS

                    t = new Trim(libelle,datefin);

                    // Ajout de cet employe à la liste 
                    lt.Add(t);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lt);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static List<Inscription> chargementInscriptionBDD()
        {

            List<Inscription> lI = new List<Inscription>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT e.NOM as nomEleve, e.PRENOM as prenomEleve,i.IDELEVE, p.NOM as nomProf, p.PRENOM as prenomProf,i.IDPROF,i.NUMSEANCE, i.DATEINSCRIPTION FROM INSCRIPTION i JOIN ELEVE el ON i.IDELEVE = el.IDELEVE JOIN PERSONNE e ON el.IDELEVE = e.ID JOIN PROF pr ON i.IDPROF = pr.IDPROF JOIN PERSONNE p ON pr.IDPROF = p.ID");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Inscription i;




                while (reader.Read())
                {

                    string nomEleve = (string)reader.GetValue(0);
                    string prenomEleve = (string)reader.GetValue(1);
                    int idEleve = (int)reader.GetValue(2);

                    string nomProf = (string)reader.GetValue(3);

                    string prenomProf = (string)reader.GetValue(4);

                    int idProf = (int)reader.GetValue(5);

                    int numSeance = (int)reader.GetValue(6);

                    string dateInscription = (string)reader.GetValue(7);

                    //Instanciation d'un EmplyeS

                    i = new Inscription(idProf, idEleve,numSeance,dateInscription,nomEleve,prenomEleve,nomProf,prenomProf);

                    // Ajout de cet employe à la liste 
                    lI.Add(i);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lI);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }



        public static bool verifConnexion(string unLogin, string unMdp)
        {
            bool conectionConservatoire = false;
            int rowCount = 0;



            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * FROM `admin` where login =@login and mdp=@mdp");
                Ocom.Parameters.AddWithValue("@login", unLogin);
                Ocom.Parameters.AddWithValue("@mdp", unMdp);
                /*prevenir les injections sql */

                MySqlDataReader reader = Ocom.ExecuteReader();



                while (reader.Read())
                {
                    rowCount++;
                }

                reader.Close();
                maConnexionSql.closeConnection();

                if (rowCount == 1)
                {
                    conectionConservatoire = true;
                }

                return conectionConservatoire;

            }
            catch (Exception emp)
            {

                throw (emp);

            }




        }


        public static List<Cours> getCours(int id)
        {

            List<Cours> lc = new List<Cours>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT jour,tranche,capacite,niveau,numSeance FROM seance where IDPROF="+ id);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Cours c;




                while (reader.Read())
                {

                    string jour = (string)reader.GetValue(0);
                    string tranche = (string)reader.GetValue(1);
                    int capacite = (int)reader.GetValue(2);
                    int niveau = (int)reader.GetValue(3);
                    int numSeance = (int)reader.GetValue(4);
                    
                    //Instanciation d'un EmplyeS
                    c = new Cours(jour, tranche, capacite,niveau,numSeance);

                    // Ajout de cet employe à la liste 
                    lc.Add(c);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

     /*   public static List<Cours> getCours(int id)
        {

            List<Cours> lc = new List<Cours>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT s.jour, s.tranche, s.capacite, s.niveau,s.numseance, COUNT(*) as nb_eleve FROM seance s INNER JOIN inscription i ON s.NUMSEANCE = i.NUMSEANCE WHERE s.idprof =" + id + " GROUP BY s.jour, s.tranche, s.capacite, s.niveau");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Cours c;




                while (reader.Read())
                {

                    string jour = (string)reader.GetValue(0);
                    string tranche = (string)reader.GetValue(1);
                    int capacite = (int)reader.GetValue(2);
                    int niveau = (int)reader.GetValue(3);
                    int numSeance = (int)reader.GetValue(4);
                    int nbEleve = Convert.ToInt32(reader.GetValue(5));

                    //Instanciation d'un EmplyeS
                    c = new Cours(jour, tranche, capacite, niveau, nbEleve, numSeance);

                    // Ajout de cet employe à la liste 
                    lc.Add(c);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        */

        public static List<Eleve> getEleve(int numSeance)
        {

            List<Eleve> lc = new List<Eleve>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT p.id, p.nom, p.prenom, p.adresse, p.tel, p.mail, e.niveau,i.dateinscription FROM eleve e INNER JOIN personne p ON e.ideleve = p.id INNER JOIN inscription i ON i.ideleve = e.ideleve WHERE i.numseance ="+ numSeance);

                MySqlDataReader reader = Ocom.ExecuteReader();

                Eleve e;




                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string adresse = (string)reader.GetValue(3);
                    string tel = (string)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);
                    int niveau = (int)reader.GetValue(6);
                    string dateInscription = (string)reader.GetValue(7);

                    //Instanciation d'un EmplyeS
                    e = new Eleve(id,nom, prenom, adresse, tel, mail,niveau);
                    e.DateInscription = dateInscription;

                   
                    // Ajout de cet employe à la liste 
                    lc.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

           public static List<Instrument> getInstrument()
            {

                List<Instrument> li = new List<Instrument>();

                try
                {

                    maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                    maConnexionSql.openConnection();


                    Ocom = maConnexionSql.reqExec("SELECT ref from instrument");


                    MySqlDataReader reader = Ocom.ExecuteReader();

                    Instrument i;




                    while (reader.Read())
                    {

                        string instrument = (string)reader.GetValue(0);
                        

                        //Instanciation d'un EmplyeS
                        i = new Instrument(instrument);

                        // Ajout de cet employe à la liste 
                        li.Add(i);


                    }



                    reader.Close();

                    maConnexionSql.closeConnection();

                    // Envoi de la liste au Manager
                    return (li);


                }

                catch (Exception emp)
                {

                    throw (emp);

                }


        }
        public static List<Niveau> getNiveau()
        {

            List<Niveau> lN = new List<Niveau>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT niveau from niveau");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Niveau n;




                while (reader.Read())
                {

                    int niveau = (int)reader.GetValue(0);


                    //Instanciation d'un EmplyeS
                    n = new Niveau(niveau);

                    // Ajout de cet employe à la liste 
                    lN.Add(n);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lN);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static List<Jour> getJournee()
        {

            List<Jour> lj = new List<Jour>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * from jour");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Jour j;




                while (reader.Read())
                {

                    string journée = (string)reader.GetValue(0);


                    //Instanciation d'un EmplyeS
                     j = new Jour(journée);

                    // Ajout de cet employe à la liste 
                    lj.Add(j);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lj);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }



        public static List<Tranche> getTranche(string journee)
        {

            List<Tranche> lT = new List<Tranche>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT tranche FROM heure join jour WHERE jour.jour = @jour AND NOT EXISTS ( SELECT * FROM seance WHERE heure.TRANCHE = seance.TRANCHE AND seance.jour = @jour )");
                Ocom.Parameters.AddWithValue("@jour", journee);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Tranche t;




                while (reader.Read())
                {

                    string tranche = (string)reader.GetValue(0);


                    //Instanciation d'un EmplyeS
                    t = new Tranche(tranche);

                    // Ajout de cet employe à la liste 
                    lT.Add(t);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lT);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }


        public static bool modifProf(int id, string nom, string prenom, string adresse,string tel, string mail, string instrument, float salaire)
        {

           

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("UPDATE prof inner join personne on prof.IDPROF=personne.id SET nom='"+nom+"',prenom='"+prenom+"',adresse='"+adresse+"',tel='"+tel+"', mail='"+mail+"', `REF`='"+instrument+"',`SALAIRE`="+salaire+" WHERE prof.IDPROF="+id);
           /*     Ocom.Parameters.AddWithValue("@id", id);
                Ocom.Parameters.AddWithValue("@nom", nom);
                Ocom.Parameters.AddWithValue("@prenom", prenom);
                Ocom.Parameters.AddWithValue("@tel", tel);
                Ocom.Parameters.AddWithValue("@mail", mail);
                Ocom.Parameters.AddWithValue("@instrument", instrument);
                Ocom.Parameters.AddWithValue("@salaire", salaire);
             */   

                MySqlDataReader reader = Ocom.ExecuteReader();

               




                



                reader.Close();

                maConnexionSql.closeConnection();

                return true;


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }
        /*string instrument, float salaire
         * */
        public static bool creerPersonne(string nom, string prenom, string adresse, string tel, string mail)
        {



            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                string req = "INSERT INTO `personne`(id ,`NOM`, `PRENOM`, `TEL`, `MAIL`, `ADRESSE`) VALUES (Null,@nom,@prenom,@tel,@mail,@adresse)";
                Ocom = maConnexionSql.reqExec(req);

                Ocom.Parameters.AddWithValue("@nom", nom);
                     Ocom.Parameters.AddWithValue("@prenom", prenom);
                     Ocom.Parameters.AddWithValue("@tel", tel);
                     Ocom.Parameters.AddWithValue("@mail", mail);
                     Ocom.Parameters.AddWithValue("@adresse", adresse);

                /*  Ocom.Parameters.AddWithValue("@instrument", instrument);
                  Ocom.Parameters.AddWithValue("@salaire", salaire);
               */

                int i = Ocom.ExecuteNonQuery();











                maConnexionSql.closeConnection();

                return true;


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }


        public static bool creerProf(string nom, string prenom, string adresse, string tel, string mail, string instrument, float salaire)
        { 



            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                string req = "INSERT INTO `personne`(id ,`NOM`, `PRENOM`, `TEL`, `MAIL`, `ADRESSE`) VALUES (Null,@nom,@prenom,@tel,@mail,@adresse)";
                Ocom = maConnexionSql.reqExec(req);
                Ocom.Parameters.AddWithValue("@nom", nom);
                Ocom.Parameters.AddWithValue("@prenom", prenom);
                Ocom.Parameters.AddWithValue("@tel", tel);
                Ocom.Parameters.AddWithValue("@mail", mail);
                Ocom.Parameters.AddWithValue("@adresse", adresse);

                int i = Ocom.ExecuteNonQuery();

                int idProf = 0;

                Ocom2 = maConnexionSql.reqExec("SELECT ID FROM PERSONNE WHERE NOM = @nom AND PRENOM = @prenom AND TEL = @tel AND MAIL = @mail AND ADRESSE =@adresse");
                Ocom2.Parameters.AddWithValue("@nom", nom);
                Ocom2.Parameters.AddWithValue("@prenom", prenom);
                Ocom2.Parameters.AddWithValue("@tel", tel);
                Ocom2.Parameters.AddWithValue("@mail", mail);
                Ocom2.Parameters.AddWithValue("@adresse", adresse);


                MySqlDataReader reader = Ocom2.ExecuteReader();

              


                while (reader.Read())
                {

                    idProf = (int)reader.GetValue(0);



                }
                reader.Close();




                string req3 = "INSERT INTO `Prof`(`IDPROF` ,`REF`, `Salaire`) VALUES (@idprof, @instrument ,@Salaire)";
                               Ocom3 = maConnexionSql.reqExec(req3);


                  Ocom3.Parameters.AddWithValue("@instrument", instrument);
                  Ocom3.Parameters.AddWithValue("@salaire", salaire);
                Ocom3.Parameters.AddWithValue("@idprof", idProf);


                int i3 = Ocom3.ExecuteNonQuery();











                reader.Close();

                maConnexionSql.closeConnection();

                return true;


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }


        public static int getIdPersonne(string nom, string prenom, string adresse, string tel, string mail)
        {

            int id = 0;
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT ID FROM PERSONNE WHERE NOM = @nom AND PRENOM = @prenom AND TEL = @tel AND MAIL = @mail AND ADRESSE =@adresse");
                Ocom.Parameters.AddWithValue("@nom", nom);
                Ocom.Parameters.AddWithValue("@prenom", prenom);
                Ocom.Parameters.AddWithValue("@tel", tel);
                Ocom.Parameters.AddWithValue("@mail", mail);
                Ocom.Parameters.AddWithValue("@adresse", adresse);
                

                MySqlDataReader reader = Ocom.ExecuteReader();

                Prof p;




                while (reader.Read())
                {

                     id = (int)reader.GetValue(0);
                   
                    

                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return id;


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }


        public static void deleteProf(Prof p)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("delete from payer where idProf = " + p.Id);


                Ocom2 = maConnexionSql.reqExec("delete from inscription where idProf = " + p.Id);

                Ocom3 = maConnexionSql.reqExec("delete from seance where idProf = " + p.Id);
                Ocom4 = maConnexionSql.reqExec("delete from prof where idProf = " + p.Id);
                Ocom5 = maConnexionSql.reqExec("delete from personne where id = " + p.Id);



                int i = Ocom.ExecuteNonQuery();
                int i2 = Ocom2.ExecuteNonQuery();

                int i3 = Ocom3.ExecuteNonQuery();
                int i4 = Ocom4.ExecuteNonQuery();
                int i5 = Ocom5.ExecuteNonQuery();







                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }


        public static bool modifCours(int numseance, string journee,string tranche, int capacite,int niveau)
        {



            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec(" UPDATE `seance` SET `TRANCHE`=@tranche,`JOUR`=@jour,`NIVEAU`=@niveau ,`CAPACITE`=@capacite WHERE `NUMSEANCE`= @num");
                    Ocom.Parameters.AddWithValue("@num", numseance);
                     Ocom.Parameters.AddWithValue("@jour", journee);
                     Ocom.Parameters.AddWithValue("@tranche", tranche);
                     Ocom.Parameters.AddWithValue("@capacite", capacite);
                     Ocom.Parameters.AddWithValue("@niveau", niveau);

                /*   Ocom.Parameters.AddWithValue("@mail", mail);
                   Ocom.Parameters.AddWithValue("@instrument", instrument);
                   Ocom.Parameters.AddWithValue("@salaire", salaire);
                */

                MySqlDataReader reader = Ocom.ExecuteReader();










                reader.Close();

                maConnexionSql.closeConnection();

                return true;


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }


        public static bool creerCours(int id, string journee, string tranche, int capacite, int niveau)
        {

            int numseance = 0;

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("SELECT MAX(numSeance) FROM seance");

                MySqlDataReader reader = Ocom.ExecuteReader();




                while (reader.Read())
                {

                    numseance = (int)reader.GetValue(0);



                }
                reader.Close();

                numseance++;



                string req = "INSERT INTO `seance`(`IDPROF`, `NUMSEANCE`, `TRANCHE`, `JOUR`, `NIVEAU`, `CAPACITE`) VALUES (@id,@numseance,@tranche,@journee,@niveau,@capacite)";
                Ocom2 = maConnexionSql.reqExec(req);

                Ocom2.Parameters.AddWithValue("@id", id);
                Ocom2.Parameters.AddWithValue("@numseance", numseance);
                Ocom2.Parameters.AddWithValue("@journee", journee);
                Ocom2.Parameters.AddWithValue("@tranche", tranche);
                Ocom2.Parameters.AddWithValue("@capacite", capacite);
                Ocom2.Parameters.AddWithValue("@niveau", niveau);



                /*  Ocom.Parameters.AddWithValue("@instrument", instrument);
                  Ocom.Parameters.AddWithValue("@salaire", salaire);
               */

                int i = Ocom2.ExecuteNonQuery();











                maConnexionSql.closeConnection();

                return true;


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static void deleteCours(Cours c)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("delete from inscription where numseance = " + c.NumSeance);

                Ocom2 = maConnexionSql.reqExec("delete from seance where numseance = " + c.NumSeance);
               


                int i = Ocom.ExecuteNonQuery();
                int i2 = Ocom2.ExecuteNonQuery();








                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        public static bool modifEleve(int id, string nom, string prenom, string adresse, string tel, string mail, int niveau,string dateInscription)
        {



            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("UPDATE eleve inner join personne on eleve.IDELEVE=personne.id INNER JOIN inscription ON eleve.IDELEVE = inscription.IDELEVE SET nom=@nom, prenom=@prenom, adresse=@adresse, tel=@tel, mail=@mail, niveau=@niveau,dateinscription=@dateinscriptioneleve WHERE eleve.ideleve=@id");
                   Ocom.Parameters.AddWithValue("@id", id);
                     Ocom.Parameters.AddWithValue("@nom", nom);
                     Ocom.Parameters.AddWithValue("@prenom", prenom);
                      Ocom.Parameters.AddWithValue("@adresse", adresse);

                      Ocom.Parameters.AddWithValue("@tel", tel);
                     Ocom.Parameters.AddWithValue("@mail", mail);
                     Ocom.Parameters.AddWithValue("@niveau", niveau);

                Ocom.Parameters.AddWithValue("@dateinscriptioneleve", dateInscription);




                MySqlDataReader reader = Ocom.ExecuteReader();

                reader.Close();












                maConnexionSql.closeConnection();

                return true;


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static bool creerEleve(int idProf,int numSeance,string dateInscription,string nom, string prenom, string adresse, string tel, string mail, int niveau)
        {



            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                string req = "INSERT INTO `personne`(id ,`NOM`, `PRENOM`, `TEL`, `MAIL`, `ADRESSE`) VALUES (Null,@nom,@prenom,@tel,@mail,@adresse)";
                Ocom = maConnexionSql.reqExec(req);
                Ocom.Parameters.AddWithValue("@nom", nom);
                Ocom.Parameters.AddWithValue("@prenom", prenom);
                Ocom.Parameters.AddWithValue("@tel", tel);
                Ocom.Parameters.AddWithValue("@mail", mail);
                Ocom.Parameters.AddWithValue("@adresse", adresse);

                int i = Ocom.ExecuteNonQuery();

                int idEleve= 0;

                Ocom2 = maConnexionSql.reqExec("SELECT ID FROM PERSONNE WHERE NOM = @nom AND PRENOM = @prenom AND TEL = @tel AND MAIL = @mail AND ADRESSE =@adresse");
                Ocom2.Parameters.AddWithValue("@nom", nom);
                Ocom2.Parameters.AddWithValue("@prenom", prenom);
                Ocom2.Parameters.AddWithValue("@tel", tel);
                Ocom2.Parameters.AddWithValue("@mail", mail);
                Ocom2.Parameters.AddWithValue("@adresse", adresse);




                MySqlDataReader reader = Ocom2.ExecuteReader();




                while (reader.Read())
                {

                    idEleve = (int)reader.GetValue(0);



                }
                reader.Close();




                string req3 = "INSERT INTO `eleve`(`IDELEVE` ,`Niveau`) VALUES (@ideleve, @niveau)";
                Ocom3 = maConnexionSql.reqExec(req3);


                Ocom3.Parameters.AddWithValue("@niveau", niveau);
                Ocom3.Parameters.AddWithValue("@ideleve", idEleve);


                int i3 = Ocom3.ExecuteNonQuery();


                string req4 = "INSERT INTO `inscription`(`IDPROF`, `IDELEVE`, `NUMSEANCE`, `DATEINSCRIPTION`) VALUES (@idprof, @ideleve, @numseance, @date)";
                Ocom4 = maConnexionSql.reqExec(req4);

                Ocom4.Parameters.AddWithValue("@idprof", idProf);
                Ocom4.Parameters.AddWithValue("@ideleve", idEleve);


                Ocom4.Parameters.AddWithValue("@numseance", numSeance);
                Ocom4.Parameters.AddWithValue("@date", dateInscription);


                int i4 = Ocom4.ExecuteNonQuery();







                reader.Close();

                maConnexionSql.closeConnection();

                return true;


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }
        public static void deleteEleve(Eleve E)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("delete from payer where idEleve = " + E.Id);

                Ocom2 = maConnexionSql.reqExec("delete from inscription where idEleve = " + E.Id);


                Ocom3 = maConnexionSql.reqExec("delete from eleve where idELEVE = " + E.Id);
                Ocom4 = maConnexionSql.reqExec("delete from personne where id = " + E.Id);



                int i = Ocom.ExecuteNonQuery();
                int i2 = Ocom2.ExecuteNonQuery();

                int i3 = Ocom3.ExecuteNonQuery();
                int i4 = Ocom4.ExecuteNonQuery();







                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }


        public static List<Eleve> paiementEleve()
        {

            List<Eleve> lc = new List<Eleve>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT p.id, p.nom, p.prenom, p.adresse, p.tel, p.mail, e.niveau FROM eleve e INNER JOIN personne p ON e.ideleve = p.id");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Eleve e;




                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string adresse = (string)reader.GetValue(3);
                    string tel = (string)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);
                    int niveau = (int)reader.GetValue(6);

                    //Instanciation d'un EmplyeS
                    e = new Eleve(id, nom, prenom, adresse, tel, mail, niveau);

                    // Ajout de cet employe à la liste 
                    lc.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }


        public static bool isResultFound(Inscription i,Trim t)
        {
            bool resultFound = false;
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT * FROM `payer` WHERE IDPROF = @idProf AND IDELEVE = @idEleve AND NUMSEANCE = @numSeance AND libelle = @libelle");
                Ocom.Parameters.AddWithValue("@idProf", i.IdProf);
                Ocom.Parameters.AddWithValue("@idEleve", i.IdEleve);
                Ocom.Parameters.AddWithValue("@numSeance", i.NumSeance);
                Ocom.Parameters.AddWithValue("@libelle", t.Libelle);

                MySqlDataReader reader = Ocom.ExecuteReader();

                if (reader.Read())
                {
                    resultFound = true;
                }

                reader.Close();

                maConnexionSql.closeConnection();

                return resultFound;

            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }
        public static void deletePaiement(Inscription c)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("delete from payer where numseance = " + c.NumSeance+" and ideleve="+ c.IdEleve);

             



                int i = Ocom.ExecuteNonQuery();








                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        public static bool creerPaiement(Inscription inscription, string datePaiement,Trim t)
        {


            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                string req = "INSERT INTO `payer`(`IDPROF`, `IDELEVE`, `NUMSEANCE`, `LIBELLE`, `PAYE`, `DATEPAYEMENT`) VALUES (@idprof,@ideleve,@numseance,@libelle,@paye,@datePaiement)";
                Ocom2 = maConnexionSql.reqExec(req);

                Ocom2.Parameters.AddWithValue("@ideleve", inscription.IdEleve);
                Ocom2.Parameters.AddWithValue("@numseance", inscription.NumSeance);
                Ocom2.Parameters.AddWithValue("@idprof", inscription.IdProf);
                Ocom2.Parameters.AddWithValue("@libelle", t.Libelle);
                Ocom2.Parameters.AddWithValue("@paye", 1);
                Ocom2.Parameters.AddWithValue("@datePaiement", datePaiement);



                /*  Ocom.Parameters.AddWithValue("@instrument", instrument);
                  Ocom.Parameters.AddWithValue("@salaire", salaire);
               */

                int i = Ocom2.ExecuteNonQuery();






            }

            catch (Exception emp)
            {

                throw (emp);
            }




            maConnexionSql.closeConnection();

                return true;


            }

        public static bool verifPayment(Inscription i, Trim t)
        {


            bool payer = false;

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * FROM `payer` where ideleve=@ideleve and numseance=@numseance and libelle=@libelle");
                Ocom.Parameters.AddWithValue("@ideleve", i.IdEleve);
                Ocom.Parameters.AddWithValue("@numseance", i.NumSeance);
                Ocom.Parameters.AddWithValue("@libelle", t.Libelle);

                /*prevenir les injections sql */

                MySqlDataReader reader = Ocom.ExecuteReader();



                if (reader.HasRows)
                {
                    payer = true;
                }

                reader.Close();
                maConnexionSql.closeConnection();



            }
            catch (Exception emp)
            {

                throw (emp);

            }
            return payer;



        }
        public static bool modifPaiement(Inscription incr, Trim t, string datePaiement)
        {



            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("UPDATE `payer` SET `DATEPAYEMENT`=@datePaye WHERE idprof =@idprof and ideleve=@ideleve and numseance = @numseance and libelle =@libelle");
                  Ocom.Parameters.AddWithValue("@datePaye", datePaiement);
                     Ocom.Parameters.AddWithValue("@idprof", incr.IdProf);
                Ocom.Parameters.AddWithValue("@ideleve", incr.IdEleve);
                Ocom.Parameters.AddWithValue("@numseance", incr.NumSeance);
                Ocom.Parameters.AddWithValue("@libelle", t.Libelle);



                /*     Ocom.Parameters.AddWithValue("@prenom", prenom);
                     Ocom.Parameters.AddWithValue("@tel", tel);
                     Ocom.Parameters.AddWithValue("@mail", mail);
                     Ocom.Parameters.AddWithValue("@instrument", instrument);
                     Ocom.Parameters.AddWithValue("@salaire", salaire);
                  */

                MySqlDataReader reader = Ocom.ExecuteReader();










                reader.Close();

                maConnexionSql.closeConnection();

                return true;


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static PaiementClasse getPaie(Inscription i,Trim t)
        {

            PaiementClasse paye = null;

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT `IDPROF`, `IDELEVE`, `NUMSEANCE`, `LIBELLE`, `PAYE`, `DATEPAYEMENT` FROM `payer` WHERE idprof="+ i.IdProf+" and ideleve="+i.IdEleve+ " and numseance="+ i.NumSeance +" and libelle='"+t.Libelle+"'");

                MySqlDataReader reader = Ocom.ExecuteReader();

                




                while (reader.Read())
                {
                    int idprof = reader.GetInt32(0);
                    int ideleve = (int)reader.GetValue(1);
                    int numseance = (int)reader.GetValue(2);
                    string libelle = (string)reader.GetValue(3);
                    string datePaiement = (string)reader.GetValue(5);
                    

                    //Instanciation d'un EmplyeS
                    paye = new PaiementClasse(idprof, ideleve, numseance, libelle, datePaiement);


                    // Ajout de cet employe à la liste 


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return paye;



            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static List<Inscription> chargementInscriptionBDDFiltrer(Trim t)
        {
            List<Inscription> lI = new List<Inscription>();
            string date = t.DateFin;
            string[] dateParts = date.Split('/');
            string year = dateParts[2];
            

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT e.NOM as nomEleve, e.PRENOM as prenomEleve, i.IDELEVE, p.NOM as nomProf, p.PRENOM as prenomProf, i.IDPROF, i.NUMSEANCE, i.DATEINSCRIPTION FROM INSCRIPTION i JOIN ELEVE el ON i.IDELEVE = el.IDELEVE JOIN PERSONNE e ON el.IDELEVE = e.ID JOIN PROF pr ON i.IDPROF = pr.IDPROF JOIN PERSONNE p ON pr.IDPROF = p.ID where i.DATEINSCRIPTION LIKE '%" + year + "%' ");
                Ocom.Parameters.AddWithValue("@date", year);

                MySqlDataReader reader = Ocom.ExecuteReader();
                Inscription i;

                while (reader.Read())
                {
                    string nomEleve = (string)reader.GetValue(0);
                    string prenomEleve = (string)reader.GetValue(1);
                    int idEleve = (int)reader.GetValue(2);

                    string nomProf = (string)reader.GetValue(3);
                    string prenomProf = (string)reader.GetValue(4);
                    int idProf = (int)reader.GetValue(5);
                    int numSeance = (int)reader.GetValue(6);
                    string dateInscription = (string)reader.GetValue(7);

                    //Instanciation d'un Inscription

                    i = new Inscription(idProf, idEleve, numSeance, dateInscription, nomEleve, prenomEleve, nomProf, prenomProf);

                    // Ajout de cet Inscription à la liste 
                    lI.Add(i);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lI);
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }








    }




}

