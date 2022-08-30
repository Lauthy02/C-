using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParteA
{
    public partial class Form_ProgressBar : Form
    {
        public Form_ProgressBar()
        {
            InitializeComponent();
        }

        private void button_Comenzar_Click(object sender, EventArgs e)
        {
            long contador;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            while ((progressBar1.Value < progressBar1.Maximum))
            {
                progressBar1.Value++;
                for (contador = 1; (contador <= 1000000); contador++)
                {

                }
            }
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
