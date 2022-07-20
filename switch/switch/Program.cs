using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige Medio de trasporte coche tren o avion");
            string mediotrasporte = Console.ReadLine();
            switch (mediotrasporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad promedio 100 KM/h");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad promedio 250 KM/h");
                    break;
                case "avion":
                    Console.WriteLine("Velocidad promedio 800 KM/h");
                    break;
                default:
                    Console.WriteLine("ese medio de trasporte no contemplado");
                    break;

            }
            
        }
    }
}
