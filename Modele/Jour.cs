using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Jour
    {

        private string journee;

        public Jour(string uneJournée)
        {

            this.journee = uneJournée;



        }
        public string Description
        {
            get => this.journee;
        }

        public string Journee { get => journee; set => journee = value; }
    }
}
