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

            Kanava Kanava1= new Kanava();
            Kanava1.Nimi = "Jouluradio";
            Kanava1.Taajuus = 90.0;
            Kanava Kanava2= new Kanava();
            Kanava2.Nimi = "Jumpparadio";
            Kanava2.Taajuus = 95.0;

            Kanava Kanava3 = new Kanava();
            Kanava3.Nimi = "Marttakerho";
            Kanava3.Taajuus = 100.0;


            


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

                    if(radio.Taajuus == Kanava1.Taajuus)
                    {
                        Console.WriteLine(" eli " + Kanava1.Nimi);
                        
                    }
                    else if(radio.Taajuus == Kanava2.Taajuus)
                    {
                        Console.WriteLine(" eli " + Kanava2.Nimi);
                    }
                    else if(radio.Taajuus == Kanava3.Taajuus)
                    {
                        Console.WriteLine(" eli " + Kanava3.Nimi);
                    }
                    else
                    {
                        Console.WriteLine(" Tällä taajuudella ei ole kanavaa.");
                    }
                }
                else
                {
                    Console.WriteLine("Tuollaista komentoa ei ole! Yritä uudelleen:  ");
                }

                
            }
            
        }
    }
}