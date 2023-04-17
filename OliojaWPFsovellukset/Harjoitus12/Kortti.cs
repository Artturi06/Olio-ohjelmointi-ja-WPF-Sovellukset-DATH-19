using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12
{
    public class Kortti
    {
        public string Maa { get; set; }
        public int Numero { get; set; }

        public Kortti(string _Maa, int _Numero)
        {
            Maa = _Maa;
            Numero = _Numero;
        } 
    }
}
