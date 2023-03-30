using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehilce VehicleOlio = new Vehilce();


            VehicleOlio.Nimi = "Volvo";
            VehicleOlio.Nopeus = 120;
            VehicleOlio.Renkaat = 4;


            Console.WriteLine(VehicleOlio.Haetiedot());
        }
    }
}