using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Interfaces
{
    internal interface IButik
    {
        float Kassen { get; set; }
        string[] Vare { get; set; }
        int[] AntalPåLager { get; set; }


    }
}
