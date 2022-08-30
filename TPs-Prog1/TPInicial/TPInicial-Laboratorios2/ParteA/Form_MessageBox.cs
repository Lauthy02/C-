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
    public partial class Form_MessageBox : Form
    {
        public Form_MessageBox()
        {
            InitializeComponent();
        }
        string TitMsj = "ATENCIÓN";
        string Msj = "Ud apretó el botón";
        private void button_MSJ1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Msj, TitMsj);
        }

        private void button_MSJ2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Msj, TitMsj, MessageBoxButtons.YesNo);
        }

        private void button_MSJ3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Msj, TitMsj, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }
    }
}
