using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9_osa1
{
    public class Radio
    {
        public readonly int MaxÄäni = 9;
        public readonly int MinÄäni = 0;

        public readonly double Maxtaajuus = 107.9;
        public readonly double Mintaajuus = 88.0;
        public bool Virta { get; set; }

        private int äänenvoimakkuus;
        public int Äänenvoimakkuus
        {
            get { return äänenvoimakkuus; }
            set { if (value > MaxÄäni) 
                {
                    value = MaxÄäni;
                    Console.WriteLine("Maksimiäänenvoimakkuus on:  " + MaxÄäni);
                   
                }
                else if(value < MinÄäni)
                    {
                        value = MinÄäni;
                        Console.WriteLine("Minimiäänenvoinakkuus on:  " + MinÄäni);
                    }
                
             äänenvoimakkuus= value;
            }
        }

        private double taajuus;
        public double Taajuus
        {
            get { return taajuus; }
            set
            {
                if (value > Maxtaajuus)
                {
                    value = Maxtaajuus;
                    Console.WriteLine("Maksimitaajuus on:  " + Maxtaajuus);


                }
                else
                {
                    if (value < Mintaajuus)
                    {
                        value = Mintaajuus;
                        Console.WriteLine("Minimitaajuus on:  " + Mintaajuus);
                    }
                }
                taajuus = value;
            }
        }




    }
}
