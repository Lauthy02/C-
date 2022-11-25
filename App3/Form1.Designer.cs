namespace App3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Carrera = new System.Windows.Forms.TextBox();
            this.textBox_Catedra = new System.Windows.Forms.TextBox();
            this.textBox_Alumno = new System.Windows.Forms.TextBox();
            this.comboBox_Carrera = new System.Windows.Forms.ComboBox();
            this.comboBox_Catedra = new System.Windows.Forms.ComboBox();
            this.comboBox_Alumno = new System.Windows.Forms.ComboBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Persistr = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Resumen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Generar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cátedra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alumno";
            // 
            // textBox_Carrera
            // 
            this.textBox_Carrera.Enabled = false;
            this.textBox_Carrera.Location = new System.Drawing.Point(15, 54);
            this.textBox_Carrera.Name = "textBox_Carrera";
            this.textBox_Carrera.ReadOnly = true;
            this.textBox_Carrera.Size = new System.Drawing.Size(106, 20);
            this.textBox_Carrera.TabIndex = 4;
            // 
            // textBox_Catedra
            // 
            this.textBox_Catedra.Enabled = false;
            this.textBox_Catedra.Location = new System.Drawing.Point(172, 54);
            this.textBox_Catedra.Name = "textBox_Catedra";
            this.textBox_Catedra.ReadOnly = true;
            this.textBox_Catedra.Size = new System.Drawing.Size(106, 20);
            this.textBox_Catedra.TabIndex = 5;
            // 
            // textBox_Alumno
            // 
            this.textBox_Alumno.Enabled = false;
            this.textBox_Alumno.Location = new System.Drawing.Point(329, 54);
            this.textBox_Alumno.Name = "textBox_Alumno";
            this.textBox_Alumno.ReadOnly = true;
            this.textBox_Alumno.Size = new System.Drawing.Size(106, 20);
            this.textBox_Alumno.TabIndex = 6;
            // 
            // comboBox_Carrera
            // 
            this.comboBox_Carrera.FormattingEnabled = true;
            this.comboBox_Carrera.Items.AddRange(new object[] {
            "Ing. Sistemas",
            "Profesorado Matemática",
            "Licenciatura en Sistemas",
            "Analista en Sistemas",
            "Medicina",
            "Enfermería",
            "Kinesiología",
            "Videojuegos"});
            this.comboBox_Carrera.Location = new System.Drawing.Point(15, 27);
            this.comboBox_Carrera.Name = "comboBox_Carrera";
            this.comboBox_Carrera.Size = new System.Drawing.Size(106, 21);
            this.comboBox_Carrera.TabIndex = 7;
            this.comboBox_Carrera.SelectedIndexChanged += new System.EventHandler(this.comboBox_Carrera_SelectedIndexChanged);
            // 
            // comboBox_Catedra
            // 
            this.comboBox_Catedra.FormattingEnabled = true;
            this.comboBox_Catedra.Items.AddRange(new object[] {
            "Prog. Estructurada",
            "Prog. 1",
            "Prog OO",
            "LUG",
            "Anatomía"});
            this.comboBox_Catedra.Location = new System.Drawing.Point(172, 27);
            this.comboBox_Catedra.Name = "comboBox_Catedra";
            this.comboBox_Catedra.Size = new System.Drawing.Size(106, 21);
            this.comboBox_Catedra.TabIndex = 8;
            this.comboBox_Catedra.SelectedIndexChanged += new System.EventHandler(this.comboBox_Catedra_SelectedIndexChanged);
            // 
            // comboBox_Alumno
            // 
            this.comboBox_Alumno.FormattingEnabled = true;
            this.comboBox_Alumno.Items.AddRange(new object[] {
            "1234 - Juancito Perez",
            "1235 - Max Verstappen",
            "1236 - Checo Perez",
            "1237 - Lewis Hamilton",
            "1238 - Sergio Alonso ",
            "1239 - Charles Leclerc",
            "1240 - Niki Lauda",
            "1241 - James Hunt",
            "1242 - Dantito (carita feliz)"});
            this.comboBox_Alumno.Location = new System.Drawing.Point(329, 27);
            this.comboBox_Alumno.Name = "comboBox_Alumno";
            this.comboBox_Alumno.Size = new System.Drawing.Size(106, 21);
            this.comboBox_Alumno.TabIndex = 9;
            this.comboBox_Alumno.SelectedIndexChanged += new System.EventHandler(this.comboBox_Alumno_SelectedIndexChanged);
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(441, 27);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 10;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(15, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(420, 305);
            this.dataGridView1.TabIndex = 11;
            // 
            // button_Persistr
            // 
            this.button_Persistr.Location = new System.Drawing.Point(441, 334);
            this.button_Persistr.Name = "button_Persistr";
            this.button_Persistr.Size = new System.Drawing.Size(75, 23);
            this.button_Persistr.TabIndex = 12;
            this.button_Persistr.Text = "Persistr";
            this.button_Persistr.UseVisualStyleBackColor = true;
            this.button_Persistr.Click += new System.EventHandler(this.button_Persistr_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(441, 363);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 13;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Carrera";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Catedra";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Alumno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // textBox_Resumen
            // 
            this.textBox_Resumen.Enabled = false;
            this.textBox_Resumen.Location = new System.Drawing.Point(522, 27);
            this.textBox_Resumen.Multiline = true;
            this.textBox_Resumen.Name = "textBox_Resumen";
            this.textBox_Resumen.ReadOnly = true;
            this.textBox_Resumen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Resumen.Size = new System.Drawing.Size(311, 359);
            this.textBox_Resumen.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Archivo ordenado";
            // 
            // button_Generar
            // 
            this.button_Generar.Location = new System.Drawing.Point(441, 138);
            this.button_Generar.Name = "button_Generar";
            this.button_Generar.Size = new System.Drawing.Size(75, 47);
            this.button_Generar.TabIndex = 16;
            this.button_Generar.Text = "Generar listado";
            this.button_Generar.UseVisualStyleBackColor = true;
            this.button_Generar.Click += new System.EventHandler(this.button_Generar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 401);
            this.Controls.Add(this.button_Generar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Resumen);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Persistr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.comboBox_Alumno);
            this.Controls.Add(this.comboBox_Catedra);
            this.Controls.Add(this.comboBox_Carrera);
            this.Controls.Add(this.textBox_Alumno);
            this.Controls.Add(this.textBox_Catedra);
            this.Controls.Add(this.textBox_Carrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Carrera;
        private System.Windows.Forms.TextBox textBox_Catedra;
        private System.Windows.Forms.TextBox textBox_Alumno;
        private System.Windows.Forms.ComboBox comboBox_Carrera;
        private System.Windows.Forms.ComboBox comboBox_Catedra;
        private System.Windows.Forms.ComboBox comboBox_Alumno;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Persistr;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBox_Resumen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Generar;
    }
}

