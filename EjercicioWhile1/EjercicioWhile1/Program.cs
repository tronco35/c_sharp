using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWhile1
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
                numAdiv = int.Parse(Console.ReadLine());
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
            // el programa debe generar un numero aleatorio entre 0 y 100
            //no voy a conocer que numero es
            //una vez genere el numero nos debe preguntar por consola que numero es
            //el programar debe poder decir si es menor o mayor al numero que estoy proporcionando manualmente
            // cuando acierte el numero deme decirme el numero de intentos que he generado para lograrlo
            //Random numero = new Ramdom(); objeto aleatoreo
            //int numeroAleatorio = numero.Next(0, 100);
           


        }
    }

