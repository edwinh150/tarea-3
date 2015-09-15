namespace ventana
{
    partial class Cap2e5
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
            this.textBoxRDE = new System.Windows.Forms.TextBox();
            this.labelNDE = new System.Windows.Forms.Label();
            this.buttonMDE = new System.Windows.Forms.Button();
            this.textBoxNDE = new System.Windows.Forms.TextBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonE = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(25, 177);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(55, 13);
            this.labelR.TabIndex = 22;
            this.labelR.Text = "Resultado";
            // 
            // textBoxRDE
            // 
            this.textBoxRDE.Location = new System.Drawing.Point(86, 174);
            this.textBoxRDE.Name = "textBoxRDE";
            this.textBoxRDE.ReadOnly = true;
            this.textBoxRDE.Size = new System.Drawing.Size(93, 20);
            this.textBoxRDE.TabIndex = 20;
            // 
            // labelNDE
            // 
            this.labelNDE.AutoSize = true;
            this.labelNDE.Location = new System.Drawing.Point(97, 71);
            this.labelNDE.Name = "labelNDE";
            this.labelNDE.Size = new System.Drawing.Size(69, 13);
            this.labelNDE.TabIndex = 21;
            this.labelNDE.Text = "Ingresar Cifra";
            // 
            // buttonMDE
            // 
            this.buttonMDE.Location = new System.Drawing.Point(185, 172);
            this.buttonMDE.Name = "buttonMDE";
            this.buttonMDE.Size = new System.Drawing.Size(75, 23);
            this.buttonMDE.TabIndex = 19;
            this.buttonMDE.Text = "Mostrar";
            this.buttonMDE.UseVisualStyleBackColor = true;
            this.buttonMDE.Click += new System.EventHandler(this.buttonMDE_Click);
            // 
            // textBoxNDE
            // 
            this.textBoxNDE.Location = new System.Drawing.Point(67, 97);
            this.textBoxNDE.Name = "textBoxNDE";
            this.textBoxNDE.Size = new System.Drawing.Size(128, 20);
            this.textBoxNDE.TabIndex = 18;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(67, 123);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(61, 17);
            this.radioButtonD.TabIndex = 23;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Dolares";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonE
            // 
            this.radioButtonE.AutoSize = true;
            this.radioButtonE.Location = new System.Drawing.Point(150, 123);
            this.radioButtonE.Name = "radioButtonE";
            this.radioButtonE.Size = new System.Drawing.Size(47, 17);
            this.radioButtonE.TabIndex = 24;
            this.radioButtonE.TabStop = true;
            this.radioButtonE.Text = "Euro";
            this.radioButtonE.UseVisualStyleBackColor = true;
            // 
            // Cap2e5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.radioButtonE);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxRDE);
            this.Controls.Add(this.labelNDE);
            this.Controls.Add(this.buttonMDE);
            this.Controls.Add(this.textBoxNDE);
            this.Name = "Cap2e5";
            this.Text = "Cap2e5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxRDE;
        private System.Windows.Forms.Label labelNDE;
        private System.Windows.Forms.Button buttonMDE;
        private System.Windows.Forms.TextBox textBoxNDE;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonE;
    }
}