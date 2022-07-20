using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numAlea = numero.Next(0, 100);
            Console.WriteLine("Trate de Adivinar el numero");
            int numAdiv = 0;
            int conteo = 0;

            //Console.WriteLine(numAlea);
            while (numAlea != numAdiv)
            {
                try
                {
                    numAdiv = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("No usaste un caracter tipo Numerico");
                }

                if (numAlea > numAdiv)
                {
                    Console.WriteLine("Es Mayor");
                }

                if (numAlea < numAdiv)
                {
                    Console.WriteLine("es Menor");


                }
                conteo = conteo + 1; //sirve tambien conteo++;



            }
            Console.WriteLine($"total de intentos {conteo}");
        }
    }
}
