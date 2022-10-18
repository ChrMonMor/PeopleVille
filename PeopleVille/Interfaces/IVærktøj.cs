using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Interfaces
{
    internal interface IVærktøj
    {
        string KanBrugsHer { get; }
        float Bonus { get; set; }

    }
}
