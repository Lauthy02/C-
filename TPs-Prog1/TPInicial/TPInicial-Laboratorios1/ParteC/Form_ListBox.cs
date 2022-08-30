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
    public partial class Form_ListBox : Form
    {
        public Form_ListBox()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_Mostrar_Click(object sender, EventArgs e)
        {
            if (radioButton_1erValor.Checked)
            {
                radioButton_1erValor.Checked = false;
                listBox1.Items.Add(textBox_1erValor.Text);
            }
            if (radioButton_2doValor.Checked)
            {
                radioButton_2doValor.Checked = false;
                listBox1.Items.Add(textBox_2doValor.Text);
            }
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_LimpiarLista_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
