using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad ");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 18) Console.WriteLine( "Eres un niño");

            else if (edad < 30) Console.WriteLine("Eres Joven");
            else if (edad < 60) Console.WriteLine("Eres Maduro");
            else Console.WriteLine("Debes Cuidarte ya");



        }
    }
}
