using PeopleVille.Indbygger;
using PeopleVille.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Lokalisation
{
    internal class Bank : Lokalisation, IArbejdeplads
    {
        public Bank(int id, int[] postion, string navn, int antalHerNu) : base(id, postion, antalHerNu)
        {
            Navn += navn;
        }
        public Bank() { }
        Indbygger.Indbygger[] IArbejdeplads.Arbejder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        float IArbejdeplads.løn => throw new NotImplementedException();

        int IArbejdeplads.ArbejdesTimer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IArbejdeplads.AnsætArbejder(Indbygger.Indbygger indbygger)
        {
            throw new NotImplementedException();
        }

        void IArbejdeplads.FyreArbejder(Indbygger.Indbygger inbygger)
        {
            throw new NotImplementedException();
        }
    }
}
