namespace ParteC
{
    partial class Form_OperacionesFecha3
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Sumar = new System.Windows.Forms.Button();
            this.button_Restar = new System.Windows.Forms.Button();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Días";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // button_Sumar
            // 
            this.button_Sumar.Location = new System.Drawing.Point(73, 90);
            this.button_Sumar.Name = "button_Sumar";
            this.button_Sumar.Size = new System.Drawing.Size(75, 23);
            this.button_Sumar.TabIndex = 4;
            this.button_Sumar.Text = "Sumar";
            this.button_Sumar.UseVisualStyleBackColor = true;
            this.button_Sumar.Click += new System.EventHandler(this.button_Sumar_Click);
            // 
            // button_Restar
            // 
            this.button_Restar.Location = new System.Drawing.Point(198, 90);
            this.button_Restar.Name = "button_Restar";
            this.button_Restar.Size = new System.Drawing.Size(75, 23);
            this.button_Restar.TabIndex = 5;
            this.button_Restar.Text = "Restar";
            this.button_Restar.UseVisualStyleBackColor = true;
            this.button_Restar.Click += new System.EventHandler(this.button_Restar_Click);
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(73, 38);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(200, 20);
            this.txtdias.TabIndex = 6;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(73, 64);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(200, 20);
            this.txtresultado.TabIndex = 7;
            // 
            // Form_OperacionesFecha3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 145);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.button_Restar);
            this.Controls.Add(this.button_Sumar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form_OperacionesFecha3";
            this.Text = "Form_OperacionesFecha3";
            this.Load += new System.EventHandler(this.Form_OperacionesFecha3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Sumar;
        private System.Windows.Forms.Button button_Restar;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.TextBox txtresultado;
    }
}