using PeopleVille.Indbygger;
using PeopleVille.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Lokalisation
{
    internal class Lejlighed : Lokalisation, IHjem
    {
        public Lejlighed(int id, int[] postion, string navn, int antalHerNu) : base(id, postion, antalHerNu)
        {
            Navn += navn;
        }
        public Lejlighed() { }
        Indbygger.Indbygger[] IHjem.HerBor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        float IHjem.Pris { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IHjem.FlytInd(Indbygger.Indbygger indbygger)
        {
            throw new NotImplementedException();
        }

        void IHjem.FlytVæk(Indbygger.Indbygger indbygger)
        {
            throw new NotImplementedException();
        }
    }
}
