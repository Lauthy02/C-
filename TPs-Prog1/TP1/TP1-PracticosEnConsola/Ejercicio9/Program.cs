using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dadas dos frases concatenarlas y mostrar el resultado. 
            string palabra1,palabra2;
            Console.WriteLine("Ingrese una palabra: ");
            palabra1 = Console.ReadLine();
            Console.WriteLine("Ingrese otra palabra: ");
            palabra2 = Console.ReadLine();
            Console.WriteLine("La palabra es: {0}", palabra1 + palabra2);
            Console.ReadKey();
        }
    }
}
