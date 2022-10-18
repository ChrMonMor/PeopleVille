using PeopleVille.Genstande;
using PeopleVille.Genstande.MadTyper;
using PeopleVille.Interfaces;
using PeopleVille.Lokalisation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille
{
    public class GenstandHR
    {
        public List<Genstande.Genstande> Genstande;
        private int Ids = 0;
        public GenstandHR()
        {
        }

        public GenstandHR(List<Lokalisation.Lokalisation> lokalisations, List<Indbygger.Indbygger> indbyggers)
        {
            Genstande = Genstandes(lokalisations, indbyggers);
        }
        public List<Genstande.Genstande> Genstandes(List<Lokalisation.Lokalisation> lokalisations, List<Indbygger.Indbygger> indbyggers)
        {
            List<Genstande.Genstande> list = new List<Genstande.Genstande>();
            foreach (var item in lokalisations)
            {
                if (item is IButik)
                {
                    if (item is Dagligbruds)
                    {
                        list.Add(RandGenstand());
                    }
                    else if (item is Bar)
                    {
                        list.Add(RandGenstand());
                    } 
                    else
                    {
                        list.Add(new Genstande.Genstande());
                    }
                }
            }
            return list;
        }
        public Genstande.Genstande RandGenstand()
        {
            switch (RNG.Random(0, 10))
            {
                case 0:
                    Ids++;
                    return new Grønsag(Ids,"Gulrod","Gul",5.0f);
                case 1:
                    Ids++;
                    return new Æg(Ids, "Æg", "Fra en Høne", 5.0f);
                case 2:
                    Ids++;
                    return new Hammer(Ids, "Hammer", "Gul", 5.0f);
                case 3:
                    Ids++;
                    return new Kat(Ids, "Kat", "Gul", 5.0f);
                case 4:
                    Ids++;
                    return new Knive(Ids, "Knive", "Rød", 5.0f);
                case 5:
                    Ids++;
                    return new Rygsæk(Ids, "Rygsæk", "Brun", 5.0f);
                case 6:
                    Ids++;
                    return new Vin(Ids, "Gulrod", "Gul", 5.0f);
                case 7:
                    Ids++;
                    return new Kød(Ids, "Kød", "Rødt", 5.0f);
                case 8:
                    Ids++;
                    return new Hest(Ids, "Hest", "Gul", 5.0f);
                case 9:
                    Ids++;
                    return new Økse(Ids, "Økse", "Gul", 5.0f);
                default:
                    Ids++;
                    return null;
            }
        }
    }
}
