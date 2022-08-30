using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar una aplicación de consola que tomando 2 números informe cuantos números hay entre los dos.

            int Numero = 0;
            int numero2 = 0;
            Console.WriteLine("Ingrese un numero por favor: ");
            Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero por favor: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay {0} números entre los 2.", numero2 - Numero);
            Console.ReadKey();
        }
    }
}
