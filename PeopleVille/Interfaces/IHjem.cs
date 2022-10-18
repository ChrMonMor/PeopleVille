using PeopleVille.Indbygger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Interfaces
{
    internal interface IHjem
    {
        Indbygger.Indbygger[] HerBor { get; set; }
        float Pris { get; set; }


        void FlytVæk(Indbygger.Indbygger indbygger);
        void FlytInd(Indbygger.Indbygger indbygger);

    }
}
