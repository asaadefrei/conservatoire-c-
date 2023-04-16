using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Trim
    {
        private string libelle;
        private string dateFin;

        public Trim(string libelle, string dateFin)
        {
            this.libelle = libelle;
            this.dateFin = dateFin;
        }

        public string Description
        {
            get => this.libelle + " | " + this.dateFin;
        }
        public string DateFin { get => dateFin; set => dateFin = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
