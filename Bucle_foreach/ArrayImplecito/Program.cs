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
            //bucle for
            for (int i = 0; i < arrayEMpleado.Length; i++) // valores.Length le indica que solo hasta que termine la longitud del array
            {
                Console.WriteLine(arrayEMpleado[i].getempleado());//i el metodo getter lo agrega al final

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

