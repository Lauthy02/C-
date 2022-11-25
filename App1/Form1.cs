using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Agregar esta librería para poder trabajar con archivos

namespace App1 //Programa de la clase 8 fecha 21/10/22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Ingreso.Text != "") //Si el textbox no está vacío entro al if
                {
                    //Declaro el camino y el nombre del archivo, el modo de aperura, el tipo de acceso (lectura/escritura)
                    FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App1\Salida.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter SW = new StreamWriter(FS);

                    // SW.Write imprime un caracter
                    // SW.WriteLine imprime una línea
                    SW.WriteLine(textBox_Ingreso.Text);
                    textBox_Ingreso.Text = "";
                    
                    SW.Close();
                    FS.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese un valor");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            PonerDatosEnTextobx();
        }

        private void PonerDatosEnTextobx()
        {
            try
            {
                textBox_Salida.Text = "";
                textBox_Salida.Text = String.Empty;

                FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App1\Salida.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader SR = new StreamReader(FS);
                string LineaDelArchivo = SR.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_Salida.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR.ReadLine();
                }

                SR.Close();
                FS.Close();
                textBox_Ingreso.Text = "";
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}