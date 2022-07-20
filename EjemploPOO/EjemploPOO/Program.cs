using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEurodolar obj = new ConversorEurodolar();
    

            Console.WriteLine(obj.Convierte(50));
            obj.CambiaValorEuro(-1.45);
         
        }
    }

    class Circulo
    {
        private double pi = 3.1416; // propiedad de la clase circulo. Campo de clase

       public double CalculoArea(int radio) //metodo de clase,¿Que puede hacer los objetos de tipo circulo?
        {

        return pi * radio * radio;

            }


    }

    class ConversorEurodolar
    {
       private  double euro = 1.253;
        public double Convierte(double cantidad) {

            return cantidad * euro;
        }

        public void CambiaValorEuro(double nuevoValor)
        {
            if
            (nuevoValor < 0) euro = 1.253;
            else
                euro = nuevoValor;
        }

    }
}
