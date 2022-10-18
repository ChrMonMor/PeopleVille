using PeopleVille.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Genstande
{
    internal class Vand : Genstande, IDrikkelse
    {
        public Vand(int id, string name, string description, float pris) : base(id, name, description, pris)
        {
        }

        float IDrikkelse.ALC => throw new NotImplementedException();
    }
}
