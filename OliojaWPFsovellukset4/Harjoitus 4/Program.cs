using Harjoitus_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harhoitus_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi album1= new Albumi();

            album1.Artisti = "Gettomasa";
            album1.Nimi = "Masa";
            album1.Genre = "rap";
            album1.hinta = 15;

            Kappale biisi1= new Kappale();
            biisi1.Nimi = "Silmät";
            biisi1.Kesto = "4:01";

            Kappale biisi2 = new Kappale();
            biisi2.Nimi = "Vastustamaton";
            biisi2.Kesto = "3:40";

            Kappale biisi3 = new Kappale();
            biisi3.Nimi = "Muijii stadis";
            biisi3.Kesto = "5:02";

            Kappale biisi4 = new Kappale();
            biisi4.Nimi = "Höllikse";
            biisi4.Kesto = "3:39";

            Kappale biisi5 = new Kappale();
            biisi5.Nimi = "Hyvä me";
            biisi5.Kesto = "3:09";


            album1.kappaleet.Add(biisi1);
            album1.kappaleet.Add(biisi2);
            album1.kappaleet.Add(biisi3);
            album1.kappaleet.Add(biisi4);
            album1.kappaleet.Add(biisi5);


            Console.WriteLine(album1.AlbuminTulostus());






        }
    }
}