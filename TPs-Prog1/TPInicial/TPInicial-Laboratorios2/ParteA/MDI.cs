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
    public partial class MDI : Form
    {
        public MDI()
        {
            AllocConsole();
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")] 
        private static extern bool AllocConsole();

        private void Form1_Load(object sender, EventArgs e)
        {

        } 

        private void cargaOperaciónDeVectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Carga_OperaciónVectores FCOV = new Form_Carga_OperaciónVectores();
            FCOV.MdiParent = this;
            FCOV.Show();
        }

        private void matricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Matrices FM = new Form_Matrices();
            FM.MdiParent = this;
            FM.Show();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Timer FT = new Form_Timer();
            FT.MdiParent = this;
            FT.Show();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ProgressBar FP = new Form_ProgressBar();
            FP.MdiParent = this;
            FP.Show();
        }

        private void scrollBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ScrollBar FS = new Form_ScrollBar();
            FS.MdiParent = this;
            FS.Show();
        }

        private void messageBozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MessageBox FMB = new Form_MessageBox();
            FMB.MdiParent = this;
            FMB.Show();
        }

        #region SinUso
        private void button_CargaVec_Click(object sender, EventArgs e)
        {

        }

        private void button_CargaMat_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
