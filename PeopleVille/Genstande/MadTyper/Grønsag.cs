using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Genstande.MadTyper
{
    internal class Grønsag : Mad
    {
        public Grønsag(int id, string name, string description, float pris) : base(id, name, description, pris)
        {
        }

        public Grønsag(int id, int kanHoldAntalDag, bool vegansk, string name, string description, float pris) : base(id, kanHoldAntalDag, vegansk, name, description, pris)
        {
        }
    }
}
