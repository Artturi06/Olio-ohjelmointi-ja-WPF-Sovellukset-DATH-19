using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus14
{
    class program
    {
        static void Main(string[] args)
        {
            Olio olio = new Olio("muistiinpanot.txt");

            while (true)
            {
                Console.WriteLine("Valitse toiminto: (1) Uusi muistiinpano, (2) Tulosta muistiinpanot, (3) Tyhjennä muistiinpanot, (4) Lopeta");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        olio.CreateNote();
                        break;
                    case "2":
                        olio.PrintNotes();
                        break;
                    case "3":
                        olio.ClearNotes();
                        break;
                    case "4":
                        Console.WriteLine("Ohjelma suljetaan.");
                        return;
                    default:
                        Console.WriteLine("Virheellinen valinta.");
                        break;
                }
            }
        }
    }
}
    
s
