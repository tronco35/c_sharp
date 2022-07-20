using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COntructor__UsoCOhes
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); //crear objeto de tipo coche/instanciar la clase coche/ dar un estado inicial
            Coche coche2 = new Coche(); //crear objeto de tipo coche/instanciar la clase coche/ dar un estado inicial

            Console.WriteLine(coche1.getInfocoche());
            Console.WriteLine(coche2.getInfocoche());

            Coche coche3 = new Coche(4500.25, 1200.35);
            Console.WriteLine(coche3.getInfocoche());


            coche3.setExtras(true, " Cuero"); //modificaco el metodo setter
            Console.WriteLine(coche3.getextras()); //llamado a metodo setter

       

        }

       class Coche
            {
            // constructor
            // el contructor da un estado incial  los objetos de una clase
            public Coche()  //primer constructor
            {
                ruedas = 4;
                largo = 2300.5;
                ancho = 0.800;
                tapiceria = "tela ";
            }
            public Coche(double v1, double v2)  //segundo constructor con sobrecarga
            {
                ruedas = 4;
                largo = 2300.5;
                ancho = 0.800;
                tapiceria = "tela ";
            }
            //metodo getter
            public string getInfocoche()
            {
                return "Informacion del coche:\nRuedas " + ruedas +" largo "+ largo + " Ancho "+ ancho;
            }

            //Metodo setter

            public void setExtras( bool ParamClimatizador, String paramTapiceria) {

                climatizador = ParamClimatizador;
                tapiceria = paramTapiceria;


            }

            public String getextras() {

                return "extras del coche \n" + "Tapiceria " + tapiceria + " Climatizador "
                    + climatizador ;

            }

            //caracteristicas o propiedades
            private int ruedas;

            private double largo;

            private double ancho;

            private bool climatizador;

            private string tapiceria;
            
       





        }
    }
}
