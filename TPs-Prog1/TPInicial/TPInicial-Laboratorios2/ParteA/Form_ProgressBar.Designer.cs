namespace ParteA
{
    partial class Form_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_Comenzar = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 62);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // button_Comenzar
            // 
            this.button_Comenzar.Location = new System.Drawing.Point(12, 33);
            this.button_Comenzar.Name = "button_Comenzar";
            this.button_Comenzar.Size = new System.Drawing.Size(75, 23);
            this.button_Comenzar.TabIndex = 1;
            this.button_Comenzar.Text = "Comenzar";
            this.button_Comenzar.UseVisualStyleBackColor = true;
            this.button_Comenzar.Click += new System.EventHandler(this.button_Comenzar_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(12, 91);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 2;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // Form_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 170);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Comenzar);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form_ProgressBar";
            this.Text = "Form_ProgressBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_Comenzar;
        private System.Windows.Forms.Button button_Salir;
    }
}