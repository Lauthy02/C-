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
    public partial class Form_CheckBox : Form
    {
        public Form_CheckBox()
        {
            InitializeComponent();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Ejecutar_Click(object sender, EventArgs e)
        {
            if (this.checkBox_1erEleccion.Checked == true & this.checkBox_2daEleccion.Checked == false) 
            {
                label1.BackColor = Color.Aquamarine;
                label2.BackColor = Color.Beige;
                label3.BackColor = Color.Black;
            }
            if (checkBox_1erEleccion.Checked == false & checkBox_2daEleccion.Checked == true) 
            {
                label1.BackColor = Color.Green;
                label2.BackColor = Color.LightPink;
                label3.BackColor = Color.Linen;
            }
            if (checkBox_1erEleccion.Checked == true & checkBox_2daEleccion.Checked == true)
            {
                label1.BackColor = Color.Blue;
                label2.BackColor = Color.White;
                label3.BackColor = Color.Blue;
            }
        }
    }
}
