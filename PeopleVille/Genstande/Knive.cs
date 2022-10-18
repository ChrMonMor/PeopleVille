using PeopleVille.Indbygger;
using PeopleVille.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Genstande
{
    internal class Knive : Genstande, IVåben
    {
        public Knive(int id, string name, string description, float pris) : base(id, name, description, pris)
        {
        }
        float IVåben.Skade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IVåben.Angribe(Indbygger.Indbygger indbygger)
        {
            throw new NotImplementedException();
        }
    }
}
