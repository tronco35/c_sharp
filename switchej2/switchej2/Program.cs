using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce elmes para el calculo de comision");
            int nmes = int.Parse(Console.ReadLine());
            switch (nmes)
            {
                case 1:
                    Console.WriteLine("Mes Enero");
                    break;
                case 2:
                    Console.WriteLine("Mes Febrero");
                    break;
                case 3:
                    Console.WriteLine("Mes Marzo");
                    break;
                case 4:
                    Console.WriteLine("Mes abril");
                    break;
                case 5:
                    Console.WriteLine("Mes mayo");
                    break;
                case 6:
                    Console.WriteLine("Mes junio");
                    break;
                case 7:
                    Console.WriteLine("Mes Julio");
                    break;
                case 8:
                    Console.WriteLine("Mes Agosto");
                    break;
                case 9:
                    Console.WriteLine("Mes Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Mes Ocutbre");
                    break;
                case 11:
                    Console.WriteLine("Mes noviembre");
                    break;
                case 12:
                    Console.WriteLine("Mes Diciembre");
                    break;

                default:
                    Console.WriteLine("Mes oncorrecto");
                    break;
            }
        }
    }
}
