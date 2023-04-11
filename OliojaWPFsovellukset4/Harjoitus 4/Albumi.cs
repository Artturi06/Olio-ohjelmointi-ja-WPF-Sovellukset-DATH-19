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

        public List<Kappale> kappaleet { get; set; }


        

        

        public string AlbuminTulostus()
        {
            string Albumitiedot = "Albumi:\n-Artisti: " + Artisti + "\n-Nimi: " + Nimi + "\n-Genre: " + Genre + "\n-Hinta: " + hinta;
            Albumitiedot = Albumitiedot + "\nKappaleet:\n" + "---" + kappaleet[0].Nimi + " - " + kappaleet[0].Kesto + "\n";
            Albumitiedot = Albumitiedot + "\nKappaleet:\n" + "---" + kappaleet[1].Nimi + " - " + kappaleet[1].Kesto + "\n";
            Albumitiedot = Albumitiedot + "\nKappaleet:\n" + "---" + kappaleet[2].Nimi + " - " + kappaleet[2].Kesto + "\n";
            Albumitiedot = Albumitiedot + "\nKappaleet:\n" + "---" + kappaleet[3].Nimi + " - " + kappaleet[3].Kesto + "\n";
            Albumitiedot = Albumitiedot + "\nKappaleet:\n" + "---" + kappaleet[4].Nimi + " - " + kappaleet[4].Kesto + "\n";
            return Albumitiedot;
        }


        
     
    }
}
