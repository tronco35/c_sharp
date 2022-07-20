using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoFInally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                int contador = 0;

                string ruta = @"C:\Users\Administrador\Desktop\filtrar.txt";
                archivo = new System.IO.StreamReader(ruta);//abre el canal de comunicaciones con los ficheros
                while ((linea = archivo.ReadLine()) != null)
                {

                    Console.WriteLine(linea);
                    contador++;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error Generico " + e.Message);
            }
            finally {

                if (archivo != null) archivo.Close();//cierra System.IO.StreamReader
                Console.WriteLine("Conexion con el fichero cerrada");
            }
        }
    }
}
