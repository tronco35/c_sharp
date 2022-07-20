using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class Punto
    {
        //constructor 
        public Punto(int x, int y) {
            //Console.WriteLine($"Coordenada x: {x}, Coordenada {y}");
            this.x = x;
            this.y = y;

            contadorDeObjetos++;

        }
        public Punto() //sobrecarga de constructores par que no genere error de parametros sin setear
        {
            //   Console.WriteLine("Este es el constructor por defecto");
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;

        }
        public double DistanciaHasta(Punto otroPunto) { //parametro tipo objeto

            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distanciaPunto = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));// teorema de pitagoras
            return distanciaPunto;

        }
        //public static int COnmtadorDEobjetos()//metodo estatico
        //{
        //    return contadorDeObjetos;
        //}
        //Metodo estatico abreviado

        public static int Contadordeobjetos() => contadorDeObjetos;

 
        private int x, y; //campo de clase
        private static int contadorDeObjetos = 0;// variable static
        public const int constanteprueba = 7;  //constante
    }
}
