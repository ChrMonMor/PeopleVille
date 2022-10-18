using PeopleVille.Indbygger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Interfaces
{
    internal interface IArbejdeplads
    {
        Indbygger.Indbygger[] Arbejder { get; set; }
        float løn { get; }
        int ArbejdesTimer { get; set; }

        void FyreArbejder(Indbygger.Indbygger inbygger);
        void AnsætArbejder(Indbygger.Indbygger indbygger);

    }
}
