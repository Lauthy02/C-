using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParteA
{
    public partial class Form_Matrices : Form
    {
        public Form_Matrices()
        {
            AllocConsole();
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void Form_Matrices_Load(object sender, EventArgs e)
        {

        }

        private void button_CargaMat_Click(object sender, EventArgs e)
        {
            string dato;
            int[,] matriz = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int h = 0; h < 4; h++)
                {
                    Console.WriteLine("Ingrese un valor: ");
                    dato = Console.ReadLine();
                    matriz[i, h] = int.Parse(dato);
                }

            }
            Console.WriteLine("Los datos del vector fueron impresos");
            for (int j = 1; j < 3; j++)
            {
                for (int b = 0; b < 4; b++)
                {
                    listBox_Mat.Items.Add("En la fila: " + j + " columna " + b + " el valor es: " + matriz[j, b]);
                }
            }
        }

        private void button_SalirMat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
