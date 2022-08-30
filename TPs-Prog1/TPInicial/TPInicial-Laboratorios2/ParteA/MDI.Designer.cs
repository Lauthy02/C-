namespace ParteA
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
            this.cargaOperaciónDeVectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageBozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratorios2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laboratorios2ToolStripMenuItem
            // 
            this.laboratorios2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaOperaciónDeVectoresToolStripMenuItem,
            this.matricesToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.progressBarToolStripMenuItem,
            this.scrollBarToolStripMenuItem,
            this.messageBozToolStripMenuItem});
            this.laboratorios2ToolStripMenuItem.Name = "laboratorios2ToolStripMenuItem";
            this.laboratorios2ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.laboratorios2ToolStripMenuItem.Text = "Laboratorios2";
            // 
            // cargaOperaciónDeVectoresToolStripMenuItem
            // 
            this.cargaOperaciónDeVectoresToolStripMenuItem.Name = "cargaOperaciónDeVectoresToolStripMenuItem";
            this.cargaOperaciónDeVectoresToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.cargaOperaciónDeVectoresToolStripMenuItem.Text = "Carga/Operación de vectores";
            this.cargaOperaciónDeVectoresToolStripMenuItem.Click += new System.EventHandler(this.cargaOperaciónDeVectoresToolStripMenuItem_Click);
            // 
            // matricesToolStripMenuItem
            // 
            this.matricesToolStripMenuItem.Name = "matricesToolStripMenuItem";
            this.matricesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.matricesToolStripMenuItem.Text = "Carga de matrices";
            this.matricesToolStripMenuItem.Click += new System.EventHandler(this.matricesToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // progressBarToolStripMenuItem
            // 
            this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.progressBarToolStripMenuItem.Text = "ProgressBar";
            this.progressBarToolStripMenuItem.Click += new System.EventHandler(this.progressBarToolStripMenuItem_Click);
            // 
            // scrollBarToolStripMenuItem
            // 
            this.scrollBarToolStripMenuItem.Name = "scrollBarToolStripMenuItem";
            this.scrollBarToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.scrollBarToolStripMenuItem.Text = "ScrollBar";
            this.scrollBarToolStripMenuItem.Click += new System.EventHandler(this.scrollBarToolStripMenuItem_Click);
            // 
            // messageBozToolStripMenuItem
            // 
            this.messageBozToolStripMenuItem.Name = "messageBozToolStripMenuItem";
            this.messageBozToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.messageBozToolStripMenuItem.Text = "MessageBox";
            this.messageBozToolStripMenuItem.Click += new System.EventHandler(this.messageBozToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 327);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Parte A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laboratorios2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaOperaciónDeVectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrollBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageBozToolStripMenuItem;
    }
}

