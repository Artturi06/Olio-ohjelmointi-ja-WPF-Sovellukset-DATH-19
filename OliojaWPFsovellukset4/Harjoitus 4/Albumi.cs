using Harhoitus_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4
{
    internal class Albumi
    {
        public string Artisti { get; set; }
        public string Genre { get; set; }
        public int hinta { get; set; }
        public string Nimi { get; set; }

        List<Kappale> kappaleet { get; set; }


        public Albumi(string _Artisti, string _Nimi, string _Genre, int _hinta)
        {
            Artisti = _Artisti;
            Nimi = _Nimi;
            Genre = _Genre;
            hinta = _hinta;
            kappaleet= new List<Kappale>();  
        }


        
     
    }
}
