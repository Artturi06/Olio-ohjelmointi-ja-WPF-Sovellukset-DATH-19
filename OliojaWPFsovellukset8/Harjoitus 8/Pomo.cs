using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    public class Pomo : Henkilö
    {
        public float Boonus { get; set; }

        public string Auto { get; set; }
        
        public static int Pomojenmäärä = 0;

        public Pomo()
        {
            Pomojenmäärä++;
        }

        public string Pomontulostus()
        {
            string Pomontiedot = "Nimi: " + Nimi + "\nTyöpaikka: " + Työpaikka + "\nPalkka: " + Palkka + "\nBoonus: " + Boonus + "\nAuto: " + Auto + "\n";
            return Pomontiedot; 
        }


        
        
    }
}
