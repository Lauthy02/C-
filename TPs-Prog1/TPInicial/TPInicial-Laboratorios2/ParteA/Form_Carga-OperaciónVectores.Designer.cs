namespace ParteA
{
    partial class Form_Carga_OperaciónVectores
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
            this.button_BusqBinariaVec = new System.Windows.Forms.Button();
            this.button_LimitesVec = new System.Windows.Forms.Button();
            this.button_CopiarVec = new System.Windows.Forms.Button();
            this.button_OrdenarVec = new System.Windows.Forms.Button();
            this.listBox_Vec = new System.Windows.Forms.ListBox();
            this.button_SalirVec = new System.Windows.Forms.Button();
            this.button_CargaVec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_BusqBinariaVec
            // 
            this.button_BusqBinariaVec.Location = new System.Drawing.Point(483, 120);
            this.button_BusqBinariaVec.Name = "button_BusqBinariaVec";
            this.button_BusqBinariaVec.Size = new System.Drawing.Size(75, 23);
            this.button_BusqBinariaVec.TabIndex = 13;
            this.button_BusqBinariaVec.Text = "Busq binaria";
            this.button_BusqBinariaVec.UseVisualStyleBackColor = true;
            this.button_BusqBinariaVec.Click += new System.EventHandler(this.button_BusqBinariaVec_Click);
            // 
            // button_LimitesVec
            // 
            this.button_LimitesVec.Location = new System.Drawing.Point(483, 91);
            this.button_LimitesVec.Name = "button_LimitesVec";
            this.button_LimitesVec.Size = new System.Drawing.Size(75, 23);
            this.button_LimitesVec.TabIndex = 12;
            this.button_LimitesVec.Text = "Limites";
            this.button_LimitesVec.UseVisualStyleBackColor = true;
            this.button_LimitesVec.Click += new System.EventHandler(this.button_LimitesVec_Click);
            // 
            // button_CopiarVec
            // 
            this.button_CopiarVec.Location = new System.Drawing.Point(483, 62);
            this.button_CopiarVec.Name = "button_CopiarVec";
            this.button_CopiarVec.Size = new System.Drawing.Size(75, 23);
            this.button_CopiarVec.TabIndex = 11;
            this.button_CopiarVec.Text = "Copiar";
            this.button_CopiarVec.UseVisualStyleBackColor = true;
            this.button_CopiarVec.Click += new System.EventHandler(this.button_CopiarVec_Click);
            // 
            // button_OrdenarVec
            // 
            this.button_OrdenarVec.Location = new System.Drawing.Point(483, 33);
            this.button_OrdenarVec.Name = "button_OrdenarVec";
            this.button_OrdenarVec.Size = new System.Drawing.Size(75, 23);
            this.button_OrdenarVec.TabIndex = 10;
            this.button_OrdenarVec.Text = "Ordenar";
            this.button_OrdenarVec.UseVisualStyleBackColor = true;
            this.button_OrdenarVec.Click += new System.EventHandler(this.button_OrdenarVec_Click);
            // 
            // listBox_Vec
            // 
            this.listBox_Vec.FormattingEnabled = true;
            this.listBox_Vec.Location = new System.Drawing.Point(12, 35);
            this.listBox_Vec.Name = "listBox_Vec";
            this.listBox_Vec.Size = new System.Drawing.Size(465, 108);
            this.listBox_Vec.TabIndex = 9;
            // 
            // button_SalirVec
            // 
            this.button_SalirVec.Location = new System.Drawing.Point(12, 149);
            this.button_SalirVec.Name = "button_SalirVec";
            this.button_SalirVec.Size = new System.Drawing.Size(75, 23);
            this.button_SalirVec.TabIndex = 8;
            this.button_SalirVec.Text = "Salir";
            this.button_SalirVec.UseVisualStyleBackColor = true;
            // 
            // button_CargaVec
            // 
            this.button_CargaVec.Location = new System.Drawing.Point(12, 6);
            this.button_CargaVec.Name = "button_CargaVec";
            this.button_CargaVec.Size = new System.Drawing.Size(75, 23);
            this.button_CargaVec.TabIndex = 7;
            this.button_CargaVec.Text = "Carga";
            this.button_CargaVec.UseVisualStyleBackColor = true;
            this.button_CargaVec.Click += new System.EventHandler(this.button_CargaVec_Click);
            // 
            // Form_Carga_OperaciónVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 191);
            this.Controls.Add(this.button_BusqBinariaVec);
            this.Controls.Add(this.button_LimitesVec);
            this.Controls.Add(this.button_CopiarVec);
            this.Controls.Add(this.button_OrdenarVec);
            this.Controls.Add(this.listBox_Vec);
            this.Controls.Add(this.button_SalirVec);
            this.Controls.Add(this.button_CargaVec);
            this.Name = "Form_Carga_OperaciónVectores";
            this.Text = "Form_Carga_OperaciónVectores";
            this.Load += new System.EventHandler(this.Form_Carga_OperaciónVectores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_BusqBinariaVec;
        private System.Windows.Forms.Button button_LimitesVec;
        private System.Windows.Forms.Button button_CopiarVec;
        private System.Windows.Forms.Button button_OrdenarVec;
        private System.Windows.Forms.ListBox listBox_Vec;
        private System.Windows.Forms.Button button_SalirVec;
        private System.Windows.Forms.Button button_CargaVec;
    }
}