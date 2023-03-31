using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas1 = new Kiuas("Päällä", 80, 90 );

            Console.WriteLine(kiuas1.KiukaanTiedot());

            kiuas1.Virta = "Pois";
            kiuas1.Lampotila = 100;
            kiuas1.Kosteusarvo = 95;

            Console.WriteLine(kiuas1.KiukaanTiedot());
            

        }

        
    }
}
