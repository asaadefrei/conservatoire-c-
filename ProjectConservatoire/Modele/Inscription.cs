using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Conservatoire.Modele
{
    public class Inscription
    {
        int idProf;
        int idEleve;
        int numSeance;
        string dateInscription;
        string nomEleve;
        string prenomEleve;
        string nomProf;
        string prenomProf;

        public Inscription(int idProf,int idEleve,int numSeance, string dateInscription, string nomEleve, string prenomEleve, string nomProf, string prenomProf)
        {





            this.idProf = idProf;
            this.idEleve = idEleve;
            this.numSeance = numSeance; 
            this.dateInscription = dateInscription;
            this.nomEleve = nomEleve;
            this.prenomEleve = prenomEleve;
            this.prenomProf = prenomProf;
            this.nomProf = nomProf;
        }
        public string Description
        {
            get => "eleve :"+this.nomEleve + " " + this.prenomEleve + " | prof :"+ this.nomProf + " "+ this.prenomProf +"| date Inscription : "+ this.dateInscription;
        }
        public int IdProf { get => idProf; set => idProf = value; }
        public int IdEleve { get => idEleve; set => idEleve = value; }
        public int NumSeance { get => numSeance; set => numSeance = value; }
        public string DateInscription { get => dateInscription; set => dateInscription = value; }
        public string NomEleve { get => nomEleve; set => nomEleve = value; }
        public string PrenomEleve { get => prenomEleve; set => prenomEleve = value; }
        public string NomProf { get => nomProf; set => nomProf = value; }
        public string PrenomProf { get => prenomProf; set => prenomProf = value; }
    }
}
