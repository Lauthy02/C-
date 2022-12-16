namespace Parcial
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Lista = new System.Windows.Forms.TabPage();
            this.listBox_Lista = new System.Windows.Forms.ListBox();
            this.button_AgregarAlFinalLista = new System.Windows.Forms.Button();
            this.textBox_NombreDelNodoLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Cola = new System.Windows.Forms.TabPage();
            this.listBox_Cola = new System.Windows.Forms.ListBox();
            this.button_Desencolar = new System.Windows.Forms.Button();
            this.button_Encolar = new System.Windows.Forms.Button();
            this.textBox_NombreDelNodoCola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_Pila = new System.Windows.Forms.TabPage();
            this.listBox_Pila = new System.Windows.Forms.ListBox();
            this.button_Desapilar = new System.Windows.Forms.Button();
            this.button_Apilar = new System.Windows.Forms.Button();
            this.textBox_NombreDelNodoPila = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_Lista.SuspendLayout();
            this.tabPage_Cola.SuspendLayout();
            this.tabPage_Pila.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Lista);
            this.tabControl1.Controls.Add(this.tabPage_Cola);
            this.tabControl1.Controls.Add(this.tabPage_Pila);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 199);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Lista
            // 
            this.tabPage_Lista.Controls.Add(this.listBox_Lista);
            this.tabPage_Lista.Controls.Add(this.button_AgregarAlFinalLista);
            this.tabPage_Lista.Controls.Add(this.textBox_NombreDelNodoLista);
            this.tabPage_Lista.Controls.Add(this.label1);
            this.tabPage_Lista.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Lista.Name = "tabPage_Lista";
            this.tabPage_Lista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Lista.Size = new System.Drawing.Size(355, 173);
            this.tabPage_Lista.TabIndex = 0;
            this.tabPage_Lista.Text = "Lista";
            this.tabPage_Lista.UseVisualStyleBackColor = true;
            this.tabPage_Lista.Click += new System.EventHandler(this.tabPage_Lista_Click);
            // 
            // listBox_Lista
            // 
            this.listBox_Lista.FormattingEnabled = true;
            this.listBox_Lista.Location = new System.Drawing.Point(15, 53);
            this.listBox_Lista.Name = "listBox_Lista";
            this.listBox_Lista.Size = new System.Drawing.Size(312, 108);
            this.listBox_Lista.TabIndex = 9;
            // 
            // button_AgregarAlFinalLista
            // 
            this.button_AgregarAlFinalLista.Location = new System.Drawing.Point(227, 16);
            this.button_AgregarAlFinalLista.Name = "button_AgregarAlFinalLista";
            this.button_AgregarAlFinalLista.Size = new System.Drawing.Size(100, 31);
            this.button_AgregarAlFinalLista.TabIndex = 3;
            this.button_AgregarAlFinalLista.Text = "Agregar al final";
            this.button_AgregarAlFinalLista.UseVisualStyleBackColor = true;
            this.button_AgregarAlFinalLista.Click += new System.EventHandler(this.button_AgregarAlFinalLista_Click);
            // 
            // textBox_NombreDelNodoLista
            // 
            this.textBox_NombreDelNodoLista.Location = new System.Drawing.Point(15, 27);
            this.textBox_NombreDelNodoLista.Name = "textBox_NombreDelNodoLista";
            this.textBox_NombreDelNodoLista.Size = new System.Drawing.Size(206, 20);
            this.textBox_NombreDelNodoLista.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del nodo:";
            // 
            // tabPage_Cola
            // 
            this.tabPage_Cola.Controls.Add(this.listBox_Cola);
            this.tabPage_Cola.Controls.Add(this.button_Desencolar);
            this.tabPage_Cola.Controls.Add(this.button_Encolar);
            this.tabPage_Cola.Controls.Add(this.textBox_NombreDelNodoCola);
            this.tabPage_Cola.Controls.Add(this.label2);
            this.tabPage_Cola.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Cola.Name = "tabPage_Cola";
            this.tabPage_Cola.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Cola.Size = new System.Drawing.Size(355, 302);
            this.tabPage_Cola.TabIndex = 1;
            this.tabPage_Cola.Text = "Cola";
            this.tabPage_Cola.UseVisualStyleBackColor = true;
            // 
            // listBox_Cola
            // 
            this.listBox_Cola.FormattingEnabled = true;
            this.listBox_Cola.Location = new System.Drawing.Point(227, 27);
            this.listBox_Cola.Name = "listBox_Cola";
            this.listBox_Cola.Size = new System.Drawing.Size(116, 264);
            this.listBox_Cola.TabIndex = 9;
            // 
            // button_Desencolar
            // 
            this.button_Desencolar.Location = new System.Drawing.Point(121, 53);
            this.button_Desencolar.Name = "button_Desencolar";
            this.button_Desencolar.Size = new System.Drawing.Size(100, 39);
            this.button_Desencolar.TabIndex = 8;
            this.button_Desencolar.Text = "Desencolar";
            this.button_Desencolar.UseVisualStyleBackColor = true;
            this.button_Desencolar.Click += new System.EventHandler(this.button_Desencolar_Click);
            // 
            // button_Encolar
            // 
            this.button_Encolar.Location = new System.Drawing.Point(15, 53);
            this.button_Encolar.Name = "button_Encolar";
            this.button_Encolar.Size = new System.Drawing.Size(100, 39);
            this.button_Encolar.TabIndex = 7;
            this.button_Encolar.Text = "Encolar";
            this.button_Encolar.UseVisualStyleBackColor = true;
            this.button_Encolar.Click += new System.EventHandler(this.button_Encolar_Click);
            // 
            // textBox_NombreDelNodoCola
            // 
            this.textBox_NombreDelNodoCola.Location = new System.Drawing.Point(15, 27);
            this.textBox_NombreDelNodoCola.Name = "textBox_NombreDelNodoCola";
            this.textBox_NombreDelNodoCola.Size = new System.Drawing.Size(206, 20);
            this.textBox_NombreDelNodoCola.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del nodo:";
            // 
            // tabPage_Pila
            // 
            this.tabPage_Pila.Controls.Add(this.listBox_Pila);
            this.tabPage_Pila.Controls.Add(this.button_Desapilar);
            this.tabPage_Pila.Controls.Add(this.button_Apilar);
            this.tabPage_Pila.Controls.Add(this.textBox_NombreDelNodoPila);
            this.tabPage_Pila.Controls.Add(this.label3);
            this.tabPage_Pila.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Pila.Name = "tabPage_Pila";
            this.tabPage_Pila.Size = new System.Drawing.Size(355, 302);
            this.tabPage_Pila.TabIndex = 2;
            this.tabPage_Pila.Text = "Pila";
            this.tabPage_Pila.UseVisualStyleBackColor = true;
            // 
            // listBox_Pila
            // 
            this.listBox_Pila.FormattingEnabled = true;
            this.listBox_Pila.Location = new System.Drawing.Point(227, 27);
            this.listBox_Pila.Name = "listBox_Pila";
            this.listBox_Pila.Size = new System.Drawing.Size(116, 264);
            this.listBox_Pila.TabIndex = 14;
            // 
            // button_Desapilar
            // 
            this.button_Desapilar.Location = new System.Drawing.Point(121, 53);
            this.button_Desapilar.Name = "button_Desapilar";
            this.button_Desapilar.Size = new System.Drawing.Size(100, 39);
            this.button_Desapilar.TabIndex = 13;
            this.button_Desapilar.Text = "Desapilar";
            this.button_Desapilar.UseVisualStyleBackColor = true;
            this.button_Desapilar.Click += new System.EventHandler(this.button_Desapilar_Click);
            // 
            // button_Apilar
            // 
            this.button_Apilar.Location = new System.Drawing.Point(15, 53);
            this.button_Apilar.Name = "button_Apilar";
            this.button_Apilar.Size = new System.Drawing.Size(100, 39);
            this.button_Apilar.TabIndex = 12;
            this.button_Apilar.Text = "Apilar";
            this.button_Apilar.UseVisualStyleBackColor = true;
            this.button_Apilar.Click += new System.EventHandler(this.button_Apilar_Click);
            // 
            // textBox_NombreDelNodoPila
            // 
            this.textBox_NombreDelNodoPila.Location = new System.Drawing.Point(15, 27);
            this.textBox_NombreDelNodoPila.Name = "textBox_NombreDelNodoPila";
            this.textBox_NombreDelNodoPila.Size = new System.Drawing.Size(206, 20);
            this.textBox_NombreDelNodoPila.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre del nodo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 199);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Parcial 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Lista.ResumeLayout(false);
            this.tabPage_Lista.PerformLayout();
            this.tabPage_Cola.ResumeLayout(false);
            this.tabPage_Cola.PerformLayout();
            this.tabPage_Pila.ResumeLayout(false);
            this.tabPage_Pila.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Lista;
        private System.Windows.Forms.ListBox listBox_Lista;
        private System.Windows.Forms.Button button_AgregarAlFinalLista;
        private System.Windows.Forms.TextBox textBox_NombreDelNodoLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Cola;
        private System.Windows.Forms.TabPage tabPage_Pila;
        private System.Windows.Forms.ListBox listBox_Cola;
        private System.Windows.Forms.Button button_Desencolar;
        private System.Windows.Forms.Button button_Encolar;
        private System.Windows.Forms.TextBox textBox_NombreDelNodoCola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Pila;
        private System.Windows.Forms.Button button_Desapilar;
        private System.Windows.Forms.Button button_Apilar;
        private System.Windows.Forms.TextBox textBox_NombreDelNodoPila;
        private System.Windows.Forms.Label label3;
    }
}

