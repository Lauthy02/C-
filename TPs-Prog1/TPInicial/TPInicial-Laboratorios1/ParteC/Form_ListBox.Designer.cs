namespace ParteC
{
    partial class Form_ListBox
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
            this.radioButton_1erValor = new System.Windows.Forms.RadioButton();
            this.radioButton_2doValor = new System.Windows.Forms.RadioButton();
            this.button_Salir = new System.Windows.Forms.Button();
            this.button_Mostrar = new System.Windows.Forms.Button();
            this.textBox_1erValor = new System.Windows.Forms.TextBox();
            this.textBox_2doValor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Valor1 = new System.Windows.Forms.Label();
            this.label_Valor2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_LimpiarLista = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_1erValor
            // 
            this.radioButton_1erValor.AutoSize = true;
            this.radioButton_1erValor.Location = new System.Drawing.Point(6, 19);
            this.radioButton_1erValor.Name = "radioButton_1erValor";
            this.radioButton_1erValor.Size = new System.Drawing.Size(80, 17);
            this.radioButton_1erValor.TabIndex = 0;
            this.radioButton_1erValor.TabStop = true;
            this.radioButton_1erValor.Text = "Primer valor";
            this.radioButton_1erValor.UseVisualStyleBackColor = true;
            this.radioButton_1erValor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_2doValor
            // 
            this.radioButton_2doValor.AutoSize = true;
            this.radioButton_2doValor.Location = new System.Drawing.Point(6, 19);
            this.radioButton_2doValor.Name = "radioButton_2doValor";
            this.radioButton_2doValor.Size = new System.Drawing.Size(94, 17);
            this.radioButton_2doValor.TabIndex = 1;
            this.radioButton_2doValor.TabStop = true;
            this.radioButton_2doValor.Text = "Segundo valor";
            this.radioButton_2doValor.UseVisualStyleBackColor = true;
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(151, 222);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 2;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // button_Mostrar
            // 
            this.button_Mostrar.Location = new System.Drawing.Point(6, 222);
            this.button_Mostrar.Name = "button_Mostrar";
            this.button_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.button_Mostrar.TabIndex = 3;
            this.button_Mostrar.Text = "Mostrar";
            this.button_Mostrar.UseVisualStyleBackColor = true;
            this.button_Mostrar.Click += new System.EventHandler(this.button_Mostrar_Click);
            // 
            // textBox_1erValor
            // 
            this.textBox_1erValor.Location = new System.Drawing.Point(55, 7);
            this.textBox_1erValor.Name = "textBox_1erValor";
            this.textBox_1erValor.Size = new System.Drawing.Size(171, 20);
            this.textBox_1erValor.TabIndex = 4;
            // 
            // textBox_2doValor
            // 
            this.textBox_2doValor.Location = new System.Drawing.Point(55, 33);
            this.textBox_2doValor.Name = "textBox_2doValor";
            this.textBox_2doValor.Size = new System.Drawing.Size(171, 20);
            this.textBox_2doValor.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.radioButton_1erValor);
            this.groupBox1.Location = new System.Drawing.Point(6, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección 1";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.radioButton_2doValor);
            this.groupBox2.Location = new System.Drawing.Point(111, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección 2";
            // 
            // label_Valor1
            // 
            this.label_Valor1.AutoSize = true;
            this.label_Valor1.Location = new System.Drawing.Point(6, 10);
            this.label_Valor1.Name = "label_Valor1";
            this.label_Valor1.Size = new System.Drawing.Size(43, 13);
            this.label_Valor1.TabIndex = 8;
            this.label_Valor1.Text = "Valor 1:";
            // 
            // label_Valor2
            // 
            this.label_Valor2.AutoSize = true;
            this.label_Valor2.Location = new System.Drawing.Point(6, 36);
            this.label_Valor2.Name = "label_Valor2";
            this.label_Valor2.Size = new System.Drawing.Size(43, 13);
            this.label_Valor2.TabIndex = 9;
            this.label_Valor2.Text = "Valor 2:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 95);
            this.listBox1.TabIndex = 10;
            // 
            // button_LimpiarLista
            // 
            this.button_LimpiarLista.Location = new System.Drawing.Point(87, 222);
            this.button_LimpiarLista.Name = "button_LimpiarLista";
            this.button_LimpiarLista.Size = new System.Drawing.Size(58, 23);
            this.button_LimpiarLista.TabIndex = 11;
            this.button_LimpiarLista.Text = "Limpiar";
            this.button_LimpiarLista.UseVisualStyleBackColor = true;
            this.button_LimpiarLista.Click += new System.EventHandler(this.button_LimpiarLista_Click);
            // 
            // Form_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 257);
            this.Controls.Add(this.button_LimpiarLista);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_Valor2);
            this.Controls.Add(this.label_Valor1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_2doValor);
            this.Controls.Add(this.textBox_1erValor);
            this.Controls.Add(this.button_Mostrar);
            this.Controls.Add(this.button_Salir);
            this.Name = "Form_ListBox";
            this.Text = "ListBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_1erValor;
        private System.Windows.Forms.RadioButton radioButton_2doValor;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button button_Mostrar;
        private System.Windows.Forms.TextBox textBox_1erValor;
        private System.Windows.Forms.TextBox textBox_2doValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Valor1;
        private System.Windows.Forms.Label label_Valor2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_LimpiarLista;
    }
}