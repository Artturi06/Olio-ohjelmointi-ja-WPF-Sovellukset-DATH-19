using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    public class Joukkue
    {
        
        public string Jnimi { get; set; }
        public string Kotikaupunki { get; set; }
        private Dictionary<int,Pelaaja> Pelaajat { get; set;}


        


        public void Lisääpelaaja(string Enimi)
        {
            Pelaaja pelaaja1 = new Pelaaja(Enimi, "Taalasmaa", 1);
            Pelaajat.Add(pelaaja1.PelaajaNumero,pelaaja1);
        
        }
    }
}
