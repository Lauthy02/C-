namespace ParteC
{
    partial class Form_CheckBox
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
            this.button_Ejecutar = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.checkBox_2daEleccion = new System.Windows.Forms.CheckBox();
            this.checkBox_1erEleccion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Ejecutar
            // 
            this.button_Ejecutar.Location = new System.Drawing.Point(13, 138);
            this.button_Ejecutar.Name = "button_Ejecutar";
            this.button_Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.button_Ejecutar.TabIndex = 0;
            this.button_Ejecutar.Text = "Ejecutar";
            this.button_Ejecutar.UseVisualStyleBackColor = true;
            this.button_Ejecutar.Click += new System.EventHandler(this.button_Ejecutar_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(128, 138);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 1;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // checkBox_2daEleccion
            // 
            this.checkBox_2daEleccion.AutoSize = true;
            this.checkBox_2daEleccion.Location = new System.Drawing.Point(128, 102);
            this.checkBox_2daEleccion.Name = "checkBox_2daEleccion";
            this.checkBox_2daEleccion.Size = new System.Drawing.Size(88, 17);
            this.checkBox_2daEleccion.TabIndex = 2;
            this.checkBox_2daEleccion.Text = "2da Elección";
            this.checkBox_2daEleccion.UseVisualStyleBackColor = true;
            // 
            // checkBox_1erEleccion
            // 
            this.checkBox_1erEleccion.AutoSize = true;
            this.checkBox_1erEleccion.Location = new System.Drawing.Point(13, 102);
            this.checkBox_1erEleccion.Name = "checkBox_1erEleccion";
            this.checkBox_1erEleccion.Size = new System.Drawing.Size(85, 17);
            this.checkBox_1erEleccion.TabIndex = 3;
            this.checkBox_1erEleccion.Text = "1ra Elección";
            this.checkBox_1erEleccion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lorem ipsum dolor sit amet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lorem ipsum dolor sit amet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(28, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lorem ipsum dolor sit amet";
            // 
            // Form_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 198);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_1erEleccion);
            this.Controls.Add(this.checkBox_2daEleccion);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Ejecutar);
            this.Name = "Form_CheckBox";
            this.Text = "Form_CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ejecutar;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.CheckBox checkBox_2daEleccion;
        private System.Windows.Forms.CheckBox checkBox_1erEleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}