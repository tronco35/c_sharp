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
            var valores = new[] { 15, 28, 35, 75.5, 30.30 }; //cambia todo el tipo a double

            //array de objetos
            Empleados Ana = new Empleados("Ana", 27); // cree el objeto Ana
            Empleados[] arrayEMpleado = new Empleados[2];
            arrayEMpleado[0] = new Empleados("sara", 37);
            arrayEMpleado[1] = Ana; //objeto Ana

            //Array de tipos anonimos

            var personas = new[]
            {
            new { Nombre="Juan", Edad=19},
            new { Nombre= "Maria", Edad=49},
            new { Nombre= "Diana", Edad=35},


            };

            Console.WriteLine(personas[1]);
        }


    }
    class Empleados
    {
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;

        }

        string nombre;
        int edad; 

    }
}

