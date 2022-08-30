using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados los lados de un triangulo calcular el perímetro.

            int Lado1, Lado2, Lado3, Perimetro;
            Console.WriteLine("Ingrese el valor del 1er lado: ");
            Lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del 2do lado: ");
            Lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del 3er lado: ");
            Lado3 = int.Parse(Console.ReadLine());
            if (Lado1 != Lado2) 
            {
                Console.WriteLine("No es un triángulo.");
            }
            else
            {
                Perimetro = Lado1 + Lado2 + Lado3;
                Console.WriteLine("El perímetro es: {0}", Perimetro);
            }
            Console.ReadKey();
        }
    }
}
