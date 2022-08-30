using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una frase informar la cantidad de caracteres que tiene
            string palabra;
            int cantCaracters;
            Console.WriteLine("Ingrese una palabra :");
            palabra = Console.ReadLine();
            cantCaracters = palabra.Count();
            Console.WriteLine("La cantidad de caracteres es: {0}", cantCaracters);
            Console.ReadKey();
        }
    }
}
