namespace ParteB
{
    partial class Form_ParteB
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
            this.components = new System.ComponentModel.Container();
            this.label_Operador1 = new System.Windows.Forms.Label();
            this.label_Operador2 = new System.Windows.Forms.Label();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.textBox_Operador1 = new System.Windows.Forms.TextBox();
            this.textBox_Operador2 = new System.Windows.Forms.TextBox();
            this.textBox_Resultado = new System.Windows.Forms.TextBox();
            this.button_Suma = new System.Windows.Forms.Button();
            this.button_Resta = new System.Windows.Forms.Button();
            this.button_Cociente = new System.Windows.Forms.Button();
            this.button_Producto = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.utton_MessageBoxYSAsterisk = new System.Windows.Forms.Button();
            this.button_MessageBoxYS = new System.Windows.Forms.Button();
            this.button_MessageBox = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_IniciaTimer = new System.Windows.Forms.Button();
            this.button_DetenerTimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ValorTimerProgress = new System.Windows.Forms.Label();
            this.label_ScrollBVertical = new System.Windows.Forms.Label();
            this.label_ScrollBHorizontal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Operador1
            // 
            this.label_Operador1.AutoSize = true;
            this.label_Operador1.Location = new System.Drawing.Point(22, 26);
            this.label_Operador1.Name = "label_Operador1";
            this.label_Operador1.Size = new System.Drawing.Size(60, 13);
            this.label_Operador1.TabIndex = 0;
            this.label_Operador1.Text = "Operador 1";
            // 
            // label_Operador2
            // 
            this.label_Operador2.AutoSize = true;
            this.label_Operador2.Location = new System.Drawing.Point(22, 52);
            this.label_Operador2.Name = "label_Operador2";
            this.label_Operador2.Size = new System.Drawing.Size(60, 13);
            this.label_Operador2.TabIndex = 1;
            this.label_Operador2.Text = "Operador 2";
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Location = new System.Drawing.Point(22, 78);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(55, 13);
            this.label_Resultado.TabIndex = 2;
            this.label_Resultado.Text = "Resultado";
            // 
            // textBox_Operador1
            // 
            this.textBox_Operador1.Location = new System.Drawing.Point(94, 23);
            this.textBox_Operador1.Name = "textBox_Operador1";
            this.textBox_Operador1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Operador1.TabIndex = 3;
            // 
            // textBox_Operador2
            // 
            this.textBox_Operador2.Location = new System.Drawing.Point(94, 49);
            this.textBox_Operador2.Name = "textBox_Operador2";
            this.textBox_Operador2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Operador2.TabIndex = 4;
            // 
            // textBox_Resultado
            // 
            this.textBox_Resultado.Location = new System.Drawing.Point(94, 75);
            this.textBox_Resultado.Name = "textBox_Resultado";
            this.textBox_Resultado.Size = new System.Drawing.Size(100, 20);
            this.textBox_Resultado.TabIndex = 5;
            // 
            // button_Suma
            // 
            this.button_Suma.Location = new System.Drawing.Point(226, 23);
            this.button_Suma.Name = "button_Suma";
            this.button_Suma.Size = new System.Drawing.Size(75, 23);
            this.button_Suma.TabIndex = 6;
            this.button_Suma.Text = "Suma";
            this.button_Suma.UseVisualStyleBackColor = true;
            this.button_Suma.Click += new System.EventHandler(this.button_Suma_Click);
            // 
            // button_Resta
            // 
            this.button_Resta.Location = new System.Drawing.Point(226, 52);
            this.button_Resta.Name = "button_Resta";
            this.button_Resta.Size = new System.Drawing.Size(75, 23);
            this.button_Resta.TabIndex = 7;
            this.button_Resta.Text = "Resta";
            this.button_Resta.UseVisualStyleBackColor = true;
            this.button_Resta.Click += new System.EventHandler(this.button_Resta_Click);
            // 
            // button_Cociente
            // 
            this.button_Cociente.Location = new System.Drawing.Point(226, 81);
            this.button_Cociente.Name = "button_Cociente";
            this.button_Cociente.Size = new System.Drawing.Size(75, 23);
            this.button_Cociente.TabIndex = 8;
            this.button_Cociente.Text = "Cociente";
            this.button_Cociente.UseVisualStyleBackColor = true;
            this.button_Cociente.Click += new System.EventHandler(this.button_Cociente_Click);
            // 
            // button_Producto
            // 
            this.button_Producto.Location = new System.Drawing.Point(226, 110);
            this.button_Producto.Name = "button_Producto";
            this.button_Producto.Size = new System.Drawing.Size(75, 23);
            this.button_Producto.TabIndex = 9;
            this.button_Producto.Text = "Producto";
            this.button_Producto.UseVisualStyleBackColor = true;
            this.button_Producto.Click += new System.EventHandler(this.button_Producto_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(119, 110);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 10;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(25, 110);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 244);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonLimpiar);
            this.tabPage1.Controls.Add(this.label_Operador1);
            this.tabPage1.Controls.Add(this.button_Salir);
            this.tabPage1.Controls.Add(this.label_Operador2);
            this.tabPage1.Controls.Add(this.button_Producto);
            this.tabPage1.Controls.Add(this.label_Resultado);
            this.tabPage1.Controls.Add(this.button_Cociente);
            this.tabPage1.Controls.Add(this.textBox_Operador1);
            this.tabPage1.Controls.Add(this.button_Resta);
            this.tabPage1.Controls.Add(this.textBox_Operador2);
            this.tabPage1.Controls.Add(this.button_Suma);
            this.tabPage1.Controls.Add(this.textBox_Resultado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculadora simple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fecha tipo calendario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label_ValorTimerProgress);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.button_DetenerTimer);
            this.tabPage3.Controls.Add(this.button_IniciaTimer);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(494, 218);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Progressbar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "La barra se llena con el timer";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(478, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label_ScrollBHorizontal);
            this.tabPage4.Controls.Add(this.label_ScrollBVertical);
            this.tabPage4.Controls.Add(this.vScrollBar1);
            this.tabPage4.Controls.Add(this.hScrollBar1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(494, 218);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "scroll";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(5, 18);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 118);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(78, 115);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(133, 21);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.utton_MessageBoxYSAsterisk);
            this.tabPage5.Controls.Add(this.button_MessageBoxYS);
            this.tabPage5.Controls.Add(this.button_MessageBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(494, 218);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "MessajeBox";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // utton_MessageBoxYSAsterisk
            // 
            this.utton_MessageBoxYSAsterisk.Location = new System.Drawing.Point(8, 78);
            this.utton_MessageBoxYSAsterisk.Name = "utton_MessageBoxYSAsterisk";
            this.utton_MessageBoxYSAsterisk.Size = new System.Drawing.Size(139, 23);
            this.utton_MessageBoxYSAsterisk.TabIndex = 2;
            this.utton_MessageBoxYSAsterisk.Text = "msjBox Yes/no Asterisk";
            this.utton_MessageBoxYSAsterisk.UseVisualStyleBackColor = true;
            this.utton_MessageBoxYSAsterisk.Click += new System.EventHandler(this.utton_MessageBoxYSAsterisk_Click);
            // 
            // button_MessageBoxYS
            // 
            this.button_MessageBoxYS.Location = new System.Drawing.Point(8, 49);
            this.button_MessageBoxYS.Name = "button_MessageBoxYS";
            this.button_MessageBoxYS.Size = new System.Drawing.Size(139, 23);
            this.button_MessageBoxYS.TabIndex = 1;
            this.button_MessageBoxYS.Text = "msjBox yes/no";
            this.button_MessageBoxYS.UseVisualStyleBackColor = true;
            this.button_MessageBoxYS.Click += new System.EventHandler(this.button_MessageBoxYS_Click);
            // 
            // button_MessageBox
            // 
            this.button_MessageBox.Location = new System.Drawing.Point(8, 20);
            this.button_MessageBox.Name = "button_MessageBox";
            this.button_MessageBox.Size = new System.Drawing.Size(139, 23);
            this.button_MessageBox.TabIndex = 0;
            this.button_MessageBox.Text = "msjBox común";
            this.button_MessageBox.UseVisualStyleBackColor = true;
            this.button_MessageBox.Click += new System.EventHandler(this.button_MessageBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_IniciaTimer
            // 
            this.button_IniciaTimer.Location = new System.Drawing.Point(8, 68);
            this.button_IniciaTimer.Name = "button_IniciaTimer";
            this.button_IniciaTimer.Size = new System.Drawing.Size(82, 23);
            this.button_IniciaTimer.TabIndex = 2;
            this.button_IniciaTimer.Text = "Iniciar timer";
            this.button_IniciaTimer.UseVisualStyleBackColor = true;
            this.button_IniciaTimer.Click += new System.EventHandler(this.button_IniciaTimer_Click);
            // 
            // button_DetenerTimer
            // 
            this.button_DetenerTimer.Location = new System.Drawing.Point(90, 68);
            this.button_DetenerTimer.Name = "button_DetenerTimer";
            this.button_DetenerTimer.Size = new System.Drawing.Size(82, 23);
            this.button_DetenerTimer.TabIndex = 3;
            this.button_DetenerTimer.Text = "Detener timer";
            this.button_DetenerTimer.UseVisualStyleBackColor = true;
            this.button_DetenerTimer.Click += new System.EventHandler(this.button_DetenerTimer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor del timer y progressbar: ";
            // 
            // label_ValorTimerProgress
            // 
            this.label_ValorTimerProgress.AutoSize = true;
            this.label_ValorTimerProgress.Location = new System.Drawing.Point(170, 111);
            this.label_ValorTimerProgress.Name = "label_ValorTimerProgress";
            this.label_ValorTimerProgress.Size = new System.Drawing.Size(0, 13);
            this.label_ValorTimerProgress.TabIndex = 5;
            // 
            // label_ScrollBVertical
            // 
            this.label_ScrollBVertical.AutoSize = true;
            this.label_ScrollBVertical.Location = new System.Drawing.Point(198, 18);
            this.label_ScrollBVertical.Name = "label_ScrollBVertical";
            this.label_ScrollBVertical.Size = new System.Drawing.Size(35, 13);
            this.label_ScrollBVertical.TabIndex = 2;
            this.label_ScrollBVertical.Text = "label3";
            // 
            // label_ScrollBHorizontal
            // 
            this.label_ScrollBHorizontal.AutoSize = true;
            this.label_ScrollBHorizontal.Location = new System.Drawing.Point(217, 150);
            this.label_ScrollBHorizontal.Name = "label_ScrollBHorizontal";
            this.label_ScrollBHorizontal.Size = new System.Drawing.Size(35, 13);
            this.label_ScrollBHorizontal.TabIndex = 3;
            this.label_ScrollBHorizontal.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "El valor de la scrollbar vertical es: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "El valor de la scrollbar horizontal es: ";
            // 
            // Form_ParteB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 244);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_ParteB";
            this.Text = "Parte B";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Operador1;
        private System.Windows.Forms.Label label_Operador2;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.TextBox textBox_Operador1;
        private System.Windows.Forms.TextBox textBox_Operador2;
        private System.Windows.Forms.TextBox textBox_Resultado;
        private System.Windows.Forms.Button button_Suma;
        private System.Windows.Forms.Button button_Resta;
        private System.Windows.Forms.Button button_Cociente;
        private System.Windows.Forms.Button button_Producto;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button_MessageBox;
        private System.Windows.Forms.Button button_MessageBoxYS;
        private System.Windows.Forms.Button utton_MessageBoxYSAsterisk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_IniciaTimer;
        private System.Windows.Forms.Button button_DetenerTimer;
        private System.Windows.Forms.Label label_ValorTimerProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ScrollBHorizontal;
        private System.Windows.Forms.Label label_ScrollBVertical;
    }
}