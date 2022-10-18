using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Lokalisation
{
    public class Lokalisation
    {
        public string[] namelist = File.ReadLines("C:\\Users\\HFGF\\source\\repos\\OfficialPeopleVille\\PeopleVille\\PeopleVille\\extra\\places.txt").Select(line => line).ToArray();
        public int Id;
        public int[] Postion;
        public string Navn;
        public int AntalHerNu;

        public Lokalisation(int id, int[] postion, int antalHerNu)
        {
            Id = id;
            Postion = postion;
            Navn = namelist[RNG.Random(0,namelist.Length)];
            AntalHerNu = antalHerNu;
        }
        public Lokalisation() { }

        public static int[] GetPos(Lokalisation lokalisation)
        {
            return lokalisation.Postion;
        }
    }
}
