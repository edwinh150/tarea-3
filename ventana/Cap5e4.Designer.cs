namespace ventana
{
    partial class Cap5e4
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
            this.labelRF = new System.Windows.Forms.Label();
            this.textBoxRF = new System.Windows.Forms.TextBox();
            this.labelNf = new System.Windows.Forms.Label();
            this.buttonMF = new System.Windows.Forms.Button();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRF
            // 
            this.labelRF.AutoSize = true;
            this.labelRF.Location = new System.Drawing.Point(28, 158);
            this.labelRF.Name = "labelRF";
            this.labelRF.Size = new System.Drawing.Size(55, 13);
            this.labelRF.TabIndex = 27;
            this.labelRF.Text = "Resultado";
            // 
            // textBoxRF
            // 
            this.textBoxRF.Location = new System.Drawing.Point(91, 155);
            this.textBoxRF.Name = "textBoxRF";
            this.textBoxRF.ReadOnly = true;
            this.textBoxRF.Size = new System.Drawing.Size(120, 20);
            this.textBoxRF.TabIndex = 25;
            // 
            // labelNf
            // 
            this.labelNf.AutoSize = true;
            this.labelNf.Location = new System.Drawing.Point(28, 64);
            this.labelNf.Name = "labelNf";
            this.labelNf.Size = new System.Drawing.Size(94, 13);
            this.labelNf.TabIndex = 26;
            this.labelNf.Text = "Ingresar el numero";
            // 
            // buttonMF
            // 
            this.buttonMF.Location = new System.Drawing.Point(179, 80);
            this.buttonMF.Name = "buttonMF";
            this.buttonMF.Size = new System.Drawing.Size(75, 23);
            this.buttonMF.TabIndex = 24;
            this.buttonMF.Text = "Mostrar";
            this.buttonMF.UseVisualStyleBackColor = true;
            this.buttonMF.Click += new System.EventHandler(this.buttonMF_Click);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(31, 82);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(128, 20);
            this.textBoxF.TabIndex = 23;
            // 
            // Cap5e4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelRF);
            this.Controls.Add(this.textBoxRF);
            this.Controls.Add(this.labelNf);
            this.Controls.Add(this.buttonMF);
            this.Controls.Add(this.textBoxF);
            this.Name = "Cap5e4";
            this.Text = "Factorial por funcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRF;
        private System.Windows.Forms.TextBox textBoxRF;
        private System.Windows.Forms.Label labelNf;
        private System.Windows.Forms.Button buttonMF;
        private System.Windows.Forms.TextBox textBoxF;
    }
}