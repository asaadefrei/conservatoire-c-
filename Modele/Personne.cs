using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public abstract class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private string tel;
        private string adresse;
        private string mail;
        public Personne(int unId, string unNom, string unPrenom, string uneAdresse, string unTel, string unMail)
        {
            this.id = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.tel = unTel;
            this.adresse = uneAdresse;
            this.mail = unMail;
        }

        public virtual string Description
        {
            get => this.id + "@ -- Nom :" + this.nom + " | Prenom : " + this.prenom + " | tel : " + this.tel;
        }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
