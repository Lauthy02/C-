using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Cola
    {
        //La cola necesita saber donde comienza, entonces lo declaro
        Nodo NodoInicioCola;

        //Funciones de la clase Cola
        public Nodo InicioCola()
        { 
            return NodoInicioCola;
        }

        private Nodo BuscarElUltimoNodoCola(Nodo Nodo)
        {
            if (Nodo.NodoSiguiente == null) 
            {
                return Nodo;
            }
            else
            {
                return BuscarElUltimoNodoCola(Nodo.NodoSiguiente);
            }
        
        }

        public bool SiLaColaEstaVacia()
        {
            return (NodoInicioCola == null);
        }

        public void Encolar(Nodo Nodo) //Agrega un nodo al final
        {
            //Para agregar un nodo al final necesito un funcion recursiva q recorra la cola
            //y me diga cual es el final
            if (NodoInicioCola == null)
            {
                NodoInicioCola = Nodo;
            }
            else
            {
                Nodo NodoAuxiliar = BuscarElUltimoNodoCola(NodoInicioCola);
                NodoAuxiliar.NodoSiguiente = Nodo;
            }
        }

        public void Desencolar() //Saca un nodo del principio  
        {
            NodoInicioCola = NodoInicioCola.NodoSiguiente;
        }
    }
}