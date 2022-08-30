namespace ParteB
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
            this.formatosDeNúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoDeFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoDeStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratorios2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laboratorios2ToolStripMenuItem
            // 
            this.laboratorios2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatosDeNúmerosToolStripMenuItem,
            this.formatoDeFechasToolStripMenuItem,
            this.formatoDeStringsToolStripMenuItem});
            this.laboratorios2ToolStripMenuItem.Name = "laboratorios2ToolStripMenuItem";
            this.laboratorios2ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.laboratorios2ToolStripMenuItem.Text = "Laboratorios2";
            this.laboratorios2ToolStripMenuItem.Click += new System.EventHandler(this.laboratorios2ToolStripMenuItem_Click);
            // 
            // formatosDeNúmerosToolStripMenuItem
            // 
            this.formatosDeNúmerosToolStripMenuItem.Name = "formatosDeNúmerosToolStripMenuItem";
            this.formatosDeNúmerosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.formatosDeNúmerosToolStripMenuItem.Text = "Formato de números";
            this.formatosDeNúmerosToolStripMenuItem.Click += new System.EventHandler(this.formatosDeNúmerosToolStripMenuItem_Click);
            // 
            // formatoDeFechasToolStripMenuItem
            // 
            this.formatoDeFechasToolStripMenuItem.Name = "formatoDeFechasToolStripMenuItem";
            this.formatoDeFechasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.formatoDeFechasToolStripMenuItem.Text = "Formato de fechas";
            this.formatoDeFechasToolStripMenuItem.Click += new System.EventHandler(this.formatoDeFechasToolStripMenuItem_Click);
            // 
            // formatoDeStringsToolStripMenuItem
            // 
            this.formatoDeStringsToolStripMenuItem.Name = "formatoDeStringsToolStripMenuItem";
            this.formatoDeStringsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.formatoDeStringsToolStripMenuItem.Text = "Formato de strings";
            this.formatoDeStringsToolStripMenuItem.Click += new System.EventHandler(this.formatoDeStringsToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parte B";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laboratorios2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatosDeNúmerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoDeFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoDeStringsToolStripMenuItem;
    }
}

