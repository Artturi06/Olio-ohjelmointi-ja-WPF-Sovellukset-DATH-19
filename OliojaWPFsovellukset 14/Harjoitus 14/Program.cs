using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_14
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {



                string vastaus;
                Console.WriteLine("Mahdolliset komennot:\nUusi muistiinpano (1)-\nTulosta muistiinpanot (2)-\nTyhjennä muistiinpanot (3)-");
                vastaus = Console.ReadLine();
                if (vastaus == "1")
                {
                    string vastaus1;

                    
                    
                        System.IO.StreamWriter tiedosto = new System.IO.StreamWriter("Tiedot.txt");
                        Console.WriteLine("Lisää muistiinpano.");
                        vastaus1 = Console.ReadLine();
                        tiedosto.WriteLine(vastaus1);
                        tiedosto.Close();




                }
                else if (vastaus == "2")
                {


                }

                

                    
            

            }
            catch (Exception ex)
            {
                Console.WriteLine("tiedoston luominen ei onnistunut. Ohjelma päättyy");
            }
            
           
        }
    }
}
