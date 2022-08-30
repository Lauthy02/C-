using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una frase cualquiera llamada x, mostrar como resultado una frase
            //formada por la segunda mitad de x más la primer mitad de x.
            //(usar el método substring)
            string palabra, primeraMitad, segundaMitad;
            int cantCaracters, cantCaractersprimeraMitad;
            Console.WriteLine("Ingrese una palabra :");
            palabra = Console.ReadLine();
            cantCaracters = palabra.Count();
            Console.WriteLine("La cantidad de caracteres es: {0}", cantCaracters);
            Console.ReadKey();
            cantCaractersprimeraMitad = cantCaracters / 2;
            Console.WriteLine("La cantidad de caracteres de la primera mitad es: {0}", cantCaractersprimeraMitad);
            //String aux = palabra;
            primeraMitad = palabra.Substring(0, cantCaractersprimeraMitad);
            Console.WriteLine("La palabra quedaría: {0}", primeraMitad);
            Console.ReadKey();
            segundaMitad = palabra.Substring(4, cantCaracters); //si en el lugar de 4 pongo un 0 el programa funciona, pero el resultado no es el que quiero (puse 4 por poner algo)
            Console.WriteLine("La palabra quedaría: {0}", segundaMitad);
            Console.ReadKey();
            Console.WriteLine("La palabra quedaría: {0}", segundaMitad + primeraMitad);
            Console.ReadKey();
        }
    }
}
