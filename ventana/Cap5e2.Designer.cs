namespace ventana
{
    partial class Cap5e2
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
            this.textBoxRG2 = new System.Windows.Forms.TextBox();
            this.labelG1 = new System.Windows.Forms.Label();
            this.buttonMG2 = new System.Windows.Forms.Button();
            this.textBoxG5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Location = new System.Drawing.Point(23, 157);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(55, 13);
            this.labelR1.TabIndex = 22;
            this.labelR1.Text = "Resultado";
            // 
            // textBoxRG2
            // 
            this.textBoxRG2.Location = new System.Drawing.Point(86, 154);
            this.textBoxRG2.Name = "textBoxRG2";
            this.textBoxRG2.ReadOnly = true;
            this.textBoxRG2.Size = new System.Drawing.Size(120, 20);
            this.textBoxRG2.TabIndex = 20;
            // 
            // labelG1
            // 
            this.labelG1.AutoSize = true;
            this.labelG1.Location = new System.Drawing.Point(23, 63);
            this.labelG1.Name = "labelG1";
            this.labelG1.Size = new System.Drawing.Size(82, 13);
            this.labelG1.TabIndex = 21;
            this.labelG1.Text = "Ingresar Grados";
            // 
            // buttonMG2
            // 
            this.buttonMG2.Location = new System.Drawing.Point(174, 79);
            this.buttonMG2.Name = "buttonMG2";
            this.buttonMG2.Size = new System.Drawing.Size(75, 23);
            this.buttonMG2.TabIndex = 19;
            this.buttonMG2.Text = "Mostrar";
            this.buttonMG2.UseVisualStyleBackColor = true;
            this.buttonMG2.Click += new System.EventHandler(this.buttonMG2_Click);
            // 
            // textBoxG5
            // 
            this.textBoxG5.Location = new System.Drawing.Point(26, 81);
            this.textBoxG5.Name = "textBoxG5";
            this.textBoxG5.Size = new System.Drawing.Size(128, 20);
            this.textBoxG5.TabIndex = 18;
            // 
            // Cap5e2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelR1);
            this.Controls.Add(this.textBoxRG2);
            this.Controls.Add(this.labelG1);
            this.Controls.Add(this.buttonMG2);
            this.Controls.Add(this.textBoxG5);
            this.Name = "Cap5e2";
            this.Text = "Grados a F en funcion";
            this.Load += new System.EventHandler(this.Cap5e2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.TextBox textBoxRG2;
        private System.Windows.Forms.Label labelG1;
        private System.Windows.Forms.Button buttonMG2;
        private System.Windows.Forms.TextBox textBoxG5;
    }
}