namespace ventana
{
    partial class Cap3e4
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
            this.labelR1 = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonM6 = new System.Windows.Forms.Button();
            this.textBoxNS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Location = new System.Drawing.Point(101, 159);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(0, 13);
            this.labelR1.TabIndex = 23;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(18, 159);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(67, 13);
            this.labelR.TabIndex = 22;
            this.labelR.Text = "Resultado = ";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(29, 65);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(85, 13);
            this.labelN.TabIndex = 21;
            this.labelN.Text = "Ingresar Numero";
            // 
            // buttonM6
            // 
            this.buttonM6.Location = new System.Drawing.Point(180, 81);
            this.buttonM6.Name = "buttonM6";
            this.buttonM6.Size = new System.Drawing.Size(75, 23);
            this.buttonM6.TabIndex = 20;
            this.buttonM6.Text = "Mostrar";
            this.buttonM6.UseVisualStyleBackColor = true;
            this.buttonM6.Click += new System.EventHandler(this.buttonM6_Click);
            // 
            // textBoxNS
            // 
            this.textBoxNS.Location = new System.Drawing.Point(32, 83);
            this.textBoxNS.Name = "textBoxNS";
            this.textBoxNS.Size = new System.Drawing.Size(128, 20);
            this.textBoxNS.TabIndex = 19;
            // 
            // Cap3e4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelR1);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonM6);
            this.Controls.Add(this.textBoxNS);
            this.Name = "Cap3e4";
            this.Text = "Dia de la semana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonM6;
        private System.Windows.Forms.TextBox textBoxNS;
    }
}