namespace ventana
{
    partial class Cap5e1
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
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.labelG = new System.Windows.Forms.Label();
            this.buttonMG = new System.Windows.Forms.Button();
            this.textBoxG4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(26, 160);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(55, 13);
            this.labelR.TabIndex = 17;
            this.labelR.Text = "Resultado";
            // 
            // textBoxRG
            // 
            this.textBoxRG.Location = new System.Drawing.Point(89, 157);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.ReadOnly = true;
            this.textBoxRG.Size = new System.Drawing.Size(120, 20);
            this.textBoxRG.TabIndex = 15;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(26, 66);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(82, 13);
            this.labelG.TabIndex = 16;
            this.labelG.Text = "Ingresar Grados";
            // 
            // buttonMG
            // 
            this.buttonMG.Location = new System.Drawing.Point(177, 82);
            this.buttonMG.Name = "buttonMG";
            this.buttonMG.Size = new System.Drawing.Size(75, 23);
            this.buttonMG.TabIndex = 14;
            this.buttonMG.Text = "Mostrar";
            this.buttonMG.UseVisualStyleBackColor = true;
            this.buttonMG.Click += new System.EventHandler(this.buttonMG_Click);
            // 
            // textBoxG4
            // 
            this.textBoxG4.Location = new System.Drawing.Point(29, 84);
            this.textBoxG4.Name = "textBoxG4";
            this.textBoxG4.Size = new System.Drawing.Size(128, 20);
            this.textBoxG4.TabIndex = 13;
            // 
            // Cap5e1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxRG);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.buttonMG);
            this.Controls.Add(this.textBoxG4);
            this.Name = "Cap5e1";
            this.Text = "Grado a Radianes en Funcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxRG;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Button buttonMG;
        private System.Windows.Forms.TextBox textBoxG4;
    }
}