using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille
{
    internal class LokalisationHR
    {
        public List<Lokalisation.Lokalisation> LokalisationList;

        public LokalisationHR()
        {
            LokalisationList = Lokalisations();
        }

        public static List<Lokalisation.Lokalisation> Lokalisations()
        {
            List<Lokalisation.Lokalisation> list = new List<Lokalisation.Lokalisation>();
            int i = 0;
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    i++;
                    switch (RNG.Random(0, 5))
                    {
                        case 0:
                            list.Add(new Lokalisation.Bank(i,new int[] {x, y, 0}, " Bank", 0));
                            break;
                        case 1:
                            list.Add(new Lokalisation.Dagligbruds(i, new int[] { x, y, 0 }, " Dagligbruds", 0));
                            break;
                        case 2:
                            list.Add(new Lokalisation.Lejlighed(i, new int[] { x, y, 0 }, " Lejlighed", 0));
                            break;
                        case 3:
                            list.Add(new Lokalisation.Byggeplads(i, new int[] { x, y, 0 }, " Byggeplads", 0));
                            break;
                        case 4:
                            list.Add(new Lokalisation.Bar(i, new int[] { x, y, 0 }, " Bar", 0));
                            break;
                        default:
                            list.Add(new Lokalisation.Vej(i, new int[] { x, y, 0 }, " Vej", 0));
                            break;
                    }
                }
            }
            return list;
        }
    }
}
