namespace ventana
{
    partial class Cap5e3
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
            this.labelDp = new System.Windows.Forms.Label();
            this.textBoxD2 = new System.Windows.Forms.TextBox();
            this.labelRP = new System.Windows.Forms.Label();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.labelNp = new System.Windows.Forms.Label();
            this.buttonMP = new System.Windows.Forms.Button();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDp
            // 
            this.labelDp.AutoSize = true;
            this.labelDp.Location = new System.Drawing.Point(147, 59);
            this.labelDp.Name = "labelDp";
            this.labelDp.Size = new System.Drawing.Size(108, 13);
            this.labelDp.TabIndex = 13;
            this.labelDp.Text = "Ingresar Dimensiones";
            // 
            // textBoxD2
            // 
            this.textBoxD2.Location = new System.Drawing.Point(150, 74);
            this.textBoxD2.Name = "textBoxD2";
            this.textBoxD2.Size = new System.Drawing.Size(113, 20);
            this.textBoxD2.TabIndex = 8;
            // 
            // labelRP
            // 
            this.labelRP.AutoSize = true;
            this.labelRP.Location = new System.Drawing.Point(15, 153);
            this.labelRP.Name = "labelRP";
            this.labelRP.Size = new System.Drawing.Size(55, 13);
            this.labelRP.TabIndex = 12;
            this.labelRP.Text = "Resultado";
            // 
            // textBoxR2
            // 
            this.textBoxR2.Location = new System.Drawing.Point(76, 148);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.ReadOnly = true;
            this.textBoxR2.Size = new System.Drawing.Size(108, 20);
            this.textBoxR2.TabIndex = 10;
            // 
            // labelNp
            // 
            this.labelNp.AutoSize = true;
            this.labelNp.Location = new System.Drawing.Point(12, 59);
            this.labelNp.Name = "labelNp";
            this.labelNp.Size = new System.Drawing.Size(97, 13);
            this.labelNp.TabIndex = 11;
            this.labelNp.Text = "Ingresar n de lados";
            // 
            // buttonMP
            // 
            this.buttonMP.Location = new System.Drawing.Point(190, 146);
            this.buttonMP.Name = "buttonMP";
            this.buttonMP.Size = new System.Drawing.Size(75, 23);
            this.buttonMP.TabIndex = 9;
            this.buttonMP.Text = "Mostrar";
            this.buttonMP.UseVisualStyleBackColor = true;
            this.buttonMP.Click += new System.EventHandler(this.buttonMP_Click);
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(15, 75);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(111, 20);
            this.textBoxN2.TabIndex = 7;
            // 
            // Cap5e3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelDp);
            this.Controls.Add(this.textBoxD2);
            this.Controls.Add(this.labelRP);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.labelNp);
            this.Controls.Add(this.buttonMP);
            this.Controls.Add(this.textBoxN2);
            this.Name = "Cap5e3";
            this.Text = "Poligono regular con funcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDp;
        private System.Windows.Forms.TextBox textBoxD2;
        private System.Windows.Forms.Label labelRP;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.Label labelNp;
        private System.Windows.Forms.Button buttonMP;
        private System.Windows.Forms.TextBox textBoxN2;
    }
}