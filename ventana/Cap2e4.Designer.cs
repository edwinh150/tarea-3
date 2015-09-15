namespace ventana
{
    partial class Cap2e4
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
            this.textBoxR3 = new System.Windows.Forms.TextBox();
            this.labelG = new System.Windows.Forms.Label();
            this.buttonM3 = new System.Windows.Forms.Button();
            this.textBoxG2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(22, 156);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(55, 13);
            this.labelR.TabIndex = 17;
            this.labelR.Text = "Resultado";
            // 
            // textBoxR3
            // 
            this.textBoxR3.Location = new System.Drawing.Point(96, 153);
            this.textBoxR3.Name = "textBoxR3";
            this.textBoxR3.ReadOnly = true;
            this.textBoxR3.Size = new System.Drawing.Size(120, 20);
            this.textBoxR3.TabIndex = 15;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(33, 62);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(82, 13);
            this.labelG.TabIndex = 16;
            this.labelG.Text = "Ingresar Grados";
            // 
            // buttonM3
            // 
            this.buttonM3.Location = new System.Drawing.Point(184, 78);
            this.buttonM3.Name = "buttonM3";
            this.buttonM3.Size = new System.Drawing.Size(75, 23);
            this.buttonM3.TabIndex = 14;
            this.buttonM3.Text = "Mostrar";
            this.buttonM3.UseVisualStyleBackColor = true;
            this.buttonM3.Click += new System.EventHandler(this.buttonM3_Click);
            // 
            // textBoxG2
            // 
            this.textBoxG2.Location = new System.Drawing.Point(36, 80);
            this.textBoxG2.Name = "textBoxG2";
            this.textBoxG2.Size = new System.Drawing.Size(128, 20);
            this.textBoxG2.TabIndex = 13;
            // 
            // Cap2e4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxR3);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.buttonM3);
            this.Controls.Add(this.textBoxG2);
            this.Name = "Cap2e4";
            this.Text = "Convertir Grados a Fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxR3;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Button buttonM3;
        private System.Windows.Forms.TextBox textBoxG2;
    }
}