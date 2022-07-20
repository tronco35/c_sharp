using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargadeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            Console.WriteLine(Suma(7,5));
        }

        private static double Suma(int v1, int v2)
        {
            return v1 + v2;
        }
        //static int Suma(int operador1, int operador2) => operador1 + operador2;
        //static int Suma(int numero1, int numero2, int numero3) => numero1 + numero2;
        //static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;
    }
}
