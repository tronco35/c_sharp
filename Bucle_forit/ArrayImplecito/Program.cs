using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayImplecito
{
    class Program
    {
        static void Main(string[] args)
        {
            //array implicito
            //var datos = new[] { "Juan", "Diaz", "España" }; //automaticamenmte asigna el tipo de dato 
            var valores = new[] { 15, 28, 35, 75.5, 30.30, 56, 57, 12 }; //cambia todo el tipo a double



            //array de objetos
            Empleados Ana = new Empleados("Ana", 27); // cree el objeto Ana
            Empleados[] arrayEMpleado = new Empleados[3]; //numero de elementos que tiene el array
            arrayEMpleado[0] = new Empleados("sara", 37);
            arrayEMpleado[1] = Ana; //objeto Ana
            arrayEMpleado[2] = new Empleados("Manuel", 51);
           
          
            //Array de tipos anonimos

            var personas = new[]
            {
            new { Nombre="Juan", Edad=19},
            new { Nombre= "Maria", Edad=49},
            new { Nombre= "Diana", Edad=35},

         //   public string getemp ()

            };
            //bucle for it1 tipo objeto
            //foreach (Empleados variable in arrayEMpleado)//iterador debe ser del mismo tipo del array--este objeto es de tipo empleado
            //{
            //    Console.WriteLine(variable.getempleado());
            //}


            ////bucle for it2 con primitivos
            //foreach (double variable in valores)//iterador debe ser del mismo tipo del array--este es un primitivo
            //{
            //    Console.WriteLine(variable);
            //}

            ////bucle for it3 array anomnimos
            foreach (var variable in personas)//
            {
                Console.WriteLine(variable);
            }

        }


    }
    class Empleados
    {
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;

        }

        public string getempleado ()
            {
                return " nombre de empleado "+ nombre + " Edad " + edad;
            }

        //estos pertenecen a class empleado
    private string nombre;
        private int edad; 

    }
}

