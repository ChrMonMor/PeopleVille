using PeopleVille.Indbygger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Genstande
{
    public class Genstande
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Pris { get; set; }

        public string[] namelist = File.ReadLines("C:\\Users\\HFGF\\source\\repos\\OfficialPeopleVille\\PeopleVille\\PeopleVille\\extra\\animal.txt").Select(line => line).ToArray();

        protected Genstande(int id, string name, string description, float pris)
        {
            Id = id;
            Name = name;
            Description = description;
            Pris = pris;
        }

        public Genstande()
        {
        }
    }
}
