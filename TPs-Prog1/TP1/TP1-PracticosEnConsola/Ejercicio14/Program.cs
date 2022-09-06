using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dadas dos fechas calcular la diferencia en días entre una y la otra. (Ej14)
            DateTime fecha1 = new DateTime(2020, 10, 10);
            DateTime fecha2 = new DateTime(2023, 10, 10);
            TimeSpan Aux = fecha1 - fecha2;
            int dias = Aux.Days;
            Console.WriteLine("La diferencia de días es: {0}", dias);
            Console.ReadKey();
        }
    }
}
