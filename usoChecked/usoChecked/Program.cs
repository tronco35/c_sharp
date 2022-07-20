using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int numero = int.MaxValue; //devuelve el valor mas alto
                int resultado = numero + 20;
                Console.WriteLine(resultado);
            }

        }
    }
}
