namespace ParteC
{
    partial class Form_RadioButtons
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_1erOperador = new System.Windows.Forms.TextBox();
            this.textBox_2doOperador = new System.Windows.Forms.TextBox();
            this.textBox_Respuesta = new System.Windows.Forms.TextBox();
            this.button_ConIf = new System.Windows.Forms.Button();
            this.button_ConSwitch = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.radioButton_Suma = new System.Windows.Forms.RadioButton();
            this.groupBox_Operaciones = new System.Windows.Forms.GroupBox();
            this.radioButton_Producto = new System.Windows.Forms.RadioButton();
            this.radioButton_Cociente = new System.Windows.Forms.RadioButton();
            this.radioButton_Resta = new System.Windows.Forms.RadioButton();
            this.button_Salir = new System.Windows.Forms.Button();
            this.groupBox_Operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1er operador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2do operador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // textBox_1erOperador
            // 
            this.textBox_1erOperador.Location = new System.Drawing.Point(78, 8);
            this.textBox_1erOperador.Name = "textBox_1erOperador";
            this.textBox_1erOperador.Size = new System.Drawing.Size(100, 20);
            this.textBox_1erOperador.TabIndex = 3;
            // 
            // textBox_2doOperador
            // 
            this.textBox_2doOperador.Location = new System.Drawing.Point(78, 39);
            this.textBox_2doOperador.Name = "textBox_2doOperador";
            this.textBox_2doOperador.Size = new System.Drawing.Size(100, 20);
            this.textBox_2doOperador.TabIndex = 4;
            // 
            // textBox_Respuesta
            // 
            this.textBox_Respuesta.Location = new System.Drawing.Point(78, 70);
            this.textBox_Respuesta.Name = "textBox_Respuesta";
            this.textBox_Respuesta.Size = new System.Drawing.Size(100, 20);
            this.textBox_Respuesta.TabIndex = 5;
            // 
            // button_ConIf
            // 
            this.button_ConIf.Location = new System.Drawing.Point(184, 5);
            this.button_ConIf.Name = "button_ConIf";
            this.button_ConIf.Size = new System.Drawing.Size(75, 23);
            this.button_ConIf.TabIndex = 6;
            this.button_ConIf.Text = "Con if";
            this.button_ConIf.UseVisualStyleBackColor = true;
            this.button_ConIf.Click += new System.EventHandler(this.button_ConIf_Click);
            // 
            // button_ConSwitch
            // 
            this.button_ConSwitch.Location = new System.Drawing.Point(184, 37);
            this.button_ConSwitch.Name = "button_ConSwitch";
            this.button_ConSwitch.Size = new System.Drawing.Size(75, 23);
            this.button_ConSwitch.TabIndex = 7;
            this.button_ConSwitch.Text = "Con switch";
            this.button_ConSwitch.UseVisualStyleBackColor = true;
            this.button_ConSwitch.Click += new System.EventHandler(this.button_ConSwitch_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(184, 67);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 8;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // radioButton_Suma
            // 
            this.radioButton_Suma.AutoSize = true;
            this.radioButton_Suma.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Suma.Name = "radioButton_Suma";
            this.radioButton_Suma.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Suma.TabIndex = 9;
            this.radioButton_Suma.TabStop = true;
            this.radioButton_Suma.Text = "Suma";
            this.radioButton_Suma.UseVisualStyleBackColor = true;
            // 
            // groupBox_Operaciones
            // 
            this.groupBox_Operaciones.Controls.Add(this.radioButton_Producto);
            this.groupBox_Operaciones.Controls.Add(this.radioButton_Cociente);
            this.groupBox_Operaciones.Controls.Add(this.radioButton_Resta);
            this.groupBox_Operaciones.Controls.Add(this.radioButton_Suma);
            this.groupBox_Operaciones.Location = new System.Drawing.Point(20, 96);
            this.groupBox_Operaciones.Name = "groupBox_Operaciones";
            this.groupBox_Operaciones.Size = new System.Drawing.Size(158, 79);
            this.groupBox_Operaciones.TabIndex = 10;
            this.groupBox_Operaciones.TabStop = false;
            this.groupBox_Operaciones.Text = "Operaciones";
            // 
            // radioButton_Producto
            // 
            this.radioButton_Producto.AutoSize = true;
            this.radioButton_Producto.Location = new System.Drawing.Point(87, 52);
            this.radioButton_Producto.Name = "radioButton_Producto";
            this.radioButton_Producto.Size = new System.Drawing.Size(68, 17);
            this.radioButton_Producto.TabIndex = 12;
            this.radioButton_Producto.TabStop = true;
            this.radioButton_Producto.Text = "Producto";
            this.radioButton_Producto.UseVisualStyleBackColor = true;
            // 
            // radioButton_Cociente
            // 
            this.radioButton_Cociente.AutoSize = true;
            this.radioButton_Cociente.Location = new System.Drawing.Point(6, 52);
            this.radioButton_Cociente.Name = "radioButton_Cociente";
            this.radioButton_Cociente.Size = new System.Drawing.Size(67, 17);
            this.radioButton_Cociente.TabIndex = 11;
            this.radioButton_Cociente.TabStop = true;
            this.radioButton_Cociente.Text = "Cociente";
            this.radioButton_Cociente.UseVisualStyleBackColor = true;
            // 
            // radioButton_Resta
            // 
            this.radioButton_Resta.AutoSize = true;
            this.radioButton_Resta.Location = new System.Drawing.Point(87, 19);
            this.radioButton_Resta.Name = "radioButton_Resta";
            this.radioButton_Resta.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Resta.TabIndex = 10;
            this.radioButton_Resta.TabStop = true;
            this.radioButton_Resta.Text = "Resta";
            this.radioButton_Resta.UseVisualStyleBackColor = true;
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(184, 96);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 11;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // Form_RadioButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 185);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.groupBox_Operaciones);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_ConSwitch);
            this.Controls.Add(this.button_ConIf);
            this.Controls.Add(this.textBox_Respuesta);
            this.Controls.Add(this.textBox_2doOperador);
            this.Controls.Add(this.textBox_1erOperador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_RadioButtons";
            this.Text = "Radio Buttons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Operaciones.ResumeLayout(false);
            this.groupBox_Operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_1erOperador;
        private System.Windows.Forms.TextBox textBox_2doOperador;
        private System.Windows.Forms.TextBox textBox_Respuesta;
        private System.Windows.Forms.Button button_ConIf;
        private System.Windows.Forms.Button button_ConSwitch;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.RadioButton radioButton_Suma;
        private System.Windows.Forms.GroupBox groupBox_Operaciones;
        private System.Windows.Forms.RadioButton radioButton_Producto;
        private System.Windows.Forms.RadioButton radioButton_Cociente;
        private System.Windows.Forms.RadioButton radioButton_Resta;
        private System.Windows.Forms.Button button_Salir;
    }
}

