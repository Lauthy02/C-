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
    public partial class Form_MDI : Form
    {
        public Form_MDI()
        {
            InitializeComponent();
        }

        private void manejoDeLosRadiobuttonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RadioButtons FRB = new Form_RadioButtons();
            FRB.MdiParent = this;
            FRB.Show();
        }

        private void manejoDelGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListBox FLB = new Form_ListBox();
            FLB.MdiParent = this;
            FLB.Show();
        }

        private void manejoDelCheckboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CheckBox FCB = new Form_CheckBox();
            FCB.MdiParent = this;
            FCB.Show();
        }
    }
}
