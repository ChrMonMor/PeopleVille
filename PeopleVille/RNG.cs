using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille
{
    internal static class RNG
    {
        private static Random _random = new Random();
        public static int Random(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
