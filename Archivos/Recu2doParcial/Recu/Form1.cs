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

namespace Recu
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

                MessageBox.Show("No olvide apretar el botón 'Persistir' para ver los archivos actualizados e ir a la pestaña 'Visualización de archivos'.");
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
        }

        private void button_Baja_Click(object sender, EventArgs e)
        {
            const string mensaje = "¿Seguro que quiere dar de baja?";
            const string titulo = "Baja";
            var resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resultado == DialogResult.Yes)
            {
                DataGridViewRow FilaSeleccionada = new DataGridViewRow();
                FilaSeleccionada = dataGridView1.CurrentRow;
                dataGridView1.Rows.Remove(FilaSeleccionada);
                
                button_Persistir.Enabled = true;
                MessageBox.Show("No olvide apretar el botón 'Persistir' para ver los archivos actualizados e ir a la pestaña 'Visualización de archivos'.");
            }
        }

        private void button_Modific_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón no realizado :-(");
        }

        private void button_Persistir_Click(object sender, EventArgs e)
        {
            guardarEnMaestro();

            if (File.Exists(@"Secos.csv") || File.Exists(@"Frescos.csv") || File.Exists(@"BebCola.csv") || File.Exists(@"BebAlco.csv"))
            {
                File.Delete(@"Secos.csv");
                File.Delete(@"Frescos.csv");
                File.Delete(@"BebCola.csv");
                File.Delete(@"BebAlco.csv");
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
                    case "Secos":
                        guardarEnSecos(LineaDelArchivo);
                        break;
                    case "Frescos":
                        guardarEnFrescos(LineaDelArchivo);
                        break;
                    case "Bebidas Cola":
                        guardarEnBebCola(LineaDelArchivo);
                        break;
                    case "Bebidas Alcoholicas":
                        guardarEnBebAlco(LineaDelArchivo);
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

        private void button_VerArchivos_Click(object sender, EventArgs e)
        {
            verArchivosEnTextbox();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //-----------------------------------------------------------------------------------------------------

        #region Métodos
        private void verArchivosEnTextbox()
        {
            ponerEnTextboxArchMaestro();
            ponerEnTextboxArchSecos();
            ponerEnTextboxArchFrescos();
            ponerEnTextboxArchBebCola();
            ponerEnTextboxArchBebAlco();
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

        private void ponerEnTextboxArchSecos()
        {
            if (File.Exists(@"Secos.csv"))
            {
                textBox_VerSecos.Text = String.Empty;

                FileStream FS10 = new FileStream(@"Secos.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR10 = new StreamReader(FS10);

                string LineaDelArchivo = SR10.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_VerSecos.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR10.ReadLine();
                }
                SR10.Close();
                FS10.Close();
            }
            else
            {
                MessageBox.Show("Archivo Secos.csv no existe");
            }
        }

        private void ponerEnTextboxArchFrescos()
        {
            if (File.Exists(@"Frescos.csv"))
            {
                textBox_VerFrescos.Text = String.Empty;

                FileStream FS10 = new FileStream(@"Frescos.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR10 = new StreamReader(FS10);

                string LineaDelArchivo = SR10.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_VerFrescos.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR10.ReadLine();
                }
                SR10.Close();
                FS10.Close();
            }
            else
            {
                MessageBox.Show("Archivo Frescos.csv no existe");
            }
        }

        private void ponerEnTextboxArchBebCola()
        {
            if (File.Exists(@"BebCola.csv"))
            {
                textBox_VerBebCola.Text = String.Empty;

                FileStream FS10 = new FileStream(@"BebCola.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR10 = new StreamReader(FS10);

                string LineaDelArchivo = SR10.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_VerBebCola.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR10.ReadLine();
                }
                SR10.Close();
                FS10.Close();
            }
            else
            {
                MessageBox.Show("Archivo BebCola.csv no existe");
            }
        }

        private void ponerEnTextboxArchBebAlco()
        {
            if (File.Exists(@"BebAlco.csv"))
            {
                textBox_VerBebAlc.Text = String.Empty;

                FileStream FS10 = new FileStream(@"BebAlco.csv", FileMode.Open, FileAccess.Read);
                StreamReader SR10 = new StreamReader(FS10);

                string LineaDelArchivo = SR10.ReadLine();
                while (LineaDelArchivo != null)
                {
                    textBox_VerBebAlc.Text += LineaDelArchivo + Environment.NewLine;
                    LineaDelArchivo = SR10.ReadLine();
                }
                SR10.Close();
                FS10.Close();
            }
            else
            {
                MessageBox.Show("Archivo BebAlco.csv no existe");
            }
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

        private void guardarEnSecos(string linea)
        {
            if (!File.Exists(@"Secos.csv"))
            {
                FileStream FS0 = new FileStream(@"Secos.csv", FileMode.Create);
                FS0.Close();
            }

            FileStream FS = new FileStream(@"Secos.csv", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine(linea);

            SW.Close();
            FS.Close();
        }

        private void guardarEnFrescos(string linea)
        {
            if (!File.Exists(@"Frescos.csv"))
            {
                FileStream FS0 = new FileStream(@"Frescos.csv", FileMode.Create);
                FS0.Close();
            }

            FileStream FS = new FileStream(@"Frescos.csv", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine(linea);

            SW.Close();
            FS.Close();
        }

        private void guardarEnBebCola(string linea)
        {
            if (!File.Exists(@"BebCola.csv"))
            {
                FileStream FS0 = new FileStream(@"BebCola.csv", FileMode.Create);
                FS0.Close();
            }

            FileStream FS = new FileStream(@"BebCola.csv", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine(linea);

            SW.Close();
            FS.Close();
        }

        private void guardarEnBebAlco(string linea)
        {
            if (!File.Exists(@"BebAlco.csv"))
            {
                FileStream FS0 = new FileStream(@"BebAlco.csv", FileMode.Create);
                FS0.Close();
            }

            FileStream FS = new FileStream(@"BebAlco.csv", FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine(linea);

            SW.Close();
            FS.Close();
        }

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
    }
}
