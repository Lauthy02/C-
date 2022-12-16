using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Para poder usar la lista la debo crear
        ListaDoblementeEnlazada ListaDeNodos = new ListaDoblementeEnlazada();
        Cola ColaDeNodos = new Cola();
        Pila PilaDeNodos = new Pila();

        #region Lista

        #region Funciones para mostrar los elementos de la lista en el listbox

        //Funcion para mostrar los elementos de la lista en el listbox
        public void MostrarListaDeNodosEnListboxLista()
        {
            listBox_Lista.Items.Clear();
            Nodo NodoAuxiliar = ListaDeNodos.NodoInicioLista;
            while (NodoAuxiliar.NodoSiguiente != null) 
            {
                if (NodoAuxiliar.NodoAnterior!= null)
                {
                    listBox_Lista.Items.Add("Viene de " + NodoAuxiliar.NodoAnterior.NombreNodo + ", " + NodoAuxiliar.ToString() + ", apunta a " + NodoAuxiliar.NodoSiguiente.NombreNodo);
                }
                else
                {
                    listBox_Lista.Items.Add("Anterior nulo, " + NodoAuxiliar.ToString() + ", apunta a " + NodoAuxiliar.NodoSiguiente.NombreNodo);
                }
                NodoAuxiliar = NodoAuxiliar.NodoSiguiente;
            }
        }
        #endregion

        #region Botones Lista

        private void button_AgregarAlFinalLista_Click(object sender, EventArgs e)
        {
            if (textBox_NombreDelNodoLista.Text.Length > 0)//Pregunto el listbox tiene un nodo dentro
            {
                //Creo un nuevo nodo
                Nodo NodoNuevo = new Nodo();
                NodoNuevo.NombreNodo = textBox_NombreDelNodoLista.Text;
                ListaDeNodos.AgregarNodoAlFinal(NodoNuevo);
                MostrarListaDeNodosEnListboxLista();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
        }

        #endregion

        #endregion
        //
        //
        //
        //
        #region Cola

        #region Funciones para mostrar los elementos de la cola en el listbox
        private void MostrarColaDeNodosEnListboxCola()
        {
            listBox_Cola.Items.Clear();
            AgregarItemsEnListboxCola(ColaDeNodos.InicioCola());
        }

        private void AgregarItemsEnListboxCola(Nodo Nodo)
        {
            if (Nodo != null)
            {
                listBox_Cola.Items.Add(Nodo.NombreNodo);
                if (Nodo.NodoSiguiente != null)
                {
                    AgregarItemsEnListboxCola(Nodo.NodoSiguiente);
                }
            }
        }

        #endregion

        #region Botones Cola
        private void button_Encolar_Click(object sender, EventArgs e)
        {
            if (textBox_NombreDelNodoCola.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un nombre al nodo");
            }
            else
            {
                Nodo NodoNuevo = new Nodo();
                NodoNuevo.NombreNodo = textBox_NombreDelNodoCola.Text;
                ColaDeNodos.Encolar(NodoNuevo);
                MostrarColaDeNodosEnListboxCola();
            }
        }

        private void button_Desencolar_Click(object sender, EventArgs e)
        {
            //No puedo desencolar una cola vacía
            if (ColaDeNodos.SiLaColaEstaVacia())
            {
                MessageBox.Show("La cola está vacía");
            }
            else
            {
                ColaDeNodos.Desencolar();
                MostrarColaDeNodosEnListboxCola();
            }
        }
        #endregion

        #endregion
        //
        //
        //
        //
        #region Pila

        #region Funciones para mostrar los elementos de la pila en el listbox
        private void MostrarPilaDeNodosEnListboxPila()
        {
            listBox_Pila.Items.Clear();
            AgregarItemsEnListboxPila(PilaDeNodos.TopeDeLaPila());
        }

        private void AgregarItemsEnListboxPila(Nodo Nodo)
        {
            if (Nodo != null)
            {
                listBox_Pila.Items.Add(Nodo.NombreNodo);
                if (Nodo.NodoSiguiente != null)
                {
                    AgregarItemsEnListboxPila(Nodo.NodoSiguiente);
                }
            }
        }
        #endregion

        #region Botones Pila
        private void button_Apilar_Click(object sender, EventArgs e)
        {
            Nodo NuevoNodo = new Nodo();
            NuevoNodo.NombreNodo = textBox_NombreDelNodoPila.Text;
            PilaDeNodos.Apilar(NuevoNodo);
            MostrarPilaDeNodosEnListboxPila();
        }

        private void button_Desapilar_Click(object sender, EventArgs e)
        {
            PilaDeNodos.Desapilar();
            MostrarPilaDeNodosEnListboxPila();
        }
        #endregion

        #endregion
        //
        //
        //
        //
        #region Sin uso
        private void tabPage_Lista_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_AgregarAlPrincipioLista_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}