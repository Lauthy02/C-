using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una fecha mostrarla en el formato AAAAMMDD.
            Console.WriteLine("La fecha actual: {0}", DateTime.Now);
            Console.WriteLine("La fecha actual en formato AAAAMMDD: {0}", DateTime.Today.ToString("yyyy/MM/dd"));
            Console.ReadKey();
        }
    }
}
