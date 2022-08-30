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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void operacionesFecha1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OperacionesFecha1 FOF1 = new Form_OperacionesFecha1();
            FOF1.MdiParent = this;
            FOF1.Show();
        }

        private void operacionesFecha2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OperacionesFecha2 FOF2 = new Form_OperacionesFecha2();
            FOF2.MdiParent = this;
            FOF2.Show();
        }

        private void operacionesFecha3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OperacionesFecha3 FOF3 = new Form_OperacionesFecha3();
            FOF3.MdiParent = this;
            FOF3.Show();
        }
    }
}
