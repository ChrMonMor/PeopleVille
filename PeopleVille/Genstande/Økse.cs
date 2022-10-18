using PeopleVille.Indbygger;
using PeopleVille.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Genstande
{
    internal class Økse : Genstande, IVåben, IVærktøj
    {
        public Økse(int id, string name, string description, float pris) : base(id, name, description, pris)
        {
        }


        string IVærktøj.KanBrugsHer => throw new NotImplementedException();

        float IVærktøj.Bonus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        float IVåben.Skade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IVåben.Angribe(Indbygger.Indbygger indbygger)
        {
            throw new NotImplementedException();
        }
    }
}
