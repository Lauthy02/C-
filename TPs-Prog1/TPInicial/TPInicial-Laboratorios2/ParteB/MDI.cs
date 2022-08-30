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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void formatosDeNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_FormatoNumeros FFN = new Form_FormatoNumeros();
            FFN.MdiParent = this;
            FFN.Show();
        }

        private void formatoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_FormatoFechas FFF = new Form_FormatoFechas();
            FFF.MdiParent = this;
            FFF.Show();
        }

        private void formatoDeStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_FormatoStrings FFS = new Form_FormatoStrings();
            FFS.MdiParent = this;
            FFS.Show();
        }

        private void laboratorios2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
