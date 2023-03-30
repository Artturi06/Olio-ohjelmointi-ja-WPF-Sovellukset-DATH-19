using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_1
{
    
    public class Vehilce
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }

        public string Haetiedot()
        {
            string Ajoneuvotiedot = "nimi: " + Nimi + ".  Nopeus: " + Nopeus.ToString() + ".  Renkaat: " + Renkaat.ToString();

            return Ajoneuvotiedot;
        }
    }




}
