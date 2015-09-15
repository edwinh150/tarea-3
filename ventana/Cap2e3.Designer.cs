namespace ventana
{
    partial class Cap2e3
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
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.labelG = new System.Windows.Forms.Label();
            this.buttonM2 = new System.Windows.Forms.Button();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(15, 155);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(55, 13);
            this.labelR.TabIndex = 12;
            this.labelR.Text = "Resultado";
            this.labelR.Click += new System.EventHandler(this.labelR_Click);
            // 
            // textBoxR2
            // 
            this.textBoxR2.Location = new System.Drawing.Point(89, 152);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.ReadOnly = true;
            this.textBoxR2.Size = new System.Drawing.Size(120, 20);
            this.textBoxR2.TabIndex = 10;
            this.textBoxR2.TextChanged += new System.EventHandler(this.textBoxR2_TextChanged);
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(26, 61);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(82, 13);
            this.labelG.TabIndex = 11;
            this.labelG.Text = "Ingresar Grados";
            this.labelG.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonM2
            // 
            this.buttonM2.Location = new System.Drawing.Point(177, 77);
            this.buttonM2.Name = "buttonM2";
            this.buttonM2.Size = new System.Drawing.Size(75, 23);
            this.buttonM2.TabIndex = 9;
            this.buttonM2.Text = "Mostrar";
            this.buttonM2.UseVisualStyleBackColor = true;
            this.buttonM2.Click += new System.EventHandler(this.buttonM2_Click);
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(29, 79);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(128, 20);
            this.textBoxG.TabIndex = 7;
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxG_TextChanged);
            // 
            // Cap2e3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.buttonM2);
            this.Controls.Add(this.textBoxG);
            this.Name = "Cap2e3";
            this.Text = "Convertir Grados a Radianes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Button buttonM2;
        private System.Windows.Forms.TextBox textBoxG;
    }
}