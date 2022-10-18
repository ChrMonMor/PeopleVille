using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PeopleVille.Genstande;
using PeopleVille.Genstande.MadTyper;
using PeopleVille.Indbygger;
using PeopleVille.Interfaces;

namespace PeopleVille
{
    public class IndbyggerHR
    {
        public List<Indbygger.Indbygger> IndbyggerList;
        public List<Lokalisation.Lokalisation> LokalisationList;

        private int _ids = 0;
        public IndbyggerHR(List<Lokalisation.Lokalisation> lokalisations)
        {
            IndbyggerList = Indbyggers(lokalisations);
            LokalisationList = lokalisations;
        }


        public List<Indbygger.Indbygger> Indbyggers(List<Lokalisation.Lokalisation> lokalisations)
        {
            List<Indbygger.Indbygger> list = new List<Indbygger.Indbygger>();
            int i = 0;
            foreach (var item in lokalisations)
            {
                list.Add(new Indbygger.Indbygger(i, "menneske", RNG.Random(0, 100), lokalisations.Find(x => x is IHjem), lokalisations.Find(x => x is IArbejdeplads), lokalisations[RNG.Random(0, lokalisations.Count)], lokalisations[RNG.Random(0, lokalisations.Count)], RandGenstand()));
            }

            return list;
        }
        public void GåTil(Indbygger.Indbygger indbygger)
        {
            try
            {
                if (indbygger == null)
                    return;
                if (indbygger.GetMål() == indbygger.HerErJeg)
                {
                    indbygger.Log.Add("Allerede Hvor de gerne vil være");
                    return;
                }
                int[] nytFelt = new int[] { indbygger.HerErJeg.Postion[0], indbygger.HerErJeg.Postion[1], indbygger.HerErJeg.Postion[2] };
                for (int i = 0; i < nytFelt.Length; i++)
                {
                    if (indbygger.mål.Postion[i] < nytFelt[i])
                    {
                        nytFelt[i] = nytFelt[i] - 1;
                    }
                    else if (indbygger.mål.Postion[i] > nytFelt[i])
                    {
                        nytFelt[i] = nytFelt[i] + 1;
                    }
                }
                indbygger.HerErJeg = LokalisationList.Find(x => x.Postion.SequenceEqual(nytFelt));
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                indbygger.Log.Add(indbygger.Name+" gik hend til " + indbygger.HerErJeg.Navn+": Mål:"+ indbygger.GetMål().Navn);
            }
        }
        private Genstande.Genstande RandGenstand()
        {
            switch (RNG.Random(0, 10))
            {
                case 0:
                    _ids++;
                    return new Grønsag(_ids, "Gulrod", "Gul", 5.0f);
                case 1:
                    _ids++;
                    return new Æg(_ids, "Æg", "Fra en Høne", 5.0f);
                case 2:
                    _ids++;
                    return new Hammer(_ids, "Hammer", "Gul", 5.0f);
                case 3:
                    _ids++;
                    return new Kat(_ids, "Kat", "Gul", 5.0f);
                case 4:
                    _ids++;
                    return new Knive(_ids, "Knive", "Rød", 5.0f);
                case 5:
                    _ids++;
                    return new Rygsæk(_ids, "Rygsæk", "Brun", 5.0f);
                case 6:
                    _ids++;
                    return new Vin(_ids, "Gulrod", "Gul", 5.0f);
                case 7:
                    _ids++;
                    return new Kød(_ids, "Kød", "Rødt", 5.0f);
                case 8:
                    _ids++;
                    return new Hest(_ids, "Hest", "Gul", 5.0f);
                case 9:
                    _ids++;
                    return new Økse(_ids, "Økse", "Gul", 5.0f);
                default:
                    _ids++;
                    return null;
            }
        }
        public void KøbTing(Indbygger.Indbygger indbygger)
        {
            try
            {
                if (indbygger == null)
                    return;
                if (indbygger.GetMål() == indbygger.HerErJeg)
                {
                    if(Udbytte.IndByggerKøberIButik(indbygger, indbygger.mål))
                    {
                        indbygger.Log.Add(indbygger.Name + " Købt " + indbygger.MinTing.Name);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
