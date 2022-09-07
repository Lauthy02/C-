using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Desarrollar un programa que permita ingresar dos números por medio de
        //inputbox y retorne la suma de los mismos en un messagebox.

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1, Num2;
            Num1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero 1: ", "Ingresar numero", "Numero", 100, 0));
            Num2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero 2: ", "Ingresar numero", "Numero", 100, 0));
            int Aux = Num1 + Num2;
            MessageBox.Show("La suma es: " + Aux, "SUMA");
        }
    }
}
