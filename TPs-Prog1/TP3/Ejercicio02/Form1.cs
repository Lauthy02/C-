using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Desarrollar un programa que permita ingresar dos números por medio de cajas
        //de texto y retorne la suma de los mismos en un label.

        private void button_Suma_Click(object sender, EventArgs e)
        {
            int Num1 = 0, Num2 = 0;
            Num1 = int.Parse(textBox_Num1.Text);
            Num2 = int.Parse(textBox_Num2.Text);
            int aux = Num1 + Num2;
            label_Resultado.Text = ("El resultado es: " + aux);
        }
    }
}
