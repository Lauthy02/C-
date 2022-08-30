using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados los datos necesarios de un Rectángulo calcular la superficie.
            int Base, Altura, Superficie;
            Console.WriteLine("Ingrese el valor de la base del cuadrado: ");
            Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la alutra del cuadrado: ");
            Altura = int.Parse(Console.ReadLine());
            Superficie = ((Base * Altura)/2);
            Console.WriteLine("La superficie es: {0}", Superficie);
            Console.ReadKey();
        }
    }
}
