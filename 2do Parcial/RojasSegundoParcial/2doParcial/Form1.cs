using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2doParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Persistir.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            llenarDataGrid();
        }
    
        #region Botones
        private void button_Alta_Click(object sender, EventArgs e)
        {
            if (Ok())
            {
                button_Persistir.Enabled = true;

                string[] datos = new string[5];
                datos[0] = textBox_Codigo.Text;
                datos[1] = textBox_Nombre.Text;
                datos[2] = numericUpDown_Precio.Value.ToString();
                datos[3] = textBox_Rubro.Text;
                datos[4] = textBox_Fecha.Text;

                dataGridView1.Rows.Add(datos);
                
                limpiar();

                MessageBox.Show("No olvide apretar el botón 'Persistir' para ver los archivos actualizados");
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
        }

        private void button_Persistir_Click(object sender, EventArgs e)
        {
            guardarEnMaestro();

            if (File.Exists(@"DeMano.csv") || File.Exists(@"ElectricasDeMano.csv") || File.Exists(@"ElectricasDeMesa.csv") || File.Exists(@"MaqinasIndustriales.csv"))
            {
                File.Delete(@"DeMano.csv");
                File.Delete(@"ElectricasDeMano.csv");
                File.Delete(@"ElectricasDeMesa.csv");
                File.Delete(@"MaqinasIndustriales.csv");
            }

            FileStream FS = new FileStream(@"Maestro.csv", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);

            string LineaDelArchivo = "";
            string[] VectorDeLinea = new string[0];

            LineaDelArchivo = SR.ReadLine();//Línea con datos

            while (LineaDelArchivo != null)
            {
                VectorDeLinea = LineaDelArchivo.Split(';');

                string Rubro = VectorDeLinea[3];

                switch (Rubro)
                {
                    
                    case "De mano":
                        guardarEnDeMano(LineaDelArchivo);
                        break;
                    case "Electricas de mano":
                        guardarEnElecDeMano(LineaDelArchivo);
                        break;
                    case "Electricas de mesa":
                        guardarEnElecDeMesa(LineaDelArchivo);
                        break;
                    case "Maquinas industriales":
                        guardarEnMaqInd(LineaDelArchivo);
                        break;
                    default:
                        MessageBox.Show("Rubro equivocado");
                        break;
                }
                LineaDelArchivo = SR.ReadLine();
            }
            button_Persistir.Enabled = false;
            SR.Close();
            FS.Close();
        }

        private void button_Baja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón no realizado :-(");
        }

        private void button_Modific_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón no realizado :-(");
        }

        private void button_VerArchivos_Click(object sender, EventArgs e)
        {
            ponerDatosEnTextbox();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos

        #region Llenar el Data Grid
        private void llenarDataGrid()
        {
            if (File.Exists(@"Maestro.csv"))
            {
                FileStream FS = new FileStream(@"Maestro.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(FS);

                string LineaDelArchivo = "";
                string[] VectorDeLinea = new string[0];

                LineaDelArchivo = SR.ReadLine();//Línea con datos

                while (LineaDelArchivo != null)
                {
                    VectorDeLinea = LineaDelArchivo.Split(';');

                    dataGridView1.Rows.Add(VectorDeLinea);

                    LineaDelArchivo = SR.ReadLine();
                }
                SR.Close();
                FS.Close();
            }
        }
        #endregion

        #region Guardar en los archivos

        private void guardarEnMaqInd(string linea)
        {
            if (!File.Exists(@"MaqinasIndustriales.csv"))
            {
                FileStream FS0 = new FileStream(@"MaqinasIndustriales.csv", FileMode.Create);
                FS0.Close();
            }

            FileStream FS = new FileStream(@"MaqinasIndustriales.csv", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine(linea);

            SW.Close();
            FS.Close();
        }

        private void guardarEnElecDeMesa(string linea)
        {
            if (!File.Exists(@"ElectricasDeMesa.csv"))
            {
                FileStream FS0 = new FileStream(@"ElectricasDeMesa.csv", FileMode.Create);
                FS0.Close();
            }

            FileStream FS = new FileStream(@"ElectricasDeMesa.csv", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine(linea);

            SW.Close();
            FS.Close();
        }

        private void guardarEnElecDeMano(string linea)
        {
            if (!File.Exists(@"ElectricasDeMano.csv"))
            {
                FileStream FS0 = new FileStream(@"ElectricasDeMano.csv", FileMode.Create);
                FS0.Close();
            }

            FileStream FS = new FileStream(@"ElectricasDeMano.csv", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine(linea);

            SW.Close();
            FS.Close();
        }

        private void guardarEnDeMano(string linea)
        {
            if (!File.Exists(@"DeMano.csv"))
            {
                FileStream FS0 = new FileStream(@"DeMano.csv", FileMode.Create);
                FS0.Close();
            }

            FileStream FS = new FileStream(@"DeMano.csv", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine(linea); 

            SW.Close();
            FS.Close();
        }

        private void guardarEnMaestro()
        {
            if (!File.Exists(@"Maestro.csv"))
            {
                FileStream FS0 = new FileStream(@"Maestro.csv", FileMode.Create);
                FS0.Close();
            }

            FileStream FS11 = new FileStream(@"Maestro.csv", FileMode.Truncate, FileAccess.Write);
            StreamWriter SW11 = new StreamWriter(FS11);

            foreach (DataGridViewRow dataGrid in dataGridView1.Rows)
            {
                if (dataGrid.Cells[0].Value != null || dataGrid.Cells[1].Value != null || dataGrid.Cells[2].Value != null || dataGrid.Cells[3].Value != null || dataGrid.Cells[4].Value != null)
                {
                    string cadena = "";
                    string separador = ";";
                    cadena += dataGrid.Cells[0].Value + separador;
                    cadena += dataGrid.Cells[1].Value + separador;
                    cadena += dataGrid.Cells[2].Value + separador;
                    cadena += dataGrid.Cells[3].Value + separador;
                    cadena += dataGrid.Cells[4].Value + separador;

                    SW11.WriteLine(cadena);
                }
            }
            SW11.Close();
            FS11.Close();
        }
        #endregion

        #region Generales

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Rubro.SelectedIndex != -1)
            {
                textBox_Rubro.Text = comboBox_Rubro.SelectedItem.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("No puede elegir una fecha futura");
            }
            else
            {
                textBox_Fecha.Text = dateTimePicker1.Value.ToString();
            }
        }

        private void limpiar()
        {
            textBox_Codigo.Text = string.Empty;
            textBox_Nombre.Text = string.Empty;
            numericUpDown_Precio.Value = 0;
            textBox_Rubro.Text = string.Empty;
            textBox_Fecha.Text = string.Empty;
        }

        private bool Ok()
        {
            bool ok = false;
            if (textBox_Codigo.Text != "" && textBox_Nombre.Text != "" && textBox_Rubro.Text != "" && textBox_Fecha.Text != "" && numericUpDown_Precio.Value.ToString() != "0")
            {
                ok = true;
            }
            return ok;
        }
        #endregion

        #region Poner los archivos en los textbox

        private void ponerDatosEnTextbox()
        {
            ponerEnTextboxArchMaestro();
            ponerEnTextboxArchDeMano();
            ponerEnTextboxArchElectricasDeMano();
            ponerEnTextboxArchElectricasDeMesa();
            ponerEnTextboxArchMaqinasIndustriales();
        }

        private void ponerEnTextboxArchMaqinasIndustriales()
        {
            if (File.Exists(@"MaqinasIndustriales.csv"))
            {
                textBox_VerMaqInd.Text = String.Empty;

                FileStream FS = new FileStream(@"MaqinasIndustriales.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(FS);

                string LineaDelArchivo = SR.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_VerMaqInd.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR.ReadLine();
                }

                SR.Close();
                FS.Close();
            }
            else
            {
                MessageBox.Show("Archivo MaquinasIndustriales.csv no existe");
            }
        }

        private void ponerEnTextboxArchElectricasDeMesa()
        {   
            if (File.Exists(@"ElectricasDeMesa.csv"))
            {
                textBox_VerElecDeMesa.Text = String.Empty;

                FileStream FS = new FileStream(@"ElectricasDeMesa.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(FS);

                string LineaDelArchivo = SR.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_VerElecDeMesa.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR.ReadLine();
                }

                SR.Close();
                FS.Close();
            }
            else
            {
                MessageBox.Show("Archivo ElectricasDeMesa.csv no existe");
            }
        }

        private void ponerEnTextboxArchElectricasDeMano()
        {
            if (File.Exists(@"ElectricasDeMano.csv"))
            {
                textBox_VerElecDeMano.Text = String.Empty;

                FileStream FS = new FileStream(@"ElectricasDeMano.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(FS);

                string LineaDelArchivo = SR.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_VerElecDeMano.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR.ReadLine();
                }

                SR.Close();
                FS.Close();
            }
            else
            {
                MessageBox.Show("Archivo ElectricasDeMano.csv no existe");
            }
        }

        private void ponerEnTextboxArchDeMano()
        {
            if (File.Exists(@"DeMano.csv"))
            {
                textBox_VerDeMano.Text = String.Empty;

                FileStream FS = new FileStream(@"DeMano.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(FS);

                string LineaDelArchivo = SR.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_VerDeMano.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR.ReadLine();
                }

                SR.Close();
                FS.Close();
            }
            else
            {
                MessageBox.Show("Archivo DeMano.csv no existe");
            }
        }

        private void ponerEnTextboxArchMaestro()
        {
            if (File.Exists(@"Maestro.csv"))
            {
                textBox_VerMaestro.Text = String.Empty;

                FileStream FS10 = new FileStream(@"Maestro.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR10 = new StreamReader(FS10);

                string LineaDelArchivo = SR10.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_VerMaestro.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR10.ReadLine();
                }
                SR10.Close();
                FS10.Close();
            }
            else
            {
                MessageBox.Show("Archivo Maestro.csv no existe");
            }
        }
        #endregion
        #endregion

        #region Sin uso
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}