using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_2
{
    internal class Opiskelija
    {
        public string Nimi { get; set; }
        public int OppID { get; set; }
        public int Opintopisteet { get; set; }




        public Opiskelija(string _nimi, int _Oppid, int _Opintopisteet)
        {
            Nimi = _nimi;
            OppID = _Oppid;
            Opintopisteet = _Opintopisteet;
        }

        public string Oppilashaku1()
        {
            string Oppilas = "Nimi: " + Nimi + ".  OppID: " + OppID.ToString() + ".  Opintopisteet: " + Opintopisteet.ToString();
            
            return Oppilas;
        }

        public string Oppilashaku2()
        {
            string Oppilas1 = "Nimi: " + Nimi + ".  OppID: " + OppID.ToString() + ".  Opintopisteet: " + Opintopisteet.ToString();

            return Oppilas1;
        }


    }
}
