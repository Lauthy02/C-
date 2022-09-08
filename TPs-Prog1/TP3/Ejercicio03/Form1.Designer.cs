namespace Ejercicio03
{
    partial class Form1
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
            this.button_Ingresar = new System.Windows.Forms.Button();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.textBox_Numeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Ingresar
            // 
            this.button_Ingresar.Location = new System.Drawing.Point(12, 125);
            this.button_Ingresar.Name = "button_Ingresar";
            this.button_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.button_Ingresar.TabIndex = 0;
            this.button_Ingresar.Text = "Ingresar";
            this.button_Ingresar.UseVisualStyleBackColor = true;
            this.button_Ingresar.Click += new System.EventHandler(this.button_Ingresar_Click);
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Location = new System.Drawing.Point(12, 59);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(35, 13);
            this.label_Resultado.TabIndex = 1;
            this.label_Resultado.Text = "label1";
            // 
            // textBox_Numeros
            // 
            this.textBox_Numeros.Enabled = false;
            this.textBox_Numeros.Location = new System.Drawing.Point(12, 12);
            this.textBox_Numeros.Name = "textBox_Numeros";
            this.textBox_Numeros.Size = new System.Drawing.Size(261, 20);
            this.textBox_Numeros.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 160);
            this.Controls.Add(this.textBox_Numeros);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.button_Ingresar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ingresar;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.TextBox textBox_Numeros;
    }
}

