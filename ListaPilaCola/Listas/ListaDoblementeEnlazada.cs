using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class ListaDoblementeEnlazada
    {
        //La lista solo sabe cual es el inicio 
        public Nodo NodoInicioLista;
        public int cantidadDeNodos = 0;

        public void AgregarNodoAlFinal(Nodo Nodo)
        {
            if (NodoInicioLista == null) 
            {
                NodoInicioLista = Nodo;
            }
            else
            {
                Nodo NodoAuxiliar = NodoInicioLista;
                while (NodoAuxiliar.NodoSiguiente != null)
                {
                    NodoAuxiliar = NodoAuxiliar.NodoSiguiente;
                }
                NodoAuxiliar.NodoSiguiente = Nodo;
                Nodo.NodoAnterior = NodoAuxiliar;
            }
            cantidadDeNodos++;
        }
    }
}