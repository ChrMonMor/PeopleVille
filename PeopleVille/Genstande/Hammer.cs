using PeopleVille.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Genstande
{
    internal class Hammer : Genstande, IVærktøj
    {
        public Hammer(int id, string name, string description, float pris) : base(id, name, description, pris)
        {
        }


        string IVærktøj.KanBrugsHer => throw new NotImplementedException();

        float IVærktøj.Bonus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
