using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotodoAmbito_sobrecarga
{
    class Program
    {
        //declaraciones de clase
        int numero1 = 5;
        int numero2 = 7;
        static void Main(string[] args)
        {



        }

        void primerMetodo()
        {

            Console.WriteLine(numero1+numero2);
        }
        void segundoMetodo()
        {


            Console.WriteLine(numero1 + numero2);
        }

    }
}
