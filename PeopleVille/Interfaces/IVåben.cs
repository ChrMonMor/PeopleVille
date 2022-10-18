using PeopleVille.Indbygger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille.Interfaces
{
    internal interface IVåben
    {
        float Skade { get; set; }
        
        void Angribe(Indbygger.Indbygger indbygger);
    }
}
