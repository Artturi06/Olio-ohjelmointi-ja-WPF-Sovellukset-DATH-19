using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_12
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Kortti> Kortit = new List<Kortti>();


            
            for (int i = 1; i <= 13; i++)
            {
                Kortit.Add(new Kortti("Pata", i));

            }

            for (int i = 1; i <= 13; i++)
            {
                Kortit.Add(new Kortti("Risti", i));

            }

            for (int i = 1; i <= 13; i++)
            {
                Kortit.Add(new Kortti("Ruutu", i));

            }

            for (int i = 1; i <= 13; i++)
            {
                Kortit.Add(new Kortti("Hertta", i));

            }

            int Rivinumero = 0;

            Console.WriteLine("Tässä Korttisi: \n");
            foreach(Kortti k in Kortit)
            {
                Rivinumero++;
                Console.WriteLine(Rivinumero + ". " + k.Maa + " - " + k.Numero);
            }

            

            Console.WriteLine("Kortit sekoitettiin: \n");
            foreach (Kortti k in Kortit)
            {
                Rivinumero++;
                Console.WriteLine(Rivinumero + ". " + k.Maa + " - " + k.Numero);
            }


        }

       
    }
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        Random rnd = new Random();
        while (n > 1)
        {
            int k = (rnd.Next(0, n) % n);
            n--;
            T value = list[k];
            list[k] = list[n];
            list[n] = value;


        }
    }



}
