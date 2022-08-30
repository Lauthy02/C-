namespace ParteC
{
    partial class MDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laboratorios2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesFecha1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesFecha2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesFecha3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratorios2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laboratorios2ToolStripMenuItem
            // 
            this.laboratorios2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesFecha1ToolStripMenuItem,
            this.operacionesFecha2ToolStripMenuItem,
            this.operacionesFecha3ToolStripMenuItem});
            this.laboratorios2ToolStripMenuItem.Name = "laboratorios2ToolStripMenuItem";
            this.laboratorios2ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.laboratorios2ToolStripMenuItem.Text = "Laboratorios2";
            // 
            // operacionesFecha1ToolStripMenuItem
            // 
            this.operacionesFecha1ToolStripMenuItem.Name = "operacionesFecha1ToolStripMenuItem";
            this.operacionesFecha1ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.operacionesFecha1ToolStripMenuItem.Text = "Operaciones fecha 1";
            this.operacionesFecha1ToolStripMenuItem.Click += new System.EventHandler(this.operacionesFecha1ToolStripMenuItem_Click);
            // 
            // operacionesFecha2ToolStripMenuItem
            // 
            this.operacionesFecha2ToolStripMenuItem.Name = "operacionesFecha2ToolStripMenuItem";
            this.operacionesFecha2ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.operacionesFecha2ToolStripMenuItem.Text = "Operaciones fecha 2";
            this.operacionesFecha2ToolStripMenuItem.Click += new System.EventHandler(this.operacionesFecha2ToolStripMenuItem_Click);
            // 
            // operacionesFecha3ToolStripMenuItem
            // 
            this.operacionesFecha3ToolStripMenuItem.Name = "operacionesFecha3ToolStripMenuItem";
            this.operacionesFecha3ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.operacionesFecha3ToolStripMenuItem.Text = "Operaciones fecha 3";
            this.operacionesFecha3ToolStripMenuItem.Click += new System.EventHandler(this.operacionesFecha3ToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Parte C";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laboratorios2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesFecha1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesFecha2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesFecha3ToolStripMenuItem;
    }
}

