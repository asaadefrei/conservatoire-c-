using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Tranche
    {
        private string trancheHoraire;


        public Tranche(string tranche)
        {
            this.trancheHoraire = tranche;
        }

        public string TrancheHoraire { get => trancheHoraire; set => trancheHoraire = value; }

        public string Description
        {
            get => this.trancheHoraire;
        }
    }
}
