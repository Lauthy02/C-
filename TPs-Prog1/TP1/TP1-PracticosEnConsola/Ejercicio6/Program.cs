using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Si la circunferencia de un círculo es pi * Diámetro, desarrollar una
            //aplicación que dada la circunferencia calcule el diámetro.
            // Circ = PI*diam
            // diam = Circ/PI
            double PI = 3.1416;
            double Circ, diam;
            Console.WriteLine("Ingrese la circunferencia del círculo: ");
            Circ = int.Parse(Console.ReadLine());
            diam = Circ / PI;
            Console.WriteLine("El diámetro es: {0}", diam);
            Console.ReadKey();
        }
    }
}
