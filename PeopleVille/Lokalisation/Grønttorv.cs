using PeopleVille.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Lokalisation
{
    internal class Grønttorv : Lokalisation, IButik
    {
        public Grønttorv(int id, int[] postion, string navn, int antalHerNu) : base(id, postion, antalHerNu)
        {
            Navn += navn;
        }
        public Grønttorv() { }
        public float Kassen { get => 500.0f; set => Kassen = value; }
        public string[] Vare { get => new string[] { "Grønsag", "Vand", "Vin", "Øl" }; set => Vare = value; }
        public int[] AntalPåLager { get => new int[] { 20, 20, 20, 20 }; set => AntalPåLager = value; }
    }
}
