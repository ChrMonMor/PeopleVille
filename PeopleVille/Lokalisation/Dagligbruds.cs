using PeopleVille.Indbygger;
using PeopleVille.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Lokalisation
{
    internal class Dagligbruds : Lokalisation, IButik, IArbejdeplads
    {
        public Dagligbruds(int id, int[] postion, string navn, int antalHerNu) : base(id, postion, antalHerNu)
        {
            Navn += navn;
        }
        public Dagligbruds() { }

        Indbygger.Indbygger[] IArbejdeplads.Arbejder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        float IArbejdeplads.løn => throw new NotImplementedException();

        public float Kassen { get => 500.0f; set => Kassen = value; }
        public string[] Vare { get => new string[] { "Kød", "Vand", "Vin", "Øl" }; set => Vare = value; }
        public int[] AntalPåLager { get => new int[] { 20, 20, 20, 20 }; set => AntalPåLager = value; }
        public int ArbejdesTimer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
