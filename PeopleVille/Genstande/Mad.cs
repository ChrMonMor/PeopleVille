using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Genstande
{
    internal abstract class Mad : Genstande
    {
        public int KanHoldAntalDag;
        public bool Vegansk;

        public Mad(int id, int kanHoldAntalDag, bool vegansk, string name, string description, float pris) : base(id, name, description, pris)
        {
            KanHoldAntalDag = kanHoldAntalDag;
            Vegansk = vegansk;
        }

        public Mad(int id, string name, string description, float pris) : base(id, name, description, pris)
        {
        }
    }
}
