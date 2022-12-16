using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Pila
    {
        Nodo NodoTopePila;

        public Nodo TopeDeLaPila()
        { 
            return NodoTopePila;    
        }

        public void Apilar(Nodo Nodo)
        {
            if (NodoTopePila == null) 
            {
                NodoTopePila = Nodo;
            }
            else
            {
                Nodo NodoAuxiliar = NodoTopePila;
                NodoTopePila = Nodo;
                NodoTopePila.NodoSiguiente = NodoAuxiliar;
            }
        }

        public void Desapilar()
        {
            if (NodoTopePila != null)
            {
                NodoTopePila = NodoTopePila.NodoSiguiente;
            }
        }
    }
}
