namespace ParteA
{
    partial class Form_MessageBox
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
            this.button_MSJ1 = new System.Windows.Forms.Button();
            this.button_MSJ2 = new System.Windows.Forms.Button();
            this.button_MSJ3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MSJ1
            // 
            this.button_MSJ1.Location = new System.Drawing.Point(88, 52);
            this.button_MSJ1.Name = "button_MSJ1";
            this.button_MSJ1.Size = new System.Drawing.Size(75, 23);
            this.button_MSJ1.TabIndex = 0;
            this.button_MSJ1.Text = "Mensaje 1";
            this.button_MSJ1.UseVisualStyleBackColor = true;
            this.button_MSJ1.Click += new System.EventHandler(this.button_MSJ1_Click);
            // 
            // button_MSJ2
            // 
            this.button_MSJ2.Location = new System.Drawing.Point(88, 81);
            this.button_MSJ2.Name = "button_MSJ2";
            this.button_MSJ2.Size = new System.Drawing.Size(75, 23);
            this.button_MSJ2.TabIndex = 1;
            this.button_MSJ2.Text = "Mensaje 2";
            this.button_MSJ2.UseVisualStyleBackColor = true;
            this.button_MSJ2.Click += new System.EventHandler(this.button_MSJ2_Click);
            // 
            // button_MSJ3
            // 
            this.button_MSJ3.Location = new System.Drawing.Point(88, 110);
            this.button_MSJ3.Name = "button_MSJ3";
            this.button_MSJ3.Size = new System.Drawing.Size(75, 23);
            this.button_MSJ3.TabIndex = 2;
            this.button_MSJ3.Text = "Mensaje 3";
            this.button_MSJ3.UseVisualStyleBackColor = true;
            this.button_MSJ3.Click += new System.EventHandler(this.button_MSJ3_Click);
            // 
            // Form_MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 197);
            this.Controls.Add(this.button_MSJ3);
            this.Controls.Add(this.button_MSJ2);
            this.Controls.Add(this.button_MSJ1);
            this.Name = "Form_MessageBox";
            this.Text = "Form_MessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MSJ1;
        private System.Windows.Forms.Button button_MSJ2;
        private System.Windows.Forms.Button button_MSJ3;
    }
}