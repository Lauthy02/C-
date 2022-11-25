using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2 //Programa de la clase 9 fecha 28/10/22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Generar_Click(object sender, EventArgs e)
        {
            escribir("Listado de facturas ordenadas por nro de factura");
            escribir("Fecha de emisón: " + (DateTime.Today).ToString());
            escribir("------------------------------------------------------------");
            escribir("          Nro. Fact | Nro. Client | Apellido y Nombre | Fecha | Estado");
            escribir("------------------------------------------------------------");

            FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App2\Datos\Cabecera.csv", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);

            float Aux = 0f;
            string LineaDelArchivo = "";
            string[] VectorF = new string[0];
            LineaDelArchivo = SR.ReadLine();
            LineaDelArchivo = SR.ReadLine();
            while (LineaDelArchivo != null)
            {
                VectorF = LineaDelArchivo.Split(';');
                string NroFact = VectorF[0];
                string NroClie = VectorF[1];
                string NroFech = VectorF[2];
                string Importe = VectorF[3];
                string Estado = VectorF[4];

                string ApeYNom = dameCliente(VectorF[1]);

                escribir("\t" + NroFact + "\t " + NroClie + "\t" + ApeYNom + "\t" + NroFech + "\t" + Estado);
                escribir("Detalle:");
                escribir("==========================================================");
                escribir(dameDetalle(VectorF[0], out float total));
                escribir("Importe Total: " + total.ToString());
                escribir("\n==========================================================");
                Aux += total;
                LineaDelArchivo = SR.ReadLine();
            }
            escribir("La suma de todas las Facturas es " + Aux.ToString());
            SR.Close();
            FS.Close();
            imprimirEnTextbox();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Funciones

        private string dameDetalle(string NumFactura, out float total)
        {
            FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App2\Datos\DetalleF.csv", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);

            total = 0;
            string LineaDelArchivo = "";
            string[] VectorDetalle = new string[0];
            string Detalle = "";
            LineaDelArchivo = SR.ReadLine();
            LineaDelArchivo = SR.ReadLine();
            while (LineaDelArchivo != null)
            {
                VectorDetalle = LineaDelArchivo.Split(';');
                if (VectorDetalle[0] == NumFactura)
                {
                    while (LineaDelArchivo!=null && VectorDetalle[0] == NumFactura)
                    {
                        VectorDetalle = LineaDelArchivo.Split(';');
                        Detalle += VectorDetalle[1] + " " + VectorDetalle[1] + " " + VectorDetalle[2] + " " + VectorDetalle[5] + Environment.NewLine;
                        total += float.Parse(VectorDetalle[1]) * float.Parse(VectorDetalle[4]);
                        LineaDelArchivo = SR.ReadLine();
                    }
                }
                LineaDelArchivo = SR.ReadLine();
            }
            if (Detalle == "")
            {
                MessageBox.Show("Error: Falta artículo");
            }
           
            SR.Close();
            FS.Close();
            return Detalle;
        }

        private string dameCliente(string ClaveCliente)
        {
            FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App2\Datos\Clientes.csv", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);

            string LineaDelArchivo = "";
            string[] VectorClien = new string[0];
            string ApeNom = "";
            LineaDelArchivo = SR.ReadLine();
            LineaDelArchivo = SR.ReadLine();
            while (LineaDelArchivo != null)
            {
                VectorClien = LineaDelArchivo.Split(';');
                if (VectorClien[0] == ClaveCliente)
                {
                    ApeNom = VectorClien[1] + "," + VectorClien[2];
                    SR.Close();
                    FS.Close();
                    return ApeNom;
                }
                LineaDelArchivo = SR.ReadLine();
            }
            MessageBox.Show("ERROR: Cliente no encontrado");
            SR.Close();
            FS.Close();
            return ApeNom;
        }

        private void escribir(string datos)
        {
            FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App2\Datos\Salida.txt", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine(datos);

            SW.Close();
            FS.Close();
        }

        private void imprimirEnTextbox()
        {
            textBox1.Text = "";

            FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App2\Datos\Salida.txt", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);

            string LineaDelArchivo = SR.ReadLine();
            while (LineaDelArchivo != null)
            {
                textBox1.Text += LineaDelArchivo + Environment.NewLine;
                LineaDelArchivo = SR.ReadLine();
            }

            SR.Close();
            FS.Close();
        }
        #endregion

        #region Sin Uso
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


    }
}