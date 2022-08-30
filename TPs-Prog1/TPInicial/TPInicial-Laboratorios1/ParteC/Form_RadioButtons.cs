using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParteC
{
    public partial class Form_RadioButtons : Form
    {
        public Form_RadioButtons()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            this.textBox_1erOperador.Text = null;
            this.textBox_2doOperador.Text = null;
            this.textBox_Respuesta.Text = null;
        }

        private void button_ConIf_Click(object sender, EventArgs e)
        {
            if (this.radioButton_Suma.Checked)
            {
                this.textBox_Respuesta.Text = (Convert.ToInt32(this.textBox_1erOperador.Text) + Convert.ToInt32(this.textBox_2doOperador.Text)).ToString();
            }
            if (this.radioButton_Resta.Checked)
            {
                this.textBox_Respuesta.Text = (Convert.ToInt32(this.textBox_1erOperador.Text) - Convert.ToInt32(this.textBox_2doOperador.Text)).ToString();
            }
            if (this.radioButton_Producto.Checked)
            {
                this.textBox_Respuesta.Text = (Convert.ToInt32(this.textBox_1erOperador.Text) * Convert.ToInt32(this.textBox_2doOperador.Text)).ToString();
            }
            if (this.radioButton_Cociente.Checked)
            {
                if (int.Parse(this.textBox_2doOperador.Text) != 0) 
                {
                    this.textBox_Respuesta.Text = (Convert.ToInt32(this.textBox_1erOperador.Text) / Convert.ToInt32(this.textBox_2doOperador.Text)).ToString();
                }
            }
        }

        private void button_ConSwitch_Click(object sender, EventArgs e)
        {
            int Opcion = 0;
            if (textBox_1erOperador.Text != null && textBox_2doOperador.Text != null) 
            {
                if (radioButton_Suma.Checked)
                {
                    Opcion = 1;
                }
                if (radioButton_Resta.Checked)
                {
                    Opcion = 2;
                }
                if (radioButton_Producto.Checked)
                {
                    Opcion = 3;
                }
                if (radioButton_Cociente.Checked)
                {
                    if (int.Parse(textBox_2doOperador.Text) != 0) 
                    {
                        Opcion = 4;
                    }
                }
            }
            switch (Opcion)
            {
                case 1: //Suma
                    {
                        this.textBox_Respuesta.Text = (Convert.ToInt32(this.textBox_1erOperador.Text) + Convert.ToInt32(this.textBox_2doOperador.Text)).ToString();
                        break;
                    }
                case 2: //Resta
                    {
                        this.textBox_Respuesta.Text = (Convert.ToInt32(this.textBox_1erOperador.Text) - Convert.ToInt32(this.textBox_2doOperador.Text)).ToString();
                        break;
                    }
                case 3: //Poducto
                    {
                        this.textBox_Respuesta.Text = (Convert.ToInt32(this.textBox_1erOperador.Text) * Convert.ToInt32(this.textBox_2doOperador.Text)).ToString();
                        break;
                    }
                case 4: //Cociente
                    {
                        this.textBox_Respuesta.Text = (Convert.ToInt32(this.textBox_1erOperador.Text) / Convert.ToInt32(this.textBox_2doOperador.Text)).ToString();
                        break;
                    }
                default:
                    {
                        string Mensaje = "La operacion no se puede realizar";
                        string Titulo = "ADVERTENCIA";
                        MessageBoxButtons Botones = MessageBoxButtons.YesNo;
                        DialogResult Resultado;
                        Resultado = MessageBox.Show(Mensaje, Titulo, Botones);
                        if (Resultado == DialogResult.Yes)
                        {
                            button_Limpiar.Enabled = true;
                        }
                        break;
                    }
            }
        }
    }
}
