namespace ParteC
{
    partial class Form_MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laboratorios2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeLosRadiobuttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDelGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDelCheckboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratorios2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laboratorios2ToolStripMenuItem
            // 
            this.laboratorios2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manejoDeLosRadiobuttonsToolStripMenuItem,
            this.manejoDelGroupToolStripMenuItem,
            this.manejoDelCheckboxToolStripMenuItem});
            this.laboratorios2ToolStripMenuItem.Name = "laboratorios2ToolStripMenuItem";
            this.laboratorios2ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.laboratorios2ToolStripMenuItem.Text = "Laboratorios1";
            // 
            // manejoDeLosRadiobuttonsToolStripMenuItem
            // 
            this.manejoDeLosRadiobuttonsToolStripMenuItem.Name = "manejoDeLosRadiobuttonsToolStripMenuItem";
            this.manejoDeLosRadiobuttonsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.manejoDeLosRadiobuttonsToolStripMenuItem.Text = "Manejo de los radiobuttons";
            this.manejoDeLosRadiobuttonsToolStripMenuItem.Click += new System.EventHandler(this.manejoDeLosRadiobuttonsToolStripMenuItem_Click);
            // 
            // manejoDelGroupToolStripMenuItem
            // 
            this.manejoDelGroupToolStripMenuItem.Name = "manejoDelGroupToolStripMenuItem";
            this.manejoDelGroupToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.manejoDelGroupToolStripMenuItem.Text = "Manejo del listbox";
            this.manejoDelGroupToolStripMenuItem.Click += new System.EventHandler(this.manejoDelGroupToolStripMenuItem_Click);
            // 
            // manejoDelCheckboxToolStripMenuItem
            // 
            this.manejoDelCheckboxToolStripMenuItem.Name = "manejoDelCheckboxToolStripMenuItem";
            this.manejoDelCheckboxToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.manejoDelCheckboxToolStripMenuItem.Text = "Manejo del checkbox";
            this.manejoDelCheckboxToolStripMenuItem.Click += new System.EventHandler(this.manejoDelCheckboxToolStripMenuItem_Click);
            // 
            // Form_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 384);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_MDI";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laboratorios2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeLosRadiobuttonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDelGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDelCheckboxToolStripMenuItem;
    }
}