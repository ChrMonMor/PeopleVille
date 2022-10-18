using PeopleVille.Lokalisation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVille
{
    internal class Program
    {

        static void Main(string[] args)
        {
            PeopleVille peopleVille = new PeopleVille();
            peopleVille.Start();
            peopleVille.PrintLog();
            Console.ReadLine();
        }
    } 
}
