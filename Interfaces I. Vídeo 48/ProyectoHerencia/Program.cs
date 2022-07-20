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

            //principio de sustitucion
            //  Mamiferos animal = new Caballo("Bucefalo");
            //Mamiferos persona = new humano("Juan");


            ////principio de sustitucion ejemplo 2
            //Mamiferos animal = new Mamiferos("Bucefalo");
            //Caballo Bucefalo = new Caballo("Bucefalo");
            // animal = Bucefalo; //puedo al macenar bucefalo en animal por el principio de sustitucion 

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = Babieca;
            almacenAnimales[1] = Juan;
            almacenAnimales[2] = Copito;
            almacenAnimales[1].getNombre();



            //Copito.getNombre();
            //Juan.getNombre();
            //Babieca.getNombre(); //reuse getnombre para los tres
            Ballena miWally = new Ballena("Wally");
            miWally.nadar();
            Console.WriteLine("Numero de patas de babieca " + Babieca.numeroPatas());
           
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

    //TODO: inicio de demo video 48 (a)


    class Ballena : Mamiferos
    { // contructor
        public Ballena (String nombreBallena): base(nombreBallena) // con base llama al contructor de la clase padre 
        {

        }
        //agregamos comportamiento o metodo 

        public void nadar()
        {
            Console.WriteLine("puedo nadar");
        }



    }
    //TODO:  demo video 48 (/a)

    //TODO:  demo video 48 (c)
    class Caballo : Mamiferos, IMamiferosTerretres

    {

        //constructor
        public Caballo(String nombreCaballo):base(nombreCaballo) //se uso :base por que se cambio el metodo por defecto de la clase mamifero
        {


        }

        //metodo
         public void galopar() {

                Console.WriteLine("Galopa el caballo");
            }

        public int numeroPatas()
        {
            return 4;
        }
        

        public int NumeroPatas()
        {
            throw new NotImplementedException();
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
            //TODO: demo video 48 (b)

        interface IMamiferosTerretres  //convencion iniciar por I
        {
            //metodo de interfaz: solo se declara, no tiene accion y no debe llevar modificador de acceso 
            int NumeroPatas();
        }
        //TODO: Demo video 48 (/b)

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
        public int numeroPatas()
        { return 4; }
            
        }
        
   
}
