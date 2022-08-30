using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Si 1Byte tiene 8 bits, desarrolle una solución programática que permita
            //calcular cuántos bits hay en cualquier combinación de x KBytes.
            //Explique cómo llegó a esa conclusión.
            //1byte = 8bits
            //Debo pasar los KBytes a bytes y desp hacer la multiplicación
            double KBytes, Bytes, Bits;
            Console.WriteLine("Ingrese la cantidad de KBytes: ");
            KBytes = double.Parse(Console.ReadLine());
            Bytes = KBytes * 1000;
            Bits = Bytes * 8;
            Console.WriteLine("La cantidad de bits es: {0}", Bits);
            Console.ReadKey();
        }
    }
}
