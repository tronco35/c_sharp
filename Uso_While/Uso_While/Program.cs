using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uso_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas entrar en el bucle While?");
            string respuesta = Console.ReadLine();
            while (respuesta != "no")
            {
                Console.WriteLine("Estas ejecutando el bucle While");
                Console.WriteLine("Introduce tu nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Saldras del bucle {nombre} cuando la respuesta es no a la pregunta");
                Console.WriteLine("Deseas Repetir Otra vez");
                respuesta = Console.ReadLine();

            }
            Console.WriteLine("Has salido del bucle");
        }
    }
}
