using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Cours
    {
        private string jour;
        private string tranche;
        private int capaciter;
        private int niveau;
        private int numSeance;
       

        public Cours(string unJour,string uneTranche, int uneCapaciter,int unNiveau,int numSeance)
        {

            this.jour = unJour; 
            this.tranche = uneTranche;
            this.capaciter = uneCapaciter;
            this.niveau = unNiveau;
            this.numSeance = numSeance;
            
        }
        public string Description
        {
            get =>  this.jour + " |  " + this.tranche + " |  niveau : " + this.niveau + " | capacite :" + this.capaciter;
        }
        public int NumSeance { get => numSeance; set => numSeance = value; }
        public string Jour { get => jour; set => jour = value; }
        public string Tranche { get => tranche; set => tranche = value; }
        public int Capaciter { get => capaciter; set => capaciter = value; }
        public int Niveau { get => niveau; set => niveau = value; }
    }
}
