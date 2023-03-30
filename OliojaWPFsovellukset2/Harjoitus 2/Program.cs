using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija OpiskelijaTiedot = new Opiskelija("Matti", 1, 200);
            Opiskelija Opiskelijatiedot2 = new Opiskelija("Taneli", 2, 180);




            Console.WriteLine(OpiskelijaTiedot.Oppilashaku1());
            Console.WriteLine(Opiskelijatiedot2.Oppilashaku2());
            
        }
    }
}
