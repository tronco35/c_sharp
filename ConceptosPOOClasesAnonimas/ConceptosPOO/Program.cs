using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static System.Math; // importamos llos metodos estaticos de la libreria Math// ya no tengo que llamarlo cada vez que uno un math
using static System.Console; // llamar metodos estaticos de console


namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // realizarTarea();
            //----------------------------------------
            // double raiz = Sqrt(9);// raiz cuadrada con libreria Math
            // double potencia = Pow(3, 4); //potencia con libreria Math
            //WriteLine(raiz); // libreria console
            //WriteLine(potencia); // libreria console
            //------------------------------------------------
            var miVariable = new { Nombre = "Juan", Edad = 19 }; // clase anonima
            Console.WriteLine(miVariable.Nombre +" "+ miVariable.Edad);

            var miOtraVariable = new { Nombre = "ana", Edad = 25 }; // al tener los mismos campos y estar en el mismo orden determina que son de la misma clase

            miVariable = miOtraVariable;
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);
            Punto otropunto = new Punto();
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los puntos es de:  {distancia}");
            Console.WriteLine($"Numero de bojetos creados: {Punto.Contadordeobjetos()}");
           
        }



        
    }
}
