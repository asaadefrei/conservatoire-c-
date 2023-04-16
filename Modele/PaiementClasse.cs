using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class PaiementClasse
    {
        private int idProf;
        private int numSeance;
        private int idEleve;
        private string libelle;
        private string datePaiement;

        public PaiementClasse(int idProf, int idEleve,int numSeance, string libelle, string datePaiement)
        {


            this.idProf = idProf;
            this.numSeance = numSeance;
            this.idEleve = idEleve;
            this.libelle = libelle;
            this.datePaiement = datePaiement;
        }

        public string DatePaiement { get => datePaiement; set => datePaiement = value; }
    }
}
