using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06LaczenieDanych
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            foreach (var z in db.Zawodnik.ToArray())
            {
                Console.WriteLine(z.imie + " " + z.nazwisko + " " + z.Trener?.imie_t + " " + z.Trener?.nazwisko_t);
            }

            Console.WriteLine("--------");

            Console.ReadKey();
        }
    }
}