using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9_osa1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.Virta = false;
            radio.Äänenvoimakkuus = 2;
            radio.Taajuus = 94.6;
            string Taajuusvastaus;
            string Äänivastaus;
            
            string vastaus = " ";
            while(vastaus != "Lopeta")
            {
                Console.WriteLine("Komennot: \nPoistu\nVirta\nÄänenvoimakkuus\nTaajuus\n:  ");
                vastaus = Console.ReadLine();

                if(vastaus == "Poistu")
                {
                    Console.WriteLine("Heippa!");
                    break;
                }
                else if(vastaus == "Virta")
                {
                    if(radio.Virta == false)
                    {
                        radio.Virta = true;
                        Console.WriteLine("Radio on nyt päällä.");
                    }
                    else
                    {
                        radio.Virta = false;
                        Console.WriteLine("Radio on nyt pois päältä.");
                    }
                   
                }
                else if(vastaus == "Äänenvoimakkuus")
                {
                    Console.WriteLine("ÄÄnenvoimakkuus on nyt " + radio.Äänenvoimakkuus + ".\nKirjoita uusi äänenvoimakkuus:  ");
                    Äänivastaus = Console.ReadLine();
                    radio.Äänenvoimakkuus = Convert.ToInt32(Äänivastaus);
                    Console.WriteLine("Vaihdoit äänenvoimakkuudeksi:  " + radio.Äänenvoimakkuus);
                        
                }
                else if (vastaus == "Taajuus")
                {
                    Console.WriteLine("Taajuus on nyt " + radio.Taajuus + ".\nKirjoita uusi taajuus:  ");
                    Taajuusvastaus = Console.ReadLine();    
                    radio.Taajuus = Convert.ToDouble(Taajuusvastaus);
                    Console.WriteLine("Vaihdoit taajuudeksi:  " + radio.Taajuus);
                }
                else
                {
                    Console.WriteLine("Tuollaista komentoa ei ole! Yritä uudelleen:  ");
                }

                
            }
            
        }
    }
}