namespace _2doParcial
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_Fecha = new System.Windows.Forms.TextBox();
            this.button_Persistir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_Precio = new System.Windows.Forms.NumericUpDown();
            this.textBox_Rubro = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Codigo = new System.Windows.Forms.TextBox();
            this.comboBox_Rubro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Salir = new System.Windows.Forms.Button();
            this.button_Modific = new System.Windows.Forms.Button();
            this.button_Baja = new System.Windows.Forms.Button();
            this.button_Alta = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_VerMaestro = new System.Windows.Forms.TextBox();
            this.button_VerArchivos = new System.Windows.Forms.Button();
            this.textBox_VerDeMano = new System.Windows.Forms.TextBox();
            this.textBox_VerElecDeMano = new System.Windows.Forms.TextBox();
            this.textBox_VerElecDeMesa = new System.Windows.Forms.TextBox();
            this.textBox_VerMaqInd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Precio)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(301, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
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
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 481);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_Fecha);
            this.tabPage1.Controls.Add(this.button_Persistir);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.numericUpDown_Precio);
            this.tabPage1.Controls.Add(this.textBox_Rubro);
            this.tabPage1.Controls.Add(this.textBox_Nombre);
            this.tabPage1.Controls.Add(this.textBox_Codigo);
            this.tabPage1.Controls.Add(this.comboBox_Rubro);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_Salir);
            this.tabPage1.Controls.Add(this.button_Modific);
            this.tabPage1.Controls.Add(this.button_Baja);
            this.tabPage1.Controls.Add(this.button_Alta);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_Fecha
            // 
            this.textBox_Fecha.Enabled = false;
            this.textBox_Fecha.Location = new System.Drawing.Point(95, 166);
            this.textBox_Fecha.Name = "textBox_Fecha";
            this.textBox_Fecha.ReadOnly = true;
            this.textBox_Fecha.Size = new System.Drawing.Size(200, 20);
            this.textBox_Fecha.TabIndex = 17;
            // 
            // button_Persistir
            // 
            this.button_Persistir.Location = new System.Drawing.Point(220, 331);
            this.button_Persistir.Name = "button_Persistir";
            this.button_Persistir.Size = new System.Drawing.Size(75, 23);
            this.button_Persistir.TabIndex = 16;
            this.button_Persistir.Text = "Persistir";
            this.button_Persistir.UseVisualStyleBackColor = true;
            this.button_Persistir.Click += new System.EventHandler(this.button_Persistir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numericUpDown_Precio
            // 
            this.numericUpDown_Precio.Location = new System.Drawing.Point(95, 58);
            this.numericUpDown_Precio.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_Precio.Name = "numericUpDown_Precio";
            this.numericUpDown_Precio.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_Precio.TabIndex = 14;
            // 
            // textBox_Rubro
            // 
            this.textBox_Rubro.Enabled = false;
            this.textBox_Rubro.Location = new System.Drawing.Point(95, 113);
            this.textBox_Rubro.Name = "textBox_Rubro";
            this.textBox_Rubro.ReadOnly = true;
            this.textBox_Rubro.Size = new System.Drawing.Size(200, 20);
            this.textBox_Rubro.TabIndex = 13;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(95, 32);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(200, 20);
            this.textBox_Nombre.TabIndex = 12;
            // 
            // textBox_Codigo
            // 
            this.textBox_Codigo.Location = new System.Drawing.Point(95, 6);
            this.textBox_Codigo.Name = "textBox_Codigo";
            this.textBox_Codigo.Size = new System.Drawing.Size(200, 20);
            this.textBox_Codigo.TabIndex = 11;
            // 
            // comboBox_Rubro
            // 
            this.comboBox_Rubro.FormattingEnabled = true;
            this.comboBox_Rubro.Items.AddRange(new object[] {
            "De mano",
            "Electricas de mano",
            "Electricas de mesa",
            "Maquinas industriales"});
            this.comboBox_Rubro.Location = new System.Drawing.Point(95, 84);
            this.comboBox_Rubro.Name = "comboBox_Rubro";
            this.comboBox_Rubro.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Rubro.TabIndex = 10;
            this.comboBox_Rubro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rubro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(220, 393);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 4;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // button_Modific
            // 
            this.button_Modific.Location = new System.Drawing.Point(220, 280);
            this.button_Modific.Name = "button_Modific";
            this.button_Modific.Size = new System.Drawing.Size(75, 23);
            this.button_Modific.TabIndex = 3;
            this.button_Modific.Text = "Modificación";
            this.button_Modific.UseVisualStyleBackColor = true;
            this.button_Modific.Click += new System.EventHandler(this.button_Modific_Click);
            // 
            // button_Baja
            // 
            this.button_Baja.Location = new System.Drawing.Point(220, 251);
            this.button_Baja.Name = "button_Baja";
            this.button_Baja.Size = new System.Drawing.Size(75, 23);
            this.button_Baja.TabIndex = 2;
            this.button_Baja.Text = "Baja";
            this.button_Baja.UseVisualStyleBackColor = true;
            this.button_Baja.Click += new System.EventHandler(this.button_Baja_Click);
            // 
            // button_Alta
            // 
            this.button_Alta.Location = new System.Drawing.Point(220, 222);
            this.button_Alta.Name = "button_Alta";
            this.button_Alta.Size = new System.Drawing.Size(75, 23);
            this.button_Alta.TabIndex = 1;
            this.button_Alta.Text = "Alta";
            this.button_Alta.UseVisualStyleBackColor = true;
            this.button_Alta.Click += new System.EventHandler(this.button_Alta_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox_VerMaqInd);
            this.tabPage2.Controls.Add(this.textBox_VerElecDeMesa);
            this.tabPage2.Controls.Add(this.textBox_VerElecDeMano);
            this.tabPage2.Controls.Add(this.textBox_VerDeMano);
            this.tabPage2.Controls.Add(this.button_VerArchivos);
            this.tabPage2.Controls.Add(this.textBox_VerMaestro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualización de archivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBox_VerMaestro
            // 
            this.textBox_VerMaestro.Location = new System.Drawing.Point(6, 19);
            this.textBox_VerMaestro.Multiline = true;
            this.textBox_VerMaestro.Name = "textBox_VerMaestro";
            this.textBox_VerMaestro.ReadOnly = true;
            this.textBox_VerMaestro.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_VerMaestro.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerMaestro.TabIndex = 0;
            // 
            // button_VerArchivos
            // 
            this.button_VerArchivos.Location = new System.Drawing.Point(6, 424);
            this.button_VerArchivos.Name = "button_VerArchivos";
            this.button_VerArchivos.Size = new System.Drawing.Size(75, 23);
            this.button_VerArchivos.TabIndex = 1;
            this.button_VerArchivos.Text = "Ver archivos";
            this.button_VerArchivos.UseVisualStyleBackColor = true;
            this.button_VerArchivos.Click += new System.EventHandler(this.button_VerArchivos_Click);
            // 
            // textBox_VerDeMano
            // 
            this.textBox_VerDeMano.Location = new System.Drawing.Point(292, 19);
            this.textBox_VerDeMano.Multiline = true;
            this.textBox_VerDeMano.Name = "textBox_VerDeMano";
            this.textBox_VerDeMano.ReadOnly = true;
            this.textBox_VerDeMano.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_VerDeMano.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerDeMano.TabIndex = 2;
            // 
            // textBox_VerElecDeMano
            // 
            this.textBox_VerElecDeMano.Location = new System.Drawing.Point(578, 19);
            this.textBox_VerElecDeMano.Multiline = true;
            this.textBox_VerElecDeMano.Name = "textBox_VerElecDeMano";
            this.textBox_VerElecDeMano.ReadOnly = true;
            this.textBox_VerElecDeMano.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_VerElecDeMano.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerElecDeMano.TabIndex = 3;
            // 
            // textBox_VerElecDeMesa
            // 
            this.textBox_VerElecDeMesa.Location = new System.Drawing.Point(428, 247);
            this.textBox_VerElecDeMesa.Multiline = true;
            this.textBox_VerElecDeMesa.Name = "textBox_VerElecDeMesa";
            this.textBox_VerElecDeMesa.ReadOnly = true;
            this.textBox_VerElecDeMesa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_VerElecDeMesa.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerElecDeMesa.TabIndex = 4;
            // 
            // textBox_VerMaqInd
            // 
            this.textBox_VerMaqInd.Location = new System.Drawing.Point(142, 247);
            this.textBox_VerMaqInd.Multiline = true;
            this.textBox_VerMaqInd.Name = "textBox_VerMaqInd";
            this.textBox_VerMaqInd.ReadOnly = true;
            this.textBox_VerMaqInd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_VerMaqInd.Size = new System.Drawing.Size(280, 200);
            this.textBox_VerMaqInd.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Archivo Maestro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Archivo DeMano";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Archivo ElectricasDeMano";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Archivo ElectricasDeMesa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Archivo MaqinasIndustriales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcial 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Precio)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button button_Modific;
        private System.Windows.Forms.Button button_Baja;
        private System.Windows.Forms.Button button_Alta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Rubro;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Codigo;
        private System.Windows.Forms.ComboBox comboBox_Rubro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Precio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBox_VerMaestro;
        private System.Windows.Forms.Button button_Persistir;
        private System.Windows.Forms.TextBox textBox_Fecha;
        private System.Windows.Forms.Button button_VerArchivos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_VerMaqInd;
        private System.Windows.Forms.TextBox textBox_VerElecDeMesa;
        private System.Windows.Forms.TextBox textBox_VerElecDeMano;
        private System.Windows.Forms.TextBox textBox_VerDeMano;
    }
}

