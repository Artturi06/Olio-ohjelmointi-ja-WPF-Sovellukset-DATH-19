using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4
{
    public class Kappale
    {
        public string Nimi { get; set; }
        public string Kesto { get; set; }


        


        public string BiisinTulostus()
        {
            string Biisi = "-Nimi: " + Nimi + " - " + Kesto + "\n";
            return Biisi;
        }
    }
}
