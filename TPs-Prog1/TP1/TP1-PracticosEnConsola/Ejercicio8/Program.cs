using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular el factorial de 6.
            int fact = 1;
            for (int i = 1; i <= 6; i++)
            {
                fact *= i;
            }
            Console.WriteLine("El Factorial de 6 es: " + fact);
            Console.ReadKey();
        }
    }
}
