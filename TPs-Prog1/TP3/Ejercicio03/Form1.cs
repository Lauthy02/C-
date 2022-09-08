using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Desarrollar un programa que permita cargar una cantidad n de números ingresados
        //por el usuario y mostrar los números ingresados en un textbox y el resultado en
        //un label.

        private void button_Ingresar_Click(object sender, EventArgs e)
        {
            int CantDeNumeros = 0;
            int Acumulador = 0;
            CantDeNumeros = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de números que desea ingresar", "Ingreso de números"));
            for (int i = 0; i < CantDeNumeros; i++)
            {
                int[] vector = new int[CantDeNumeros];
                vector[i]= int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número", "Ingreso de números"));
                Acumulador = Acumulador + vector[i];
                textBox_Numeros.Text = (" " + vector[i]); //No se como hacer para q se vea toda la lista
            }
            label_Resultado.Text = ("La suma de todos los numeros es: " + Acumulador);
        }
    }
}
