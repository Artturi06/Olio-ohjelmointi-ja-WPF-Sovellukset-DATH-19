using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if(Pomo.Pomojenmäärä == 0)
            {
                Pomo Petri = new Pomo();
                Petri.Nimi = "Petri";
                Petri.Työpaikka = "Nokia";
                Petri.Palkka = 20000;
                Petri.Auto = "Mersu";
                Petri.Boonus = 500000;

                Console.WriteLine(Petri.Pomontulostus());

              
                

            }
            else
            {
                Console.WriteLine("Pomo on jo olemassa");
            }



            
           

            Työntekijä Hannu = new Työntekijä();
            Hannu.Nimi = "Hannu";
            Hannu.Työpaikka = "Nokia";
            Hannu.Palkka = 5000;
            Hannu.Työtunnit = 40;

            Console.WriteLine(Hannu.Työntekijäntulostus());

            Työntekijä Kerttu = new Työntekijä();
            Kerttu.Nimi = "Kerttu";
            Kerttu.Työpaikka = "Nokia";
            Kerttu.Palkka = 2000;
            Kerttu.Työtunnit = 35;

            Console.WriteLine(Kerttu.Työntekijäntulostus());
           
            Työntekijä Paavo = new Työntekijä();
            Paavo.Nimi = "Paavo";
            Paavo.Työpaikka = "Nokia";
            Paavo.Palkka = 7500;
            Paavo.Työtunnit = 38;

            Console.WriteLine(Paavo.Työntekijäntulostus());


            if (Pomo.Pomojenmäärä == 0)
            {
                Pomo Jukka = new Pomo();
                Jukka.Nimi = "Petri";
                Jukka.Työpaikka = "Nokia";
                Jukka.Palkka = 20000;
                Jukka.Auto = "Mersu";
                Jukka.Boonus = 500000;
            }
            else
            {
                Console.WriteLine("Pomo on jo olemassa");
            }




        }
    }
}

