using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    public static class Program
    {
        static void Main(string[] args)
        {
         
            Joukkue Joukkue1 = new Joukkue();



            Joukkue1.Jnimi = "Ketut";
            Joukkue1.Kotikaupunki = "Turku";
            Joukkue1.Lisääpelaaja("Matti");


            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            Console.WriteLine("Lisää uusi pelaaja antamalla seuraavat tiedot: \n");
            Console.WriteLine("Etunimi: ");
            string Etunimi = Console.ReadLine();
            Console.WriteLine("Sukunimi: ");
            string Sukunimi = Console.ReadLine();
            Console.WriteLine("Pelaajanumero: ");
            int Pelaajanumero = int.Parse(Console.ReadLine());

            
        }
    }
}