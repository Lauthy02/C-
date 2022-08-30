using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParteB
{
    public partial class Form_FormatoStrings : Form
    {
        public Form_FormatoStrings()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_Ejecutar_Click(object sender, EventArgs e)
        {
            string variable = textBox1.Text;
            textBox2.Text = variable.Length.ToString();
            if ((txtdato.Text.Length > 0))
            {
                int pos = Convert.ToInt32(txtdato.Text);
                textBox3.Text = (variable[pos]).ToString();
            }
            textBox4.Text = variable.Insert(3, "12345");
            textBox5.Text = variable.TrimStart();
            if ((variable.Length < 10))
            {
                textBox7.Text = variable.PadRight(10, '0');
            }
            textBox8.Text = string.Concat(textBox9.Text, variable);
            if (textBox6.Text == "ABC")
            {
                textBox6.Text = "Si";
            }
            else
            {
                textBox6.Text = "No";
            }
        }
    }
}
