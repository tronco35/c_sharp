using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            string carnet = "no";
            Console.WriteLine("Vamos a evaluar si puedes conducir");
        
            Console.WriteLine("Introduce tu edad");
            int edad = int.Parse(Console.ReadLine());


            if (edad >= 18) {
                Console.WriteLine("¿Tienes Carne?");
                carnet = Console.ReadLine();
            }

                if (edad >= 18 && carnet== "si" )

                Console.WriteLine("Puedes Conducir");
            else Console.WriteLine("No puedes conducir");


        }
    }
}
