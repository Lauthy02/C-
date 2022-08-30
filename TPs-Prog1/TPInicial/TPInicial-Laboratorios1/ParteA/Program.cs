using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParteA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NroEjercicio;
            bool Salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Ejercicio Nro1");
                Console.WriteLine("Ejercicio Nro2");
                Console.WriteLine("Ejercicio Nro3");
                Console.WriteLine("Ejercicio Nro4");
                Console.WriteLine("Ejercicio Nro5");
                Console.WriteLine("Ejercicio Nro6");
                Console.WriteLine("Ejercicio Nro7");
                Console.WriteLine("Ejercicio Nro8");
                Console.WriteLine("Ejercicio Nro9");
                Console.WriteLine("Ejercicio Nro10");
                Console.WriteLine("Escriba el numero del ejercicio a entrar: ");
                NroEjercicio = int.Parse(Console.ReadLine());

                switch (NroEjercicio)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Usted entro al ejercicio Nro1: Dado 2 valores y sumarlos");
                            int a;
                            float b, c;
                            a = 10;
                            b = (float)10.5;
                            c = (float)(a + b);
                            Console.WriteLine("{0} + {1} = {2}", a, b, c);
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Usted entro al ejercicio Nro2: Dado 2 valores indicar si son iguales");
                            int a, b;
                            a = 10;
                            b = 10;
                            if (a == b)
                            {
                                Console.WriteLine("a y b son iguales.");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            string ValorDeHora;
                            int Tiempo = 0, Sueldo = 0, Auxiliar = 0;
                            Console.WriteLine("Usted entro al ejercicio Nro3: Ingresar el valor de la hora y el tiempo de trabajo de un operador. Indicar su sueldo");
                            Console.WriteLine("Escriba el valor de la hora: ");
                            ValorDeHora = Console.ReadLine();
                            Auxiliar = int.Parse(ValorDeHora);
                            Console.WriteLine("Escriba el tiempo trabajado: ");
                            Tiempo = int.Parse(Console.ReadLine());
                            Sueldo = Auxiliar * Tiempo;
                            Console.WriteLine("Su sueldo es: {0}", Sueldo);
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Usted entro al ejercicio Nro4: Ingresar dos valores, indicar si son iguales y de ser diferentes, indicar cuál es menor");
                            int Nro1, Nro2;
                            Console.WriteLine("Ingrese el valor nro1: ");
                            Nro1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor nro2: ");
                            Nro2 = int.Parse(Console.ReadLine());
                            if (Nro1 != Nro2)
                            {
                                Console.WriteLine("Son distintos.");
                                if (Nro1 > Nro2)
                                {
                                    Console.WriteLine("El menor es el Nro2.");
                                }
                                else
                                {
                                    Console.WriteLine("El menor es el Nro1.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Son iguales.");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Usted entro al ejercicio Nro5: Ingresar 4 valores y sumarlos.");
                            int a;
                            int Suma = 0;
                            for (int i = 1; i <= 4; i++)
                            {
                                Console.WriteLine("Ingrese el valor Nro{0}: ", i);
                                a = int.Parse(Console.ReadLine());
                                Suma = Suma + a;
                            }
                            Console.WriteLine("El valor total de la suma es: {0}", Suma);
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("Usted entro al ejercicio Nro6: Ingresar los sueldos de empleados, sumarlos indicar su valor promedio, finaliza con legajo = 0");
                            int Legajo, Sueldo, Total = 0, Cont = 0;
                            float Promedio;
                            Console.Clear();
                            Console.WriteLine("Ingrese el legajo: ");
                            Legajo = int.Parse(Console.ReadLine());
                            while (Legajo != 0)
                            {
                                Console.WriteLine("Ingrese el sueldo: ");
                                Sueldo = int.Parse(Console.ReadLine());
                                Total = Total + Sueldo;
                                Cont = Cont + 1;
                                Console.WriteLine("Ingrese el legajo: ");
                                Legajo = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("El total pagado es: {0}", Total);
                            Promedio = (float)(Total / Cont);
                            Console.WriteLine("El sueldo promedio es: {0,2:F2}", Promedio);
                            Console.WriteLine("El sueldo promedio es: {0}", Promedio);
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("Usted entro al ejercicio Nro7: ingresar el valor de la hs de cada categoría, guardarlo en\r\nun vector y luego ingresar los empleados de la empresa\r\nhasta legajo = 0, indicar el sueldo de cada empleado y el total a pagar");
                            int[] Vector = new int[5];
                            int categoria, legajo, hs, saldo, total = 0;
                            for (int i = 1; i < 4; i++)
                            {
                                Console.WriteLine("ingrese el valor de la hs de la categoria {0}: ", i);
                                Vector[i] = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("ingrese el nro de legajo: ");
                            legajo = int.Parse(Console.ReadLine());
                            while (legajo != 0)
                            {
                                Console.WriteLine("ingrese el nro de categoria");
                                categoria = int.Parse(Console.ReadLine());
                                Console.WriteLine("ingrese el nro de hs trabajadas");
                                hs = int.Parse(Console.ReadLine());
                                saldo = hs * Vector[categoria];
                                Console.WriteLine("el legajo {0} cobrara {1}", legajo, saldo);
                                total = total + saldo;
                                Console.WriteLine("ingrese el nro de legajo");
                                legajo = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("el total a pagar por sueldos es {0}", total);
                            Console.ReadKey();
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Console.WriteLine("Usted entro al ejercicio Nro8: Ingrese el valor de la hs de cada categoría, indique el sueldo de cada empleado, la cantidad de empleados por categoría \r\n y el valor total a pagar en calidad de sueldos");
                            int[] VectorValorHS = new int[5];
                            int[] VectorCantidad = new int[5];
                            int categoria, legajo, hs, saldo, total = 0;
                            for (int i = 1; i <= 4; i++)
                            {
                                Console.WriteLine("ingrese el valor de la hs de la categoria {0}: ", i);
                                VectorValorHS[i] = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("ingrese el nro de legajo: ");
                            legajo = int.Parse(Console.ReadLine());
                            while (legajo != 0)
                            {
                                Console.WriteLine("ingrese el nro de categoria");
                                categoria = int.Parse(Console.ReadLine());
                                Console.WriteLine("ingrese el nro de hs trabajadas");
                                hs = int.Parse(Console.ReadLine());
                                saldo = hs * VectorValorHS[categoria];
                                Console.WriteLine("el legajo {0} cobrara {1}", legajo, saldo);
                                total = total + saldo;
                                VectorCantidad[categoria] = VectorCantidad[categoria] + 1;
                                Console.WriteLine("ingrese el nro de legajo");
                                legajo = int.Parse(Console.ReadLine());
                            }
                            for (int i = 1; i <= 4; i++)
                            {
                                Console.WriteLine("De la cateoría {0} hay {1} empleados", i, VectorCantidad[i]);
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            Console.WriteLine("Usted entro al ejercicio Nro9: Dados 4 categorías y 4 departamentos ingresar la cantidad de hs trabajas en ellas");
                            int[,] Matriz = new int[5, 5];
                            int categoria = 0, departamento, hs;
                            for (int i = 1; i <= 4; i++)
                            {
                                Console.WriteLine("ingrese el valor de la hs de la categoria {0}: ", i);
                                categoria = int.Parse(Console.ReadLine());
                                for (int j = 1; j <= 4; j++)
                                {
                                    Console.WriteLine("ingrese el nro de departamento: ");
                                    departamento = int.Parse(Console.ReadLine());
                                    Console.WriteLine("ingrese el nro de hs trabajadas: ");
                                    hs = int.Parse(Console.ReadLine());
                                    hs = Matriz[categoria, departamento];
                                }
                            }
                            for (int i = 1; i <= 4; i++)
                            {
                                for (int j = 1; j <= 4; j++)
                                {
                                    Console.WriteLine("Categoria {0} - Departamento {1} - Horas {2}\n", i, j, Matriz[i, j]);
                                }
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 10:
                        {
                            Console.Clear();
                            Console.WriteLine("Usted entro al ejercicio Nro10: ");
                            int[] PrecioDeLaPizza = new int[7] { 10, 20, 30, 4, 5, 6, 7 };  //Precio de la pizza según la categoria, la categoria es la posición en el vector
                            int MontoTotal = 0, Monto = 0, MontoMax = 0;                    //Variables para el Monto
                            int Moto = 0, MotoMin, MotoMax;                                 //Variables para la Moto
                            int NroTicket, TicketMax = 0;                                   //Variables para el Ticket
                            int CategPizza = 0, CantidadPizzas, PorcentajePizzasA = 0;      //Variables para las Pizzas
                            int[] CantViajesxMoto = new int[5];                             //Vector para la cantidad de viajes por moto, la moto es la pos del vector y la pos 0 la uso para guardar el acmulado de viajes totales
                            int CantPizzasA = 0, Promedio = 0;
                            Console.WriteLine("Ingrese el numero de ticket: ");
                            NroTicket = int.Parse(Console.ReadLine());
                            while (NroTicket != 0)
                            {
                                Console.WriteLine("Ingrese la categoría de la pizza (de 1 a 6): ");
                                CategPizza = int.Parse(Console.ReadLine());
                                Console.WriteLine("ingrese la cantidad");
                                CantidadPizzas = int.Parse(Console.ReadLine());
                                Console.WriteLine("ingrese la moto: ");
                                Moto = int.Parse(Console.ReadLine());
                                Monto = CantidadPizzas + PrecioDeLaPizza[CategPizza];
                                if (TicketMax == 0)
                                {
                                    TicketMax = NroTicket;
                                    MotoMax = Moto;
                                    MontoMax = Monto;
                                }
                                else
                                {
                                    if (Monto > TicketMax)
                                    {
                                        TicketMax = NroTicket;
                                        MotoMax = Moto;
                                        MontoMax = Monto;
                                    }
                                }
                                CantViajesxMoto[Moto]++;
                                MontoTotal = MontoTotal + Monto;
                                CantViajesxMoto[0]++;
                                if (CategPizza == 1)
                                {
                                    CantPizzasA++;
                                }
                                Console.WriteLine("Ingrese el numero de ticket: ");
                                NroTicket = int.Parse(Console.ReadLine());
                            }
                            Promedio = MontoTotal / CantViajesxMoto[0];
                            PorcentajePizzasA = CantPizzasA / CantViajesxMoto[0];
                            MotoMin = 1;
                            for (int i = 1; i <= 4; i++)
                            {
                                if (CantViajesxMoto[i] < CantViajesxMoto[MotoMin])
                                {
                                    MotoMin = i;
                                }
                            }
                            Console.WriteLine("El ticket {0} de valor: {1} es el de mayor importe", TicketMax, MontoMax);
                            Console.WriteLine("La moto {0} es la que hizo menos viajes", MotoMin);
                            Console.WriteLine("el valor promedio de los viajes es: {0} ", Promedio);
                            Console.WriteLine("El porcentaje de pedidos de pizzas categoria A es: {0}", PorcentajePizzasA);
                            Console.WriteLine("La facturacion total del negocio es: {0}", MontoTotal);
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("No seleccionó ningún número válido.");
                            Console.WriteLine("Vuelva a intentar.");
                            Console.ReadKey();
                            Salir = false;
                            break;
                        }
                }
            } while (Salir == false);
        }
    }
}