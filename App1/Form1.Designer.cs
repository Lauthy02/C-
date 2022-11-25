namespace App1
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
            this.textBox_Ingreso = new System.Windows.Forms.TextBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.textBox_Salida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Ingreso
            // 
            this.textBox_Ingreso.Location = new System.Drawing.Point(12, 29);
            this.textBox_Ingreso.Name = "textBox_Ingreso";
            this.textBox_Ingreso.Size = new System.Drawing.Size(267, 20);
            this.textBox_Ingreso.TabIndex = 0;
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(285, 29);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 1;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // textBox_Salida
            // 
            this.textBox_Salida.Enabled = false;
            this.textBox_Salida.Location = new System.Drawing.Point(12, 89);
            this.textBox_Salida.Multiline = true;
            this.textBox_Salida.Name = "textBox_Salida";
            this.textBox_Salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Salida.Size = new System.Drawing.Size(267, 189);
            this.textBox_Salida.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto a ingresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto en el archivo";
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(285, 255);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 5;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 307);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Salida);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.textBox_Ingreso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Ingreso;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.TextBox textBox_Salida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Salir;
    }
}

