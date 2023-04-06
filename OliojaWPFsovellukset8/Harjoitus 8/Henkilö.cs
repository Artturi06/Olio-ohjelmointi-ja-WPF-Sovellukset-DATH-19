using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    public abstract class Henkilö
    {
        public string Nimi { get; set; }
        public string Työpaikka { get; set; }  

        public int Palkka { get; set; }

        public static void Henkilöidentulostus()
        {
            
        }


    }
}
