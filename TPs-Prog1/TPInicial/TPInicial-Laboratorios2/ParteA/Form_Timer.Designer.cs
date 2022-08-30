namespace ParteA
{
    partial class Form_Timer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Crono = new System.Windows.Forms.Label();
            this.button_Comenzar = new System.Windows.Forms.Button();
            this.button_Parar = new System.Windows.Forms.Button();
            this.button_Inicializar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Crono
            // 
            this.label_Crono.AutoSize = true;
            this.label_Crono.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Crono.Location = new System.Drawing.Point(46, 9);
            this.label_Crono.Name = "label_Crono";
            this.label_Crono.Size = new System.Drawing.Size(212, 55);
            this.label_Crono.TabIndex = 0;
            this.label_Crono.Text = "00:00:00";
            // 
            // button_Comenzar
            // 
            this.button_Comenzar.Location = new System.Drawing.Point(12, 96);
            this.button_Comenzar.Name = "button_Comenzar";
            this.button_Comenzar.Size = new System.Drawing.Size(75, 23);
            this.button_Comenzar.TabIndex = 1;
            this.button_Comenzar.Text = "Comenzar";
            this.button_Comenzar.UseVisualStyleBackColor = true;
            this.button_Comenzar.Click += new System.EventHandler(this.button_Comenzar_Click);
            // 
            // button_Parar
            // 
            this.button_Parar.Location = new System.Drawing.Point(93, 96);
            this.button_Parar.Name = "button_Parar";
            this.button_Parar.Size = new System.Drawing.Size(75, 23);
            this.button_Parar.TabIndex = 2;
            this.button_Parar.Text = "Parar";
            this.button_Parar.UseVisualStyleBackColor = true;
            this.button_Parar.Click += new System.EventHandler(this.button_Parar_Click);
            // 
            // button_Inicializar
            // 
            this.button_Inicializar.Location = new System.Drawing.Point(174, 96);
            this.button_Inicializar.Name = "button_Inicializar";
            this.button_Inicializar.Size = new System.Drawing.Size(125, 23);
            this.button_Inicializar.TabIndex = 3;
            this.button_Inicializar.Text = "Iniciar cronómetro";
            this.button_Inicializar.UseVisualStyleBackColor = true;
            this.button_Inicializar.Click += new System.EventHandler(this.button_Inicializar_Click);
            // 
            // Form_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 168);
            this.Controls.Add(this.button_Inicializar);
            this.Controls.Add(this.button_Parar);
            this.Controls.Add(this.button_Comenzar);
            this.Controls.Add(this.label_Crono);
            this.Name = "Form_Timer";
            this.Text = "Form_Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Crono;
        private System.Windows.Forms.Button button_Comenzar;
        private System.Windows.Forms.Button button_Parar;
        private System.Windows.Forms.Button button_Inicializar;
    }
}