using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParteB
{
    public partial class Form_ParteB : Form
    {
        public Form_ParteB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Value = 30;
            vScrollBar1.Value = 50;
            label_ScrollBHorizontal.Text = "El Scroll Horizontal representa " + (this.hScrollBar1.Value).ToString();
            label_ScrollBVertical.Text = "El Scroll Vetical representa " + (this.vScrollBar1.Value).ToString();
            MessageBox.Show(label_ScrollBHorizontal.Text);
        }

        #region Calculadora simple
        private void button_Suma_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text = Convert.ToString(Convert.ToInt32(textBox_Operador1.Text) + Convert.ToInt32(textBox_Operador2.Text));
        }

        private void button_Resta_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text = Convert.ToString(int.Parse(textBox_Operador1.Text) - int.Parse(textBox_Operador2.Text));
        }

        private void button_Cociente_Click(object sender, EventArgs e)
        {
            int Nro1 = Int32.Parse(textBox_Operador1.Text);
            int Nro2 = Int32.Parse(textBox_Operador2.Text);
            if (Nro2 != 0)
            {
                textBox_Resultado.Text = (Int32.Parse(textBox_Operador1.Text) / Int32.Parse(textBox_Operador2.Text)).ToString();
            }
        }

        private void button_Producto_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text = Convert.ToString(int.Parse(textBox_Operador1.Text) * int.Parse(textBox_Operador2.Text));
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBox_Operador1.Text = "";
            textBox_Operador2.Text = null;
            textBox_Resultado.Text = string.Empty;
            this.textBox_Operador1.Focus();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

        #region ProgressBar
        private void button_IniciaTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button_DetenerTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        int ConteoDelTimer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //El tiempo se mide en ms por default con los 3 díjitos (200=2ms)
            //El tiempo se mide en segs si pongo un dígito mas (2000=2segs
            ConteoDelTimer++;
            progressBar1.Value = ConteoDelTimer;
            label_ValorTimerProgress.Text = Convert.ToString(ConteoDelTimer);
        }
        #endregion

        #region ScrollBar
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label_ScrollBVertical.Text = Convert.ToString(vScrollBar1.Value);
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label_ScrollBHorizontal.Text = Convert.ToString(hScrollBar1.Value);
        }
        #endregion

        #region MessageBox
        private void button_MessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted apretó el botón.","BOTÓN APRETADO");
        }
        
        private void button_MessageBoxYS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted apretó el botón", "BOTÓN APRETADO",MessageBoxButtons.YesNo);
        }
        
        private void utton_MessageBoxYSAsterisk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted apretó el botón", "BOTÓN APRETADO", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
        }

        #endregion


    }
}
