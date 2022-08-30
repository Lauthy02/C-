using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados dos valores ingresados por teclado mostrar la suma de ambos.

            int Numero = 0;
            int Numero2 = 0;
            Console.WriteLine("Ingrese un número por favor: ");
            Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número por favor: ");
            Numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es {0} ", Numero + Numero2);
            Console.ReadKey();
        }
    }
}
