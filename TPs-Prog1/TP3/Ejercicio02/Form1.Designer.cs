namespace Ejercicio02
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
            this.textBox_Num1 = new System.Windows.Forms.TextBox();
            this.textBox_Num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.button_Suma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Num1
            // 
            this.textBox_Num1.Location = new System.Drawing.Point(47, 42);
            this.textBox_Num1.Name = "textBox_Num1";
            this.textBox_Num1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Num1.TabIndex = 0;
            // 
            // textBox_Num2
            // 
            this.textBox_Num2.Location = new System.Drawing.Point(47, 68);
            this.textBox_Num2.Name = "textBox_Num2";
            this.textBox_Num2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Num2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Location = new System.Drawing.Point(44, 103);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(35, 13);
            this.label_Resultado.TabIndex = 4;
            this.label_Resultado.Text = "label3";
            // 
            // button_Suma
            // 
            this.button_Suma.Location = new System.Drawing.Point(165, 42);
            this.button_Suma.Name = "button_Suma";
            this.button_Suma.Size = new System.Drawing.Size(75, 23);
            this.button_Suma.TabIndex = 5;
            this.button_Suma.Text = "Ejecutar";
            this.button_Suma.UseVisualStyleBackColor = true;
            this.button_Suma.Click += new System.EventHandler(this.button_Suma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.button_Suma);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Num2);
            this.Controls.Add(this.textBox_Num1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Num1;
        private System.Windows.Forms.TextBox textBox_Num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Button button_Suma;
    }
}

