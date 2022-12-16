namespace Recu
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
            this.textBox_Codigo = new System.Windows.Forms.TextBox();
            this.textBox_Rubro = new System.Windows.Forms.TextBox();
            this.textBox_Fecha = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.numericUpDown_Precio = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Rubro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Alta = new System.Windows.Forms.Button();
            this.button_Baja = new System.Windows.Forms.Button();
            this.button_Modific = new System.Windows.Forms.Button();
            this.button_Persistir = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.textBox_VerMaestro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_VerSecos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_VerFrescos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_VerBebCola = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_VerBebAlc = new System.Windows.Forms.TextBox();
            this.button_VerArchivos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Precio)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Codigo
            // 
            this.textBox_Codigo.Location = new System.Drawing.Point(74, 8);
            this.textBox_Codigo.Name = "textBox_Codigo";
            this.textBox_Codigo.Size = new System.Drawing.Size(200, 20);
            this.textBox_Codigo.TabIndex = 0;
            // 
            // textBox_Rubro
            // 
            this.textBox_Rubro.Enabled = false;
            this.textBox_Rubro.Location = new System.Drawing.Point(74, 113);
            this.textBox_Rubro.Name = "textBox_Rubro";
            this.textBox_Rubro.ReadOnly = true;
            this.textBox_Rubro.Size = new System.Drawing.Size(200, 20);
            this.textBox_Rubro.TabIndex = 1;
            // 
            // textBox_Fecha
            // 
            this.textBox_Fecha.Enabled = false;
            this.textBox_Fecha.Location = new System.Drawing.Point(74, 165);
            this.textBox_Fecha.Name = "textBox_Fecha";
            this.textBox_Fecha.ReadOnly = true;
            this.textBox_Fecha.Size = new System.Drawing.Size(200, 20);
            this.textBox_Fecha.TabIndex = 2;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(74, 34);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(200, 20);
            this.textBox_Nombre.TabIndex = 3;
            // 
            // numericUpDown_Precio
            // 
            this.numericUpDown_Precio.Location = new System.Drawing.Point(74, 60);
            this.numericUpDown_Precio.Name = "numericUpDown_Precio";
            this.numericUpDown_Precio.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_Precio.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rubro:";
            // 
            // comboBox_Rubro
            // 
            this.comboBox_Rubro.FormattingEnabled = true;
            this.comboBox_Rubro.Items.AddRange(new object[] {
            "Secos",
            "Frescos",
            "Bebidas Cola",
            "Bebidas Alcoholicas"});
            this.comboBox_Rubro.Location = new System.Drawing.Point(74, 86);
            this.comboBox_Rubro.Name = "comboBox_Rubro";
            this.comboBox_Rubro.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Rubro.TabIndex = 10;
            this.comboBox_Rubro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha ing.:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 481);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Salir);
            this.tabPage1.Controls.Add(this.button_Persistir);
            this.tabPage1.Controls.Add(this.button_Modific);
            this.tabPage1.Controls.Add(this.button_Baja);
            this.tabPage1.Controls.Add(this.button_Alta);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox_Codigo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox_Rubro);
            this.tabPage1.Controls.Add(this.comboBox_Rubro);
            this.tabPage1.Controls.Add(this.textBox_Fecha);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox_Nombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numericUpDown_Precio);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_VerArchivos);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox_VerBebAlc);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBox_VerBebCola);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox_VerFrescos);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox_VerSecos);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox_VerMaestro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualización de archivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(281, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 419);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Rubro";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha ing.";
            this.Column5.Name = "Column5";
            // 
            // button_Alta
            // 
            this.button_Alta.Location = new System.Drawing.Point(200, 192);
            this.button_Alta.Name = "button_Alta";
            this.button_Alta.Size = new System.Drawing.Size(75, 23);
            this.button_Alta.TabIndex = 13;
            this.button_Alta.Text = "Alta";
            this.button_Alta.UseVisualStyleBackColor = true;
            this.button_Alta.Click += new System.EventHandler(this.button_Alta_Click);
            // 
            // button_Baja
            // 
            this.button_Baja.Location = new System.Drawing.Point(200, 221);
            this.button_Baja.Name = "button_Baja";
            this.button_Baja.Size = new System.Drawing.Size(75, 23);
            this.button_Baja.TabIndex = 14;
            this.button_Baja.Text = "Baja";
            this.button_Baja.UseVisualStyleBackColor = true;
            this.button_Baja.Click += new System.EventHandler(this.button_Baja_Click);
            // 
            // button_Modific
            // 
            this.button_Modific.Location = new System.Drawing.Point(200, 250);
            this.button_Modific.Name = "button_Modific";
            this.button_Modific.Size = new System.Drawing.Size(75, 23);
            this.button_Modific.TabIndex = 15;
            this.button_Modific.Text = "Modificación";
            this.button_Modific.UseVisualStyleBackColor = true;
            this.button_Modific.Click += new System.EventHandler(this.button_Modific_Click);
            // 
            // button_Persistir
            // 
            this.button_Persistir.Location = new System.Drawing.Point(200, 307);
            this.button_Persistir.Name = "button_Persistir";
            this.button_Persistir.Size = new System.Drawing.Size(75, 23);
            this.button_Persistir.TabIndex = 16;
            this.button_Persistir.Text = "Persistir";
            this.button_Persistir.UseVisualStyleBackColor = true;
            this.button_Persistir.Click += new System.EventHandler(this.button_Persistir_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(200, 404);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 17;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // textBox_VerMaestro
            // 
            this.textBox_VerMaestro.Location = new System.Drawing.Point(12, 23);
            this.textBox_VerMaestro.Multiline = true;
            this.textBox_VerMaestro.Name = "textBox_VerMaestro";
            this.textBox_VerMaestro.ReadOnly = true;
            this.textBox_VerMaestro.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerMaestro.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Archivo Maestro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Archivo Secos:";
            // 
            // textBox_VerSecos
            // 
            this.textBox_VerSecos.Location = new System.Drawing.Point(298, 23);
            this.textBox_VerSecos.Multiline = true;
            this.textBox_VerSecos.Name = "textBox_VerSecos";
            this.textBox_VerSecos.ReadOnly = true;
            this.textBox_VerSecos.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerSecos.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Archivo Frescos:";
            // 
            // textBox_VerFrescos
            // 
            this.textBox_VerFrescos.Location = new System.Drawing.Point(584, 23);
            this.textBox_VerFrescos.Multiline = true;
            this.textBox_VerFrescos.Name = "textBox_VerFrescos";
            this.textBox_VerFrescos.ReadOnly = true;
            this.textBox_VerFrescos.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerFrescos.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Archivo Bebidas Cola:";
            // 
            // textBox_VerBebCola
            // 
            this.textBox_VerBebCola.Location = new System.Drawing.Point(298, 247);
            this.textBox_VerBebCola.Multiline = true;
            this.textBox_VerBebCola.Name = "textBox_VerBebCola";
            this.textBox_VerBebCola.ReadOnly = true;
            this.textBox_VerBebCola.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerBebCola.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(581, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Archivo Bebidas Alcohólicas:";
            // 
            // textBox_VerBebAlc
            // 
            this.textBox_VerBebAlc.Location = new System.Drawing.Point(584, 247);
            this.textBox_VerBebAlc.Multiline = true;
            this.textBox_VerBebAlc.Name = "textBox_VerBebAlc";
            this.textBox_VerBebAlc.ReadOnly = true;
            this.textBox_VerBebAlc.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerBebAlc.TabIndex = 8;
            // 
            // button_VerArchivos
            // 
            this.button_VerArchivos.Location = new System.Drawing.Point(99, 327);
            this.button_VerArchivos.Name = "button_VerArchivos";
            this.button_VerArchivos.Size = new System.Drawing.Size(75, 23);
            this.button_VerArchivos.TabIndex = 10;
            this.button_VerArchivos.Text = "Ver archivos";
            this.button_VerArchivos.UseVisualStyleBackColor = true;
            this.button_VerArchivos.Click += new System.EventHandler(this.button_VerArchivos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperatorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Precio)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Codigo;
        private System.Windows.Forms.TextBox textBox_Rubro;
        private System.Windows.Forms.TextBox textBox_Fecha;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.NumericUpDown numericUpDown_Precio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Rubro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button button_Persistir;
        private System.Windows.Forms.Button button_Modific;
        private System.Windows.Forms.Button button_Baja;
        private System.Windows.Forms.Button button_Alta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_VerArchivos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_VerBebAlc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_VerBebCola;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_VerFrescos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_VerSecos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_VerMaestro;
    }
}

