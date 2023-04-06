using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4
{
    internal class Kappale
    {
        public string Nimi { get; set; }
        public string Kesto { get; set; }


        public static void BiisinTulostus()
        {
            Console.Write("--- Nimi: " + Nimi + " - " + Kesto);        
        }
    }
}
