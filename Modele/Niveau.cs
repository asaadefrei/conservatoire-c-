using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire.Modele
{
    public class Niveau
    {

        private int lvl;

        public Niveau(int unLvl)
        {
            this.lvl = unLvl;

        }
        public string Description
        {
            get => this.lvl.ToString();
        }

        public int Lvl { get => lvl; set => lvl = value; }
    }
}
