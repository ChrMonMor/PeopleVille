using PeopleVille.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PeopleVille.Genstande
{
    internal class Øl : Genstande, IDrikkelse
    {
        public Øl(int id, string name, string description, float pris) : base(id, name, description, pris)
        {
        }
        public Øl() 
        {
            Id = 1;
            Name = namelist[RNG.Random(0, namelist.Length)];
            Description = "Plisner";
            Pris = 10f;
        }

        float IDrikkelse.ALC => 4.5f;
    }
}
