using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_3
{
    internal class Kiuas
    {
        public string Virta { get; set; }
        public int Lampotila { get; set; }
        public int Kosteusarvo { get; set; }


        public Kiuas(string _Virta, int _lampotila, int _kosteusarvo)
        {
            Virta= _Virta;
            Lampotila = _lampotila;
            Kosteusarvo= _kosteusarvo;
        }



        public string KiukaanTiedot()
        {
            string KiuasTiedot = ("Tila: " + Virta + ".  Lampotila: " + Lampotila + ".  Kosteusarvo: " + Kosteusarvo + "%");
            
            return KiuasTiedot;
        }
    }
}
