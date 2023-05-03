using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    public class Pelaaja: Joukkue
    {
        public string Enimi { get; set; }
        public string Snimi { get; set; }  
        public int PelaajaNumero { get; set; }

        public Pelaaja(string _enimi, string _snimi, int _pelaajanumero)
        {
            Enimi = _enimi;
            Snimi = _snimi;
            PelaajaNumero = _pelaajanumero;
        }


    }
}
