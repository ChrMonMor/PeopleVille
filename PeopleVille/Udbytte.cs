using PeopleVille.Interfaces;
using PeopleVille.Lokalisation;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille
{
    public static class Udbytte
    {
        static Bank bank = new Bank();
        static Bar bar = new Bar();
        static Byggeplads byggeplads = new Byggeplads();
        static Dagligbruds dagligbruds = new Dagligbruds();
        static DyrButik dyrButik = new DyrButik();
        static Grønttorv grønttorv = new Grønttorv();
        static Hus hus = new Hus();
        static HvidevareButik hvidevareButik = new HvidevareButik();
        static Lejlighed lejlighed = new Lejlighed();
        static Lokalisation.Lokalisation lokalisation = new Lokalisation.Lokalisation();
        static Smed smed = new Smed();
        static Vej vej = new Vej();
        public static bool IndByggerKøberIButik(Indbygger.Indbygger indbygger, Lokalisation.Lokalisation lokalisation)
        {
            if(lokalisation is IButik)
            {
                int i = 0;
                switch (lokalisation.GetType().Name)
                {
                    case "Bar":
                        i = RNG.Random(0, bar.Vare.Length);
                        if (indbygger.GetPenge() < 5.0f)
                            break;
                        indbygger.MinTing = NyTingFind(bar.Vare[i]);
                        indbygger.SetPenge(indbygger.GetPenge() - 5.0f);
                        return true;
                    case "Dagligbruds":
                        i = RNG.Random(0, dagligbruds.Vare.Length);
                        if (indbygger.GetPenge() < 5.0f)
                            break;
                        indbygger.MinTing = NyTingFind(dagligbruds.Vare[i]);
                        indbygger.SetPenge(indbygger.GetPenge() - 5.0f);
                        return true;
                    case "DyrButik":
                        i = RNG.Random(0, dyrButik.Vare.Length);
                        if (indbygger.GetPenge() < 5.0f)
                            break;
                        indbygger.MinTing = NyTingFind(dyrButik.Vare[i]);
                        indbygger.SetPenge(indbygger.GetPenge() - 5.0f);
                        return true;
                    case "Grønttorv":
                        i = RNG.Random(0, grønttorv.Vare.Length);
                        if (indbygger.GetPenge() < 5.0f)
                            break;
                        indbygger.MinTing = NyTingFind(grønttorv.Vare[i]);
                        indbygger.SetPenge(indbygger.GetPenge() - 5.0f);
                        return true;
                    case "HvidevareButik":
                        i = RNG.Random(0, hvidevareButik.Vare.Length);
                        if (indbygger.GetPenge() < 5.0f)
                            break;
                        indbygger.MinTing = NyTingFind(hvidevareButik.Vare[i]);
                        indbygger.SetPenge(indbygger.GetPenge() - 5.0f);
                        return true;
                    case "Smed":
                        i = RNG.Random(0, smed.Vare.Length);
                        if (indbygger.GetPenge() < 5.0f)
                            break;
                        indbygger.MinTing = NyTingFind(smed.Vare[i]);
                        indbygger.SetPenge(indbygger.GetPenge() - 5.0f);
                        return true;
                    default:
                        return false;
                }
                return false;
            }
            return false;
        }
        static private Genstande.Genstande NyTingFind(string ting)
        {
            switch (ting)
            {
                case "Kød":
                    return new Genstande.MadTyper.Kød(-1, "Kød", "fra dyr", 5.0f);
                case "Vand":
                    return new Genstande.Vand(-1, "Vand", "fra hanen", 5.0f);
                case "Vin":
                    return new Genstande.Vin(-1, "Vin", "fra druen", 5.0f);
                case "Øl":
                    return new Genstande.Vand(-1, "Øl", "fra tønnen", 5.0f);
                default:
                    return null;
            }
        }
        static public void BytByt(Indbygger.Indbygger ib1, Indbygger.Indbygger ib2)
        {
            (ib2.MinTing, ib1.MinTing) = (ib1.MinTing, ib2.MinTing);
        }
    }
}
