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

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1,Num2;
            Num1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número 1", "Ingreso de números"));
            Num2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número 2", "Ingreso de números"));
            int aux = Num1 + Num2;
            MessageBox.Show("La suma es: " + aux);
        }
    }
}
