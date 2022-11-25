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
using System.IO;

namespace App3 //Programa de la clase 10 fecha 11/11/22 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button_Persistr.Enabled = false;
            button_Generar.Enabled = false;
        }


        private void comboBox_Carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Carrera.SelectedIndex != -1)
            {
                textBox_Carrera.Text = comboBox_Carrera.SelectedItem.ToString();
            }
        }

        private void comboBox_Catedra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Catedra.SelectedIndex != -1)
            {
                textBox_Catedra.Text = comboBox_Catedra.SelectedItem.ToString();
            }
        }

        private void comboBox_Alumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Alumno.SelectedIndex != -1)
            {
                textBox_Alumno.Text = comboBox_Alumno.SelectedItem.ToString();
            }
        }

        #region Botones
        private void button_Agregar_Click(object sender, EventArgs e)
        {
            if (Ok())
            {
                button_Persistr.Enabled = true;

                string[] datos = new string[3];
                datos[0] = textBox_Carrera.Text;
                datos[1] = textBox_Catedra.Text;
                datos[2] = textBox_Alumno.Text;

                dataGridView1.Rows.Add(datos);
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
            limpiar();
        }

        private void button_Persistr_Click(object sender, EventArgs e)
        {
            FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App3\Datos\ListaDeInscriptos.csv", FileMode.Truncate, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine("Carrera ; Catedra ; Alumno");

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells[0].Value != null || dr.Cells[1].Value != null || dr.Cells[2].Value != null)
                {
                    string cadena = "";
                    string separador = ";";
                    cadena += dr.Cells[0].Value + separador;
                    cadena += dr.Cells[1].Value + separador;
                    cadena += dr.Cells[2].Value + separador;

                    SW.WriteLine(cadena);
                }
            }

            SW.Close();
            FS.Close();

            button_Generar.Enabled = true;
        }

        private void button_Generar_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App3\Datos\ListaDeInscriptosOrdenado.csv"))
            {
                File.Delete(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App3\Datos\ListaDeInscriptosOrdenado.csv");
            }

            FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App3\Datos\ListaDeInscriptos.csv", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);

            string LineaDelArchivo = "";
            string[] VectorDeLinea = new string[0];

            LineaDelArchivo = SR.ReadLine();
            LineaDelArchivo = SR.ReadLine();

            escribir("Listado de alumnos ordenados");
            escribir("-------------------------------------------------");

            //Corte de control
            while (LineaDelArchivo != null)
            {
                VectorDeLinea = LineaDelArchivo.Split(';');
                string Carrera = VectorDeLinea[0];
                int TotalAlumnos = 0;
                int CuanAlumnXCarr = 0;

                escribir("Carrera: " + Carrera);
                while (LineaDelArchivo != null && Carrera == VectorDeLinea[0])
                {
                    string Catedra = VectorDeLinea[1];
                    int CuanAlumnXCat = 0;

                    escribir("Catedra: " + Catedra);
                    while (LineaDelArchivo != null && Carrera == VectorDeLinea[0] && Catedra == VectorDeLinea[1])
                    {
                        VectorDeLinea = LineaDelArchivo.Split(';');
                        CuanAlumnXCat++;
                        escribir(VectorDeLinea[2]);//Escribe el alumno q pertenece a esa carrera y a esa catedra
                        LineaDelArchivo = SR.ReadLine();
                    }
                    escribir("Total de alumnos de la catedra: " + Catedra + " son: " + CuanAlumnXCat.ToString());
                    CuanAlumnXCarr += CuanAlumnXCat;
                    CuanAlumnXCat = 0;
                }
                escribir("Total de alumnos de la carreta: " + Carrera + " son: " + CuanAlumnXCarr.ToString());
                TotalAlumnos += CuanAlumnXCarr;
                CuanAlumnXCarr = 0;
            }

            SR.Close();
            FS.Close();

            FileStream FS2 = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App3\Datos\ListaDeInscriptosOrdenado.csv", FileMode.Open, FileAccess.Read);
            StreamReader SR2 = new StreamReader(FS2);

            textBox_Resumen.Text = SR2.ReadToEnd();

            SR2.Close();
            FS2.Close();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones
        private void limpiar()
        {
            textBox_Carrera.Text = "";
            textBox_Catedra.Text = "";
            textBox_Alumno.Text = "";
        }

        private bool Ok()
        {
            bool ok = false;
            if (textBox_Carrera.Text != "" && textBox_Catedra.Text != "" && textBox_Alumno.Text != "")
            {
                ok = true;
            }
            return ok;
        }

        private void escribir(string datos)
        {
            FileStream FS = new FileStream(@"C:\Users\Lauta\OneDrive\Desktop\2do Parcial\2doParcial\App3\Datos\ListaDeInscriptosOrdenado.csv", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.Write(datos);

            SW.Close();
            FS.Close();    

        }

        #endregion
    }
}
