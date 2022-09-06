using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Informar cuantos días faltan para el 25 / 12 / 2027 (Ej15)
            DateTime fecha1 = new DateTime(2022, 08, 30);
            DateTime fecha2 = new DateTime(2027, 10, 10);
            TimeSpan Aux = fecha1 - fecha2;
            int dias = Aux.Days;
            Console.WriteLine("Faltan {0} días", dias);
            Console.ReadKey();
        }
    }
}