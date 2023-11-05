using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20231105Szoftverek
{
    internal class FM
    {
        public static int tarolo(List<Szoftverek> lista){ 
            var v = new List<Szoftverek>();
            v = lista.Where(x => x.Ertekeles > 8.5 && x.Kategoria.ToLower() == "antivírus").ToList();
            return v.Count;



        }
        public static void Ertekeles(List<Szoftverek> lista)
        {
            var max = lista.Max(x => x.Ertekeles);
            var v = lista.Where(x => x.Ertekeles == max - .1).ToList();
            foreach( var x in v) Console.WriteLine(x);
            Console.WriteLine($"{v.Count} db");
        }
    }
}
