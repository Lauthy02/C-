namespace ParteA
{
    partial class Form_Matrices
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
            this.listBox_Mat = new System.Windows.Forms.ListBox();
            this.button_SalirMat = new System.Windows.Forms.Button();
            this.button_CargaMat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Mat
            // 
            this.listBox_Mat.FormattingEnabled = true;
            this.listBox_Mat.Location = new System.Drawing.Point(12, 41);
            this.listBox_Mat.Name = "listBox_Mat";
            this.listBox_Mat.Size = new System.Drawing.Size(299, 108);
            this.listBox_Mat.TabIndex = 5;
            // 
            // button_SalirMat
            // 
            this.button_SalirMat.Location = new System.Drawing.Point(12, 155);
            this.button_SalirMat.Name = "button_SalirMat";
            this.button_SalirMat.Size = new System.Drawing.Size(75, 23);
            this.button_SalirMat.TabIndex = 4;
            this.button_SalirMat.Text = "Salir";
            this.button_SalirMat.UseVisualStyleBackColor = true;
            this.button_SalirMat.Click += new System.EventHandler(this.button_SalirMat_Click);
            // 
            // button_CargaMat
            // 
            this.button_CargaMat.Location = new System.Drawing.Point(12, 12);
            this.button_CargaMat.Name = "button_CargaMat";
            this.button_CargaMat.Size = new System.Drawing.Size(75, 23);
            this.button_CargaMat.TabIndex = 3;
            this.button_CargaMat.Text = "Carga";
            this.button_CargaMat.UseVisualStyleBackColor = true;
            this.button_CargaMat.Click += new System.EventHandler(this.button_CargaMat_Click);
            // 
            // Form_Matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 198);
            this.Controls.Add(this.listBox_Mat);
            this.Controls.Add(this.button_SalirMat);
            this.Controls.Add(this.button_CargaMat);
            this.Name = "Form_Matrices";
            this.Text = "Form_Matrices";
            this.Load += new System.EventHandler(this.Form_Matrices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Mat;
        private System.Windows.Forms.Button button_SalirMat;
        private System.Windows.Forms.Button button_CargaMat;
    }
}