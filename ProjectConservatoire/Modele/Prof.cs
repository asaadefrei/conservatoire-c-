using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Prof : Personne
    {

        private string instrument;
        private float salaire;




        // Les nouveaux get et set version C# et VS.Net. Remplacent getLogin() et setLogin(string unLogin)


        // remplace getId()


        public Prof(int unId, string unNom, string unPrenom, string uneAdresse, string unTel, string unMail, string unInstrument, float unSalaire) :
            base(unId, unNom, unPrenom, uneAdresse, unTel, unMail)
        {


            this.instrument = unInstrument;
            this.salaire = unSalaire;
        }



        // Constructeur vide



        // pour afficher la liste par la suite
        public override string Description
        {
            get => base.Description + " | " + this.instrument;
        }
        public string Instrument { get => instrument; set => instrument = value; }
        public float Salaire { get => salaire; set => salaire = value; }
    }

}