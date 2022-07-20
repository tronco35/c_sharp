using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");//instancia --al agregar un contructor a caballo hay que ingresar el parametro de nombre caballo
            humano Juan = new humano("Juan");
            gorilla Copito = new gorilla("Copito");

            Copito.getNombre();
            Juan.getNombre();
            Babieca.getNombre(); //reuse getnombre para los tres
           
        }



    }
    class Mamiferos
    {
        //contructor--estoy reemplazando el contructor por defecto
        public Mamiferos(string nombre)

        {
            nombreServivo = nombre;
        }

        //metodo
        public void  respirar ()
        { Console.WriteLine("Soy capaz de respirar"); }


        public void CuidarCrias() {
            Console.WriteLine("Cuido de mis crias hasta que sean grandes");
        }

        public void getNombre()
        {
            Console.WriteLine("El Nombre del ser vivo " + nombreServivo);
        }

        private String nombreServivo; //class system--Campo de clase
     

    }
    class Caballo : Mamiferos  // hereda de mamiferos
            {

        //constructor
        public Caballo(String nombreCaballo):base(nombreCaballo) //se uso :base por que se cambio el metodo por defecto de la clase mamifero
        {


        }

        //metodo
         public void galopar() {

                Console.WriteLine("Galopa el caballo");
            }

        }

        class humano : Mamiferos
        {
        //contructor
        public humano(String nombrePersona) : base(nombrePersona)
        {

        }

            public void pensar()
            { Console.WriteLine("soy capaz de pensar"); }
            
        }

        class gorilla : Mamiferos
        {
          //constructor
          public gorilla(String NombreGorila):base(NombreGorila)
        {

        }

            //metodo
            public void trepar (){
                Console.WriteLine("soy capaz de trepar");
            }
            
        }
        
   
}
