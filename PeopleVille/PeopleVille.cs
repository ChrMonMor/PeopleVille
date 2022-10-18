using PeopleVille.Indbygger;
using PeopleVille.Lokalisation;
using PeopleVille.Genstande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleVille.Interfaces;
using System.Reflection;

namespace PeopleVille
{
    internal class PeopleVille
    {
        public  GenstandHR GenstandHR;
        public  IndbyggerHR IndbyggerHR;
        public  LokalisationHR LokalisationHR;

        public PeopleVille()
        {
            LokalisationHR = new LokalisationHR();
            IndbyggerHR = new IndbyggerHR(LokalisationHR.LokalisationList);
            GenstandHR = new GenstandHR(LokalisationHR.LokalisationList, IndbyggerHR.IndbyggerList);
        }

        public  void Start()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in IndbyggerHR.IndbyggerList)
                {
                    IndbyggerHR.GåTil(item);
                }
            }
            foreach (var item in IndbyggerHR.IndbyggerList)
            {
                IndbyggerHR.KøbTing(item);
            }

        }
        public void PrintLog()
        {
            foreach (var item in IndbyggerHR.IndbyggerList)
            {
                foreach (var x in item.Log)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
