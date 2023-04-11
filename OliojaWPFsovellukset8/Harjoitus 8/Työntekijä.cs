using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    public class Työntekijä : Henkilö
    {

        public float Työtunnit { get; set; }

        public string Työntekijäntulostus()
        {
            string Työntekijät = "Työntekijän nimi: " + Nimi + "\nTyöpaikka: " + Työpaikka + "\nPalkka: " + Palkka + "\nTyötunnit: " + Työtunnit + "\n";
            return Työntekijät;
        }
    }   
}
