using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParteA
{
    public partial class Form_Timer : Form
    {
        public Form_Timer()
        {
            InitializeComponent();
        }
        int hora = 0, min = 0, seg = 0;

        private void button_Inicializar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label_Crono.Text = "00:00:00";
            seg = 0;
            min = 0;
            hora = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            else if (min == 60)
            {
                hora++;
                min = 0;
            }
            label_Crono.Text = hora.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');
        }

        private void button_Parar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button_Comenzar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
