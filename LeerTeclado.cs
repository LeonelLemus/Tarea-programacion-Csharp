using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerTecaldo
{
    ///<summary>
    /// Leer datos desde teclado
    ///</summary>
    
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de dos números");
            Console.WriteLine("Ingresa el número 1: ");
            // Los datos se leen como cadena
            string dato = Console.ReadLine();
            // Convertir a numero con int.Parse
            int n1 = int.Parse(dato);


            Console.WriteLine("Ingresa el numero 2: ");
            dato = Console.ReadLine();  
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultado es: {0}", suma);
            Console.Read();

        }
    }
}
