namespace ventana
{
    partial class Cap3e1
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
            this.labelR = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonM3 = new System.Windows.Forms.Button();
            this.textBoxPI = new System.Windows.Forms.TextBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(18, 158);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(67, 13);
            this.labelR.TabIndex = 17;
            this.labelR.Text = "Resultado = ";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(29, 64);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(85, 13);
            this.labelN.TabIndex = 16;
            this.labelN.Text = "Ingresar Numero";
            // 
            // buttonM3
            // 
            this.buttonM3.Location = new System.Drawing.Point(180, 80);
            this.buttonM3.Name = "buttonM3";
            this.buttonM3.Size = new System.Drawing.Size(75, 23);
            this.buttonM3.TabIndex = 14;
            this.buttonM3.Text = "Mostrar";
            this.buttonM3.UseVisualStyleBackColor = true;
            this.buttonM3.Click += new System.EventHandler(this.buttonM3_Click);
            // 
            // textBoxPI
            // 
            this.textBoxPI.Location = new System.Drawing.Point(32, 82);
            this.textBoxPI.Name = "textBoxPI";
            this.textBoxPI.Size = new System.Drawing.Size(128, 20);
            this.textBoxPI.TabIndex = 13;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(96, 158);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(0, 13);
            this.labelRes.TabIndex = 18;
            // 
            // Cap3e1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonM3);
            this.Controls.Add(this.textBoxPI);
            this.Name = "Cap3e1";
            this.Text = "Si es par o impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonM3;
        private System.Windows.Forms.TextBox textBoxPI;
        private System.Windows.Forms.Label labelRes;
    }
}