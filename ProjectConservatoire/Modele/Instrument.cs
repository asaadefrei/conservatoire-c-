using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Instrument
    {
        private string libelle;


        public Instrument(string unLibelle)
        {

            this.libelle = unLibelle;
        }

        public string Libelle { get => libelle; set => libelle = value; }


        public string Description
        {
            get => this.libelle;
        }
    }
}
