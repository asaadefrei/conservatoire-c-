using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Eleve : Personne
    {
        
        private int niveau;
        private string dateInscription;

        public Eleve(int unId,string unNom,string unPrenom,string uneAdresse,string unTel,string unMail, int niv): base(unId, unNom, unPrenom, uneAdresse, unTel, unMail)
        {
            
            this.niveau=niv;

        }

        public override string Description
        {
            get => base.Description + this.niveau ;
        }
        public int Niveau { get => niveau; set => niveau = value; }
        public string DateInscription { get => dateInscription; set => dateInscription = value; }
    }
}
