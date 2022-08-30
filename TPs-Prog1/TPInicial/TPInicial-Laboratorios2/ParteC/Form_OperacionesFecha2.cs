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
    public partial class Form_OperacionesFecha2 : Form
    {
        public Form_OperacionesFecha2()
        {
            InitializeComponent();
        }

        private void button_Diferencia_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = this.dateTimePicker1.Value;
            DateTime fecha2 = this.dateTimePicker2.Value;
            textBox1.Text = fecha1.Subtract(fecha2).ToString();
        }
    }
}
