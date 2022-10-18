using PeopleVille.Interfaces;
using PeopleVille.Lokalisation;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PeopleVille.Indbygger
{
    enum Kønene
    {
        Mand,
        Kvinde,
        Intet
    }
    public class Indbygger
    {
        public string[] namelist = File.ReadLines("C:\\Users\\HFGF\\source\\repos\\OfficialPeopleVille\\PeopleVille\\PeopleVille\\extra\\names.txt").Select(line => line).ToArray();
        private string[] Kønene = new string[] {"Mand","Kvinde","Intet"};
        public int Id;
        public string Name;
        public string Description;
        private float penge;

        public float GetPenge()
        {
            return penge;
        }

        public void SetPenge(float value)
        {
            penge = value;
        }

        public Lokalisation.Lokalisation Hjem;
        public Lokalisation.Lokalisation Arbejde;
        public Lokalisation.Lokalisation HerErJeg;
        public Lokalisation.Lokalisation mål;

        public Lokalisation.Lokalisation GetMål()
        {
            return mål;
        }

        public void SetMål(Lokalisation.Lokalisation value)
        {
            mål = value;
        }

        protected string Køn;
        public Genstande.Genstande MinTing; 
        public List<string> Log;

        public Indbygger(int id, string description, float penge, Lokalisation.Lokalisation hjem, Lokalisation.Lokalisation arbejde, Lokalisation.Lokalisation herErJeg, Lokalisation.Lokalisation mål, Genstande.Genstande minTing)
        {
            Id = id;
            Name = namelist[RNG.Random(1, namelist.Length)];
            Description = description;
            SetPenge(penge);
            Hjem = hjem;
            Arbejde = arbejde;
            HerErJeg = herErJeg;
            SetMål(mål);
            Køn = Kønene[RNG.Random(0, Kønene.Length)];
            Log = new List<string>();
            MinTing = minTing;
        }
        public Indbygger(){}
    }
}