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
    public partial class Form_Carga_OperaciónVectores : Form
    {
        string dato;
        int[] vector = new int[10];
        public Form_Carga_OperaciónVectores()
        {
            AllocConsole();
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void Form_Carga_OperaciónVectores_Load(object sender, EventArgs e)
        {

        }

        private void button_CargaVec_Click(object sender, EventArgs e)
        {
            listBox_Vec.Items.Clear();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Ingrese un valor: ");
                dato = Console.ReadLine();
                vector[i] = int.Parse(dato);
            }
            Console.WriteLine("Los datos del vector fueron impresos");
            for (int j = 1; j < 10; j++)
            {
                listBox_Vec.Items.Add("En la posición : " + j + " el valor es: " + vector[j]);
            }
        }

        private void button_OrdenarVec_Click(object sender, EventArgs e)
        {
            listBox_Vec.Items.Clear();
            Array.Sort(vector);
            for (int i = 0; i < 10; i++)
            {
                listBox_Vec.Items.Add("El valor es: " + vector[i] + " en la posición : " + i);
            }
        }

        private void button_CopiarVec_Click(object sender, EventArgs e)
        {
            int[] vectorDestino = new int[20];
            Array.Copy(vector, 0, vectorDestino, 0, 10);
            for (int i = 0; i < 10; i++)
            {
                listBox_Vec.Items.Add(vectorDestino[i] + " en la posición " + i);
            }
        }

        private void button_BusqBinariaVec_Click(object sender, EventArgs e)
        {
            int pos;
            pos = Array.BinarySearch(vector, 9);
            listBox_Vec.Items.Clear();
            listBox_Vec.Items.Add("En la posicionposición " + pos + " se encuentra el número 9");
        }

        private void button_LimitesVec_Click(object sender, EventArgs e)
        {
            int sup;
            int inf;
            listBox_Vec.Items.Clear();
            sup = vector.GetUpperBound(0);
            inf = vector.GetLowerBound(0);
            listBox_Vec.Items.Add("El límite inferior es " + inf + " y el superior es " + sup);
        }
    }
}
